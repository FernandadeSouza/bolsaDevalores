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
    public partial class Formquiz : Form
    {
        public Formquiz()
        {
            InitializeComponent();
        }

        public string resposta1;
        public string resposta2;
        public string resposta3;


        // Contadores para cada perfil de investidor
        public int contadorIniciante = 0;
        public int contadorIntermediario = 0;
        public int contadorAvancado = 0;
        public Boolean cond1;


        public void teste(double quiz)
        {
            if (rbAQuiz1.Checked || rbAQuiz2.Checked || rbAQuiz3.Checked || rbAQuiz4.Checked || rbAQuiz5.Checked) { contadorIniciante++; }
            if (rbBQuiz1.Checked || rbBQuiz2.Checked || rbBQuiz3.Checked || rbBQuiz4.Checked || rbBQuiz5.Checked) { contadorIntermediario++; }
            if (rbCQuiz1.Checked || rbCQuiz2.Checked || rbCQuiz3.Checked || rbCQuiz4.Checked || rbCQuiz5.Checked) { contadorAvancado++; }

            if (quiz == 1)
            {
                if (rbAQuiz1.Checked || rbBQuiz1.Checked || rbCQuiz1.Checked)
                {
                    cond1 = true;
                }
                else
                {
                    cond1 = false;
                }
            }
            if (quiz == 2)
            {
                if (rbAQuiz2.Checked || rbBQuiz2.Checked || rbCQuiz2.Checked)
                {
                    cond1 = true;
                }
                else
                {
                    cond1 = false;
                }
            }


            if (quiz == 3)
            {
                if (rbAQuiz3.Checked || rbBQuiz3.Checked || rbCQuiz3.Checked)
                {
                    cond1 = true;
                }
                else
                {
                    cond1 = false;
                }
            }
            if (quiz == 4)
            {
                if (rbAQuiz4.Checked || rbBQuiz4.Checked || rbCQuiz4.Checked)
                {
                    cond1 = true;
                }
                else
                {
                    cond1 = false;
                }

            }
            if (quiz == 5)
            {
                if (rbAQuiz5.Checked || rbBQuiz5.Checked || rbCQuiz5.Checked)
                {
                    cond1 = true;
                }
                else
                {
                    cond1 = false;
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            teste(1);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage2;


            }

            else MessageBox.Show("Escolha uma das alternativas");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            teste(2);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage3;


            }

            else MessageBox.Show("Escolha uma das alternativas");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            teste(3);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage4;


            }

            else MessageBox.Show("Escolha uma das alternativas");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            teste(4);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage5;


            }

            else MessageBox.Show("Escolha uma das alternativas");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            teste(5);

            if (cond1 == true)
            {
                if (contadorIniciante > contadorIntermediario && contadorIniciante > contadorAvancado)
                {
                    // Perfil Conservador
                    label5.Text = "Seu perfil de investidor é Iniciante.";
                }
                else if (contadorIntermediario > contadorIniciante && contadorIntermediario > contadorAvancado)
                {
                    // Perfil Moderado
                    label5.Text = "Seu perfil de investidor é Intermediario.";
                }
                else if (contadorAvancado > contadorIniciante && contadorAvancado > contadorIntermediario)
                {
                    // Perfil Agressivo
                    label5.Text = "Seu perfil de investidor é Avançado.";
                }
                else
                {
                    // Se houver empate entre os contadores, pode-se considerar um perfil balanceado ou fazer algo personalizado.
                    label5.Text = "Seu perfil de investidor é balanceado.";
                }



                tabControl1.SelectedTab = tabPage6;


            }

            else MessageBox.Show("Escolha uma das alternativas");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            contadorIniciante = 0;
            contadorIntermediario = 0;
            contadorAvancado = 0;



            tabControl1.SelectedTab = tabPage1;
        }
    }
}
    
