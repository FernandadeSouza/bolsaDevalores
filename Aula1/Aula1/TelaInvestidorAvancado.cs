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
        public TelaInvestidorAvancado()
        {
            InitializeComponent();
        }

        private void TelaInvestidorAvancado_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form telaBDR = new frmAcao("Avançado", "BDR");
            telaBDR.WindowState = FormWindowState.Maximized;
            telaBDR.Show();
            this.Hide();
        }

        private void picETF_Click(object sender, EventArgs e)
        {
            Form telaETF = new frmAcao("Avançado", "ETF");
            telaETF.WindowState = FormWindowState.Maximized;
            telaETF.Show();
            this.Hide();
        }

        private void PicFIIs_Click(object sender, EventArgs e)
        {
          Form telaFII = new frmAcao ("Avançado", "FII");
            telaFII.WindowState = FormWindowState.Maximized;
            telaFII.Show();
            this.Hide();
        }

        private void picRefaz_Click(object sender, EventArgs e)
        {
            
        }
    }
}
