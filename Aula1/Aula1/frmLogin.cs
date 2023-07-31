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
            string Email = txtEmail.Text;
            string Senha = txtPass.Text;
            // Form cadastro = new FrmCadastro;
            Form logado = new frmInvest();


            if (Email == "")
            {
                //cadastro.Show();
            }
            else
            {
                logado.Show();
            }

            if (Senha == "")
            {
                // cadastro.Show();
            }
            else
            {
                // logado.Show();
            }
        }
    }
}
