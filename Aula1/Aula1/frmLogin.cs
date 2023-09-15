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
                string query = @"SELECT * FROM login WHERE email = @pemail and senha = @psenha LIMIT 1;";
                var parameters = new[]
                {
                    new MySqlParameter("@pemail",Email),
                    new MySqlParameter("@psenha",Senha)
                };
                Login login = db.Database.SqlQuery<Login>(query, parameters).SingleOrDefault();

                if(login == null)
                {
                    MessageBox.Show("Usuário não encontrado!");
                    return;
                }

                query = @"SELECT * FROM quiz WHERE id_login = @pcadastro LIMIT 1;";
                parameters = new[]
                {
                    new MySqlParameter("@pcadastro",login.Id)
                };
                quiz = db.Database.SqlQuery<Quiz>(query, parameters).SingleOrDefault();

                if (quiz == null)
                {
                    MessageBox.Show("Responda o quiz!");
                    Form teste = new Formquiz(login.Id_cadastro);
                    teste.Show();
                    return;

                }
            }

            if (quiz.Id_niveis == 1)
            {
                Form logado = new frmInvest();
                logado.WindowState = FormWindowState.Maximized;
                logado.Show();
                this.Hide();

            }
            else if (quiz.Id_niveis== 2)
            {
                Form logado = new frmIntermed();
                logado.WindowState = FormWindowState.Maximized;
                logado.Show();
                this.Hide();
            }
            else if (quiz.Id_niveis == 3)
            {
                Form logado = new TelaInvestidorAvancado();
                logado.WindowState = FormWindowState.Maximized;
                logado.Show();
                this.Hide();

            }

     

            
        }

        private void picVoltar1_Click(object sender, EventArgs e)
        {
            Form voltar_1 = new frmPrincipal();
            voltar_1.Show();
        }
    }
    
}
