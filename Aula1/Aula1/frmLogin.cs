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
using Aula1.Models;

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


            if (Email == "" || Senha == "")
            {
                MessageBox.Show("Preencha os dados");
                return;
            }

            Quiz quiz;
            using (MyDbContext db = new MyDbContext())
            {
                string query = @"SELECT * FROM login WHERE email = @pemail and senha = @psenha;";
                var parameters = new[]
                {
                    new MySqlParameter("@pemail",Email),
                    new MySqlParameter("@psenha",Senha)
                };
                Login cadastro = db.Database.SqlQuery<Login>(query, parameters).Single();

                query = @"SELECT * FROM quiz WHERE cadastro_id = @pcadastro;";
                parameters = new[]
                {
                    new MySqlParameter("@pcadastro",cadastro.Id)
                };
                quiz = db.Database.SqlQuery<Quiz>(query, parameters).Single();
            }

            if (quiz.Id_niveis == 1)
            {
                Form logado = new frmInvest();
                logado.Show();

            }
            else if (quiz.Id_niveis== 2)
            {
                Form logado = new frmIntermed();
                logado.Show();
            }
            else if (quiz.Id_niveis == 3)
            {
                Form logado = new TelaInvestidorAvancado();
                logado.Show();
            
            }

     

            
        }
    }
    
}
