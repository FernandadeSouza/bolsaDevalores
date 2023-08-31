﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

namespace Aula1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNome.Text);
            string data = Convert.ToString(txt_Nascimento.Text);
            string email = Convert.ToString(txtData.Text);
            string senha = Convert.ToString(txtSenha.Text);
            string cpf = Convert.ToString(mskcpf.Text);
            string cnpj = Convert.ToString(mskcnpj.Text);

            

        

            using (MyDbContext db = new MyDbContext())
            {
                string query = @"iNSERT INTO Users code_cash.cadastro (nome, datanascimento, " + ((rbCpf.Checked) ? "cpf," : "cnpj,") + " telefone, email, senha) VALUES (@pnome,@pdata," + (rbCpf.Checked ? " @pcpf,":"@pcnpj,") + "@ptelefone,@pemail,@psenha); SELECT LAST_INSERT_ID();";
                var parameters = new[] {
                    new MySqlParameter("@pnome", nome),
                    new MySqlParameter("@pdata", data),
                    new MySqlParameter("@pemail", email),
                    new MySqlParameter("@psenha", senha),
                    (rbCpf.Checked)? new MySqlParameter("@pcpf", cpf): new MySqlParameter("@pcnpj", cnpj),
                    
                };

                int idu = db.Database.SqlQuery<int>(query, parameters).Single();

                Form frmquiz = new Formquiz(idu);

                frmquiz.Show();









            }










        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            string email = txtData.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido");
                txtData.BackColor = Color.Red;
            }
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string dataNascimento = txt_Nascimento.Value.ToString("yyyy-MM-dd");
            
            DateTime today = DateTime.Now;
            DateTime birthDate = txt_Nascimento.Value;
            int age = (int)((today - birthDate).TotalDays / 365.25);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0'; // Mostrar a senha
                pictureBox1.Image = Image.FromFile(@"..\..\Images\view.png");
            }
            else
            {
                txtSenha.PasswordChar = '*'; // Ocultar a senha
                pictureBox1.Image = Image.FromFile(@"..\..\Images\hide.png");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void txtData_Validated(object sender, EventArgs e)
        {
            string email = txtData.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido");
                txtData.BackColor = Color.Red;
            }
        }

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            lblcpf.Visible = true;
            lblcnpj.Visible = false;

            mskcpf.Visible = true;
            mskcnpj.Visible = false;
            
        }

        private void lblcpf_Click(object sender, EventArgs e)
        {

        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            lblcnpj.Visible = true;
            lblcpf.Visible = false;

            mskcnpj.Visible = true;
            mskcpf.Visible = false;
        }

        private void txtData_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
