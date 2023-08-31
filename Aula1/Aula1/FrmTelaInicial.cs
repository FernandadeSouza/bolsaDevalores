using System;
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
    public partial class TelaPrincipal : Form
    {
        //private const string V = @"INSERT INTO Users (name, datanascimento) VALUES (@name, @data_nascimento)";

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
           Form CadastroCliente = new Form2();
            CadastroCliente.Show();
            WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form LoginCliente = new frmLogin();
            LoginCliente.Show();
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PicLogin_Click(object sender, EventArgs e)
        {
            Form FLogin = new frmLogin();
            FLogin.Show();
        }

        private void picCadastro_Click(object sender, EventArgs e)
        {
            Form FCadastro = new Form2();
            FCadastro.Show();

            

        }
        }
    }


       






