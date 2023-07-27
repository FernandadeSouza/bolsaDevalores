
namespace Aula1
{
    partial class frmInvest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUm = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.lblDois = new System.Windows.Forms.Label();
            this.lblResp1 = new System.Windows.Forms.Label();
            this.btnBest = new System.Windows.Forms.Button();
            this.lblTRes = new System.Windows.Forms.Label();
            this.lblResp2 = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.grbTempo = new System.Windows.Forms.GroupBox();
            this.rbCurto = new System.Windows.Forms.RadioButton();
            this.rbLongo = new System.Windows.Forms.RadioButton();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.libTipo = new System.Windows.Forms.ListBox();
            this.grbTempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(222, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Investidor Iniciante ";
            // 
            // lblUm
            // 
            this.lblUm.AutoSize = true;
            this.lblUm.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUm.Location = new System.Drawing.Point(30, 90);
            this.lblUm.Name = "lblUm";
            this.lblUm.Size = new System.Drawing.Size(334, 21);
            this.lblUm.TabIndex = 1;
            this.lblUm.Text = "O que é a Bolsa de Valores?";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(31, 111);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(704, 32);
            this.lblResp.TabIndex = 2;
            this.lblResp.Text = "É um ambiente onde são negociados ações, títulos e outros ativos. A Bolsa funcion" +
    "a como\r\n um ponto de encontro entre as empresas e os investidores.";
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDois
            // 
            this.lblDois.AutoSize = true;
            this.lblDois.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDois.Location = new System.Drawing.Point(30, 153);
            this.lblDois.Name = "lblDois";
            this.lblDois.Size = new System.Drawing.Size(406, 21);
            this.lblDois.TabIndex = 3;
            this.lblDois.Text = "Como funciona a Bolsa de Valores?";
            // 
            // lblResp1
            // 
            this.lblResp1.AutoSize = true;
            this.lblResp1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp1.Location = new System.Drawing.Point(31, 183);
            this.lblResp1.Name = "lblResp1";
            this.lblResp1.Size = new System.Drawing.Size(632, 32);
            this.lblResp1.TabIndex = 4;
            this.lblResp1.Text = "Uma empresa abre o capital e oferece ações em troca de valores. Com  isso,\r\n o in" +
    "vestidor pode ter um rendimento variável através do investimento inicial.";
            this.lblResp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBest
            // 
            this.btnBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBest.Location = new System.Drawing.Point(411, 608);
            this.btnBest.Name = "btnBest";
            this.btnBest.Size = new System.Drawing.Size(172, 35);
            this.btnBest.TabIndex = 5;
            this.btnBest.Text = " Investimentos";
            this.btnBest.UseVisualStyleBackColor = true;
            this.btnBest.Click += new System.EventHandler(this.btnBest_Click);
            // 
            // lblTRes
            // 
            this.lblTRes.AutoSize = true;
            this.lblTRes.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRes.Location = new System.Drawing.Point(30, 228);
            this.lblTRes.Name = "lblTRes";
            this.lblTRes.Size = new System.Drawing.Size(430, 21);
            this.lblTRes.TabIndex = 6;
            this.lblTRes.Text = "Como investir na Bolsa de Valores ?";
            // 
            // lblResp2
            // 
            this.lblResp2.AutoSize = true;
            this.lblResp2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp2.Location = new System.Drawing.Point(31, 249);
            this.lblResp2.Name = "lblResp2";
            this.lblResp2.Size = new System.Drawing.Size(600, 48);
            this.lblResp2.TabIndex = 7;
            this.lblResp2.Text = "Primeiramente, deve-se criar uma conta gratuita em uma boa  corretora\r\n de valore" +
    "s; ter dinheiro para investir  e além disso, é necessário saber \r\nqual é o melho" +
    "r momento para investir.";
            this.lblResp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(28, 47);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(113, 31);
            this.lblTu.TabIndex = 8;
            this.lblTu.Text = "Tutorial:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(43, 351);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(382, 21);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Quanto você pretende investir ?";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(483, 346);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(201, 26);
            this.txtValor.TabIndex = 10;
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(64, 506);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(0, 21);
            this.lblFim.TabIndex = 11;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(41, 308);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(231, 31);
            this.lblInicio.TabIndex = 12;
            this.lblInicio.Text = "Vamos começar ?";
            // 
            // grbTempo
            // 
            this.grbTempo.Controls.Add(this.rbCurto);
            this.grbTempo.Controls.Add(this.rbLongo);
            this.grbTempo.Location = new System.Drawing.Point(483, 378);
            this.grbTempo.Name = "grbTempo";
            this.grbTempo.Size = new System.Drawing.Size(201, 70);
            this.grbTempo.TabIndex = 13;
            this.grbTempo.TabStop = false;
            this.grbTempo.Text = "Tempo:";
            // 
            // rbCurto
            // 
            this.rbCurto.AutoSize = true;
            this.rbCurto.Location = new System.Drawing.Point(20, 42);
            this.rbCurto.Name = "rbCurto";
            this.rbCurto.Size = new System.Drawing.Size(80, 17);
            this.rbCurto.TabIndex = 1;
            this.rbCurto.TabStop = true;
            this.rbCurto.Text = "Curto Prazo";
            this.rbCurto.UseVisualStyleBackColor = true;
            // 
            // rbLongo
            // 
            this.rbLongo.AutoSize = true;
            this.rbLongo.Location = new System.Drawing.Point(20, 19);
            this.rbLongo.Name = "rbLongo";
            this.rbLongo.Size = new System.Drawing.Size(85, 17);
            this.rbLongo.TabIndex = 0;
            this.rbLongo.TabStop = true;
            this.rbLongo.Text = "Longo Prazo";
            this.rbLongo.UseVisualStyleBackColor = true;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(43, 392);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(442, 42);
            this.lblTempo.TabIndex = 14;
            this.lblTempo.Text = "Você tem interesse em investimentos \r\nde longo ou curto prazo?";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(599, 608);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 35);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(43, 456);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(406, 42);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Quais tipos de investimentos você\r\nconhece?";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(483, 455);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(201, 26);
            this.txtTipo.TabIndex = 17;
            this.txtTipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTipo_MouseClick);
            // 
            // libTipo
            // 
            this.libTipo.FormattingEnabled = true;
            this.libTipo.Location = new System.Drawing.Point(483, 487);
            this.libTipo.Name = "libTipo";
            this.libTipo.Size = new System.Drawing.Size(201, 95);
            this.libTipo.TabIndex = 18;
            // 
            // frmInvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 676);
            this.Controls.Add(this.libTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.grbTempo);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.lblResp2);
            this.Controls.Add(this.lblTRes);
            this.Controls.Add(this.btnBest);
            this.Controls.Add(this.lblResp1);
            this.Controls.Add(this.lblDois);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblUm);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInvest";
            this.Text = "Investidor Iniciante ";
            this.grbTempo.ResumeLayout(false);
            this.grbTempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUm;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label lblDois;
        private System.Windows.Forms.Label lblResp1;
        private System.Windows.Forms.Button btnBest;
        private System.Windows.Forms.Label lblTRes;
        private System.Windows.Forms.Label lblResp2;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.GroupBox grbTempo;
        private System.Windows.Forms.RadioButton rbCurto;
        private System.Windows.Forms.RadioButton rbLongo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.ListBox libTipo;
    }
}