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
            decimal Valor = Convert.ToDecimal(txtValor.Text);

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


            MessageBox.Show("Dados Salvos: " + "\n" + "O valor a ser investido é : " + Valor + " Reais " + "\n" + "O usuáriom deseja investimentos com retorno a : " + Tempo + "\n" + "Investimentos Conhecidos: " + mSkills + "\n" + "Sugerimos como investimentos ...");

            using (MyDbContext db = new MyDbContext())

            {

                string query = @"SELECT a.id,  FROM code_cash.acoes AS a JOIN code_cash.niveis AS n ON a.id_niveis = n.id WHERE n.nome = 'Iniciante' OR a.nome IN ('Apple');";
                

/*
                var parameters = new[]

                {

                    new MySqlParameter("@name", name),

                    new MySqlParameter("@birth_date", dataNascimento)

                };



                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);*/

            }
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

        private void frmInvest_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
