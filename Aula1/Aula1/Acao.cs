﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula1.Models;


namespace Aula1
{
    public partial class frmAcao : Form
    {
        public frmAcao()
        {
           
        }

        private void frmAcao_Load(object sender, EventArgs e)
        {

            InitializeComponent();
            using (MyDbContext db = new MyDbContext())
            {
                string query = @"SELECT a.id, a.id_niveis,a.codigo, a.nome, a.variacao  FROM code_cash.acoes AS a JOIN code_cash.niveis AS n ON a.id_niveis = n.id WHERE n.nome = 'Iniciante';";
                List<frmAcao> acao = db.Database.SqlQuery<frmAcao>(query).ToList();
                dGVAcao.DataSource = acao;

            }
        }
    }
}
