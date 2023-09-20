using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class TelaInvestidorAvancado : Form
    {
        int id_login;
        public TelaInvestidorAvancado(int id_login)
        {
            this.id_login = id_login;
            InitializeComponent();
        }

        private void TelaInvestidorAvancado_Load(object sender, EventArgs e)
        {

        }

      

        private void picrefaz_Click(object sender, EventArgs e)
        {
            Form perguntas = new Formquiz(id_login);
            perguntas.WindowState = FormWindowState.Maximized;
            perguntas.Show();
            this.Hide(); 
        }

        

        private void picFinanceira_Click(object sender, EventArgs e)
        {
            Form telaFinanceira = new frmAcao("Avançado", "Financeira");
            telaFinanceira.WindowState = FormWindowState.Maximized;
            telaFinanceira.Show();
            this.Hide();
        }

        private void picIndustria_Click(object sender, EventArgs e)
        {
            Form telaIndustria = new frmAcao("Avançado", "Indústria");
            telaIndustria.WindowState = FormWindowState.Maximized;
            telaIndustria.Show();
            this.Hide();
        }

        private void picTecnologia_Click(object sender, EventArgs e)
        {
            Form telaTecnologia = new frmAcao("Avançado", "Tecnologia");
            telaTecnologia.WindowState = FormWindowState.Maximized;
            telaTecnologia.Show();
            this.Hide();
        }

        private void picRefaz_Click(object sender, EventArgs e)
        {
            Form perguntas = new Formquiz(id_login);
            perguntas.WindowState = FormWindowState.Maximized;
            perguntas.Show();
            this.Hide();
        }
    }
}
