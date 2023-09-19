using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula1.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace Aula1
{
    public partial class frmAcao : Form
    {
        int id_login;
        string nivel;
        public frmAcao(string nivel, string categoria )
        {
            this.id_login = id_login;
            InitializeComponent();
            this.nivel = nivel;
            InitializeComponent();
            using (MyDbContext db = new MyDbContext())
            {
                string query = "SELECT a.id, a.id_niveis,a.codigo, a.nome, a.variacao,a.categoria FROM acoes AS a JOIN niveis AS n ON a.id_niveis = n.id WHERE n.nome = '"+nivel+"' "+(categoria != null ? "and a.categoria = '"+categoria+"';": ";");
                List<Acao> acao = db.Database.SqlQuery<Acao>(query).ToList();
                dGVAcao.DataSource = acao;
                buscaHistoricos(acao[0]);
            }
            
        }

        private async Task buscaHistoricos(Acao acao)
        {
            
            string apiKey = "J854WIN0BCURLXTV";
            string symbol = acao.Codigo;
            MessageBox.Show(symbol);
            string interval = "30min";


            string url = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=" + symbol+ "&interval=" + interval+ "&apikey=" + apiKey;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Analisar o JSON de resposta
                    JObject json = JObject.Parse(responseBody);

                    // Extrair dados relevantes do JSON
                    JObject timeSeries = json["Time Series ("+ interval + ")"].ToObject<JObject>();

                    List<double> prices = new List<double>();

                    foreach (var item in timeSeries)
                    {
                        JObject data = item.Value.ToObject<JObject>();
                        double close = double.Parse(data["4. close"].ToString());

                        prices.Add(close);
                    }



                    double mean = Mean(prices);
                    MessageBox.Show($"Média: {mean}");



                    double stdDev = StdDev(prices, mean);
                    MessageBox.Show($"Desvio padrão: {stdDev}");



                    double confidence = CalculateConfidence(mean, stdDev, prices.Count, prices);
                    MessageBox.Show($"Confidence Level: {confidence}");

                    using (MyDbContext db = new MyDbContext())
                    {
                        string query = "UPDATE acoes SET id_niveis= " + confidence + " WHERE codigo = '" + symbol + "';";
                        db.Database.ExecuteSqlCommand(query);
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro na requisição HTTP: {e.Message}");
                }
            }
        }

        private double Mean(List<double> data)
        {
            double sum = 0;

            foreach (double val in data)
            {
                sum += val;
            }

            return sum / data.Count;
        }



        private double StdDev(List<double> data, double mean)
        {
            double variance = 0;

            foreach (double val in data)
            {
                variance += Math.Pow(val - mean, 2);
            }

            variance /= (data.Count - 1);

            return Math.Sqrt(variance);

        }

        private double CalculateConfidence(double mean, double stdDev, int n, List<double> data)

        {

            // Usando valor z de 1.96 para 95% de confiança 

            double marginOfError = 1.96 * (stdDev / Math.Sqrt(n));
            MessageBox.Show($"marginOfError: {marginOfError}");

            double lowerBound = mean - marginOfError;
            MessageBox.Show($"lowerBound: {lowerBound}");
            double upperBound = mean + marginOfError;

            // Calcula a porcentagem de preços dentro do intervalo de confiança 
            double percentInside = data.Count(val => val >= lowerBound && val <= upperBound) / (double)n;
            MessageBox.Show($"percentInside: {percentInside}");

            if (percentInside >= 0.95)
                return 1;
            else if (percentInside >= 0.50)
                return 2;
            else
                return 3;

        }

        private void frmAcao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (this.nivel)
            {
                case "1":
                    Form f1 = new frmInvest();
                    f1.Show();
                    break;

                case "2":
                    Form f2 = new frmIntermed();
                    f2.Show();
                    break;
                 case "3":
                    Form f3 = new TelaInvestidorAvancado(id_login);
                    f3.Show();
                    break;

            }
        }
    }
}
