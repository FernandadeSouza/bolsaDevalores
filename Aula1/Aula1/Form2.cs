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

     
        private void txtTipo_MouseClick(object sender, MouseEventArgs e)
        {
            string skill = txtTipo.Text;
            for (int i = 0; i < libTipo.Items.Count; i++)
            {
                string pegar = libTipo.Items.ToString();
                if (pegar == skill)
                {
                    MessageBox.Show("Esse investimento já foi inserido!");
                    return;
                }

            }
            libTipo.Items.Add(skill);
            txtTipo.Text = "";

        }

        private void picDados_Click(object sender, EventArgs e)
        {
            string Valor = Convert.ToString(txtValor.Text);

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
            for (int i = 0; i < libTipo.Items.Count; i++)
            {
                skills[i] = libTipo.Items[i].ToString();
                mSkills += skills[i] + ",";
            }


            MessageBox.Show("Dados Salvos: " + "\n" + "O valor a ser investido é : " + Valor + " Reais " + "\n" + "O usuário deseja investimentos com retorno a : " + Tempo + "\n" + "Investimentos Conhecidos: " + mSkills );

           
           

        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            rbLongo.Checked = false;
            rbCurto.Checked = false;

            txtValor.Text = "";
            txtTipo.Text = "";
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
    }
}
