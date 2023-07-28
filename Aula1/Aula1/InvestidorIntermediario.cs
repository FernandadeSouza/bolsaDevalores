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
    public partial class InvestidorIntermediario : Form
    {
        public InvestidorIntermediario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Umas das melhores ações para um investidor iniciante é\n BBDC4 da empresa: Banco Bradesco S.A.\n do segmento: Financeiro.\n Ou\nWEGE3 da empresa: WEG S.A.\n do segmento: Máquinas e Equipamentos";

        }

        private void btnFundos_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "O primeiro passo é abrir e ter uma conta ativa em uma corretora de valores.\n O segundo passo é procurar qual Fundo Imobiliário você vai adquirir na plataforma da corretora pelo nome do ticker\n Recomendações de FIIS:\n Da lista dos FIIs mais acessíveis do mercado, três ainda contam com recomendação para compra. São eles:\n XP Selection (XPSF11)\n BTG Pactual Crédito Imobiliário (BTCI11)\n e Valora RE (VGIR11).";
        }
    }
}
