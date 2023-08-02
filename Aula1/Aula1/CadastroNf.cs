using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            Form frmquiz = new Formquiz();

            frmquiz.Show();






            




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
    }
}
