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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNome.Text);
            string data = Convert.ToString(txtData.Text);
            string email = Convert.ToString(txtEmail.Text);
            string senha = Convert.ToString(txtSenha.Text);

            Form frmquiz = new Form1();

            //frmquiz.show();






            




        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string dataNascimento = dpDataNascimento.Value.ToString("yyyy-MM-dd");
            DateTime today = DateTime.Now;
            DateTime birthDate = dpDataNascimento.Value;
            int age = (int)((today - birthDate).TotalDays / 365.25);
        }
    }
}
