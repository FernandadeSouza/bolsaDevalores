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
    }
}
