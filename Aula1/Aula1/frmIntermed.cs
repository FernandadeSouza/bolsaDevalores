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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Imobi = new frmAcao("Intermediário", "FII");
            Imobi.Show();
        }

        private void PicAcoes_Click(object sender, EventArgs e)
        {
            Form Intermed = new frmAcao("Intermediário", null);
            Intermed.Show();
        }

        private void frmIntermed_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }        

} 
    

