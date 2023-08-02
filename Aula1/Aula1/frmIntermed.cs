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
    public partial class frmIntermed : Form
    {
        public frmIntermed()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "O primeiro passo é abrir e ter uma conta ativa em uma corretora de valores.\n O segundo passo é procurar qual fundo imobiliário você vai adquirir na plataforma da corretora pelo nome do ticker\n Recomendações de FIIs mais acessíveis do mercado,\n três ainda contam com recomendação para compra. São eles: \n XP Selection (XPSF11)\n BTG Pactual Crédito Imobiliário (BTCI11)\n e Valora  RE (VGIR11).";
        }

        private void PicAcoes_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Uma das melhores ações para um investidor começar é\n BBCD4 da empresa: Banco do bradesco S.A. \n do segmento FINANCEIRO.\n ou WEGE3 da empresa: WEG S.A.\n do segmento MÁQUINAS E EQUIPAMENTOS";
        }

        private void frmIntermed_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }
    }
}
