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

namespace Aula1
{
    public partial class frmInvest : Form
    {
        public frmInvest()
        {
            InitializeComponent();

            
        }

     
        

        private void picFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

    

        private void picInvest_Click(object sender, EventArgs e)
        {
            Form acao = new frmAcao("Iniciante",null);
            acao.WindowState = FormWindowState.Maximized;
            acao.Show();
            this.Hide();
        }

        private void lblUm_Click(object sender, EventArgs e)
        {

        }

        private void lblTRes_Click(object sender, EventArgs e)
        {

        }

        private void lblResp2_Click(object sender, EventArgs e)
        {

        }

        private void lblDois_Click(object sender, EventArgs e)
        {

        }

        private void lblResp_Click(object sender, EventArgs e)
        {

        }

        private void lblResp1_Click(object sender, EventArgs e)
        {

        }
    }
}
