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
        public frmAcao(string nivel, string categoria )
        {
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

                    // Calcular a variação e classificar a ação
                    double somaVariacao = 0;
                    double somaVolume = 0;
                    int cont = 0;

                    foreach (var item in timeSeries)
                    {
                        JObject data = item.Value.ToObject<JObject>();
                        double openPrice = double.Parse(data["1. open"].ToString());
                        double closePrice = double.Parse(data["4. close"].ToString());
                        double volume = double.Parse(data["5. volume"].ToString());

                        double variacao = closePrice - openPrice;

                        somaVariacao += variacao * variacao; // Soma dos quadrados das variações
                        somaVolume += volume;
                        cont++;
                    }

                    // Calcula a variância amostral
                    double mediaVariacao = somaVariacao / cont;
                    double mediaVolume = somaVolume / cont;

                    double variancia = somaVariacao / (cont - 1);

                    // Definir regras para classificação
                    int classificacao;

                    if (variancia > 0.1)
                    {
                        classificacao = 3;
                    }
                    else if (variancia < -0.1)
                    {
                        classificacao = 1;
                    }
                    else
                    {
                        classificacao = 2;
                    }

                    MessageBox.Show("v: "+ variancia);

                    /*using (MyDbContext db = new MyDbContext())
                    {
                        string query = "UPDATE acoes SET id_niveis= " + classificacao + " WHERE codigo = '" + symbol + "';";
                        db.Database.ExecuteSqlCommand(query);
                    }*/
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Erro na requisição HTTP: {e.Message}");
                }
            }
        }

        private void frmAcao_Load(object sender, EventArgs e)
        {

        }
    }
}
