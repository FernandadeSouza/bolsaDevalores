﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

namespace Aula1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0'; // Mostrar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtPass.PasswordChar = '*'; // Ocultar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Senha = txtPass.Text;
            Form cadastro = new Form();



            if (Email == "" || Senha == "")
            {
                MessageBox.Show("Preencha os dados");
            }
            else
            {
                if (Email == "intermed@gmail.com")
                {
                    Form logado = new frmIntermed();
                    logado.Show();
                } else if (Email == "avancado@gmail.com")
                {
                    Form logado = new TelaInvestidorAvancado(); 
                    logado.Show();
                } else if (Email== "iniciante@gmail.com")
                {
                    Form logado = new frmInvest();
                    logado.Show();
                }

     
            else
                {
                    MessageBox.Show("Usuario não cadastrado");
                }
            }

            using (MyDbContext db = new MyDbContext())
        }
    }
}
