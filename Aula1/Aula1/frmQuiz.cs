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
    public partial class Formquiz : Form
    {
        int id_login;
        public Formquiz(int id_login)
        {
            this.id_login = id_login;
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

        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            teste(2);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage3;


            }

            else MessageBox.Show("Escolha uma das alternativas");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            teste(3);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage4;


            }

            else MessageBox.Show("Escolha uma das alternativas");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            teste(4);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage5;


            }

            else MessageBox.Show("Escolha uma das alternativas");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            teste(4);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage5;


            }

            else MessageBox.Show("Escolha uma das alternativas");
        }

        private void picConfirmar2_Click(object sender, EventArgs e)
        {
            teste(2);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage3;


            }

            else MessageBox.Show("Escolha uma das alternativas");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          

                teste(1);

                if (cond1 == true)
                {
                    tabControl1.SelectedTab = tabPage2;


                }

                else MessageBox.Show("Escolha uma das alternativas");




       

        }

        private void picConfirmar3_Click(object sender, EventArgs e)
        {
            
            teste(3);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage4;


            }

            else MessageBox.Show("Escolha uma das alternativas");

        }

        private void picConfirmar4_Click(object sender, EventArgs e)
        {

            teste(4);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage5;


            }

            else MessageBox.Show("Escolha uma das alternativas");

        }

        private void picConfirmar5_Click(object sender, EventArgs e)
        {
            {
                teste(5);

                if (cond1 == true)
                {
                    tabControl1.SelectedTab = tabPage6;


                }

                else MessageBox.Show("Escolha uma das alternativas");
            }

        }

        private void picReiniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void picProximo_Click(object sender, EventArgs e)
        {
            bool avan=false;
            bool inte = false;
            bool inic = false;
            if (contadorAvancado > contadorIntermediario)
            {
                avan = true;
                inte = false;
            }
            if (contadorAvancado > contadorIniciante)
            {
                avan = true;
                inic = false;
            }


            if (contadorIntermediario > contadorAvancado)
            {
                inte = true;
                avan = false;
            }
            if (contadorIntermediario > contadorIniciante)
            {
                inte = true;
                inic = false;
            }


            if (contadorIniciante > contadorAvancado)
            {
                inic = true;
                avan = false;
            }
            if (contadorIniciante > contadorIntermediario)
            {
                inic = true;
                inte = false;
            }

            if (inic)
            {
                cadastra_quiz(1);
                Form frmInic = new frmInvest();
                frmInic.Show();
            }

            if (inte)
            {
                cadastra_quiz(2);
                Form frmInte = new frmIntermed();
                frmInte.Show();
            }

            if (avan)
            {
                cadastra_quiz(3);
                Form frmAvan = new TelaInvestidorAvancado();
                frmAvan.Show();
            }
        }

        private int cadastra_quiz(int nivel)
        {


            using (MyDbContext db = new MyDbContext())

            {
                char p1 = (rbAQuiz1.Checked ? 'A' : (rbBQuiz1.Checked ? 'B' : 'C'));

                char p2 = (rbAQuiz2.Checked ? 'A' : (rbBQuiz2.Checked ? 'B' : 'C'));

                char p3 = (rbAQuiz3.Checked ? 'A' : (rbBQuiz3.Checked ? 'B' : 'C'));

                char p4 = (rbAQuiz4.Checked ? 'A' : (rbBQuiz4.Checked ? 'B' : 'C'));

                char p5 = (rbAQuiz5.Checked ? 'A' : (rbBQuiz5.Checked ? 'B' : 'C'));

                string query = @"INSERT INTO quiz (id_login, id_niveis,questionario_1,questionario_2,questionario_3,questionario_4,questionario_5) VALUES (@plogin,@pnivel,@p1,@p2,@p3,@p4,@p5); SELECT LAST_INSERT_ID();";

                var parameters = new[]
                {

                    new MySqlParameter("@plogin",this.id_login),

                    new MySqlParameter("@pnivel",nivel),

                    new MySqlParameter("@p1",p1),

                    new MySqlParameter ("@p2",p2),

                    new MySqlParameter("@p3",p3),

                    new MySqlParameter("@p4",p4),

                    new MySqlParameter("@p5",p5)
                };

                int idQuiz = db.Database.SqlQuery<int>(query, parameters).Single();
                return idQuiz;
            }

            return -1;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            teste(1);

            if (cond1 == true)
            {
                tabControl1.SelectedTab = tabPage2;


            }

            else MessageBox.Show("Escolha uma das alternativas");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "você é um investidor iniciante";
        }
    }
}

