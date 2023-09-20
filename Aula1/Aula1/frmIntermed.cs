using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula1.models;

namespace Aula1
{
    public partial class frmIntermed : Form
    {
        public frmIntermed()
        {
            InitializeComponent();
        }

        private void PicFinan_Click(object sender, EventArgs e)
        {
            Form Financeiro = new frmAcao("Intermediário", "Financeira");
            Financeiro.WindowState = FormWindowState.Maximized;
            Financeiro.Show();
            this.Hide();

        }

        private void PicTec_Click(object sender, EventArgs e)
        {
            Form Tecnologia = new frmAcao("Intermediário", null);
            Tecnologia.WindowState = FormWindowState.Maximized;
            Tecnologia.Show();
            this.Hide();
        }
    }        

} 
    

