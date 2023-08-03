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
            lblResult.Text = "Tesla\nMercadoLivre\nMicroSoft\nApple\nNvidia\nGoogle";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form TelaQuiz = new Formquiz();
            TelaQuiz.Show();
        }

        private void picETF_Click(object sender, EventArgs e)
        {
            lblResult.Text = "BBOV11 – Banco do Brasil\nBOVA11 – BlackRock\nBOVB11 – Bradesco\nXBOV11 – Caixa Asset\n";
        }

        private void PicFIIs_Click(object sender, EventArgs e)
        {
            lblResult.Text = "TEPP1  Lajes Corporativas\nHGFF11	Fundos de Papel\nBBPO11	Híbrido\nXPLG11	Logística";
        }
    }
}
