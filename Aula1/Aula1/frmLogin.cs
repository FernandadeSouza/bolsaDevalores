using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

// Esses using acima são bibliotecas para o nosso banco de dados

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
                using (MyDbContext db = new MyDbContext())
                {
                    // os @ são tipo variaveis 
                    // No mmento que eu faço new em uma classe ela se torna uma classe instanciada

                    string query = @"SELECT * from code_cash.login WHERE email = @p1 and senha = @p2;";
                    var parameters = new[]
                    {
                        new MySqlParameter("@p1", Email),
                        new MySqlParameter("@p2", Senha)
                    };
                    int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);
                }

                if (Email == "intermed@gmail.com")
                {
                    Form logado = new frmIntermed();
                    logado.Show();
                }
                else if (Email == "avancado@gmail.com")
                {
                    Form logado = new TelaInvestidorAvancado();
                    logado.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado");
                }
            }
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        
    }
}
