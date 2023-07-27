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
    public partial class frmInvest : Form
    {
        public frmInvest()
        {
            InitializeComponent();
        }

        private void btnBest_Click(object sender, EventArgs e)
        {
            decimal Valor = Convert.ToDecimal(txtValor.Text);
            string ValorInvest = Convert.ToString(" O usuário pretende investir: " + Valor + " Reais");


            string Tempo = "";
            if (rbLongo.Checked)
            {
                Tempo = "Longo Prazo";
            }

            else if (rbCurto.Checked)
            {
                Tempo = "Curto Prazo";
            }


            string[] skills = new string[libTipo.Items.Count];
            string mSkills = "";
            for (int i =0; i < libTipo.Items.Count; i++)
            {
                skills[i] = libTipo.Items[i].ToString(i);
                mSkills += " ," + skills[i];
            }

            

            MessageBox.Show("Dados Salvos:" + ValorInvest + Tempo+ );
        }

        private void rbLongo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rbLongo.Checked = false;
            rbCurto.Checked = false;

            txtValor.Text = "";
            txtTipo.Text = "";
        }
    }
}
