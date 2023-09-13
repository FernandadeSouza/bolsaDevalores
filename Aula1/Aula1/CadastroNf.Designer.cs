
namespace Aula1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picNome = new System.Windows.Forms.PictureBox();
            this.picNascimento = new System.Windows.Forms.PictureBox();
            this.lblcpf = new System.Windows.Forms.PictureBox();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcnpj = new System.Windows.Forms.PictureBox();
            this.mskcnpj = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.pctbCadastrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNascimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcnpj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCadastrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(311, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(713, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(309, 337);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(713, 24);
            this.txtData.TabIndex = 4;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged_1);
            this.txtData.Validated += new System.EventHandler(this.txtData_Validated);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(309, 427);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(406, 24);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(372, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(836, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para começar, informe os dados que você vai usar para acessar sua conta CodeCash:" +
    "";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Location = new System.Drawing.Point(309, 269);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(390, 26);
            this.dtNascimento.TabIndex = 13;
            this.dtNascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picEmail
            // 
            this.picEmail.Image = ((System.Drawing.Image)(resources.GetObject("picEmail.Image")));
            this.picEmail.Location = new System.Drawing.Point(309, 301);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(115, 30);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEmail.TabIndex = 15;
            this.picEmail.TabStop = false;
            // 
            // picSenha
            // 
            this.picSenha.Image = ((System.Drawing.Image)(resources.GetObject("picSenha.Image")));
            this.picSenha.Location = new System.Drawing.Point(309, 382);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(100, 34);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSenha.TabIndex = 16;
            this.picSenha.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1320, 648);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(351, 170);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(676, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(223, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // picNome
            // 
            this.picNome.Image = ((System.Drawing.Image)(resources.GetObject("picNome.Image")));
            this.picNome.Location = new System.Drawing.Point(309, 87);
            this.picNome.Name = "picNome";
            this.picNome.Size = new System.Drawing.Size(289, 30);
            this.picNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNome.TabIndex = 19;
            this.picNome.TabStop = false;
            // 
            // picNascimento
            // 
            this.picNascimento.Image = ((System.Drawing.Image)(resources.GetObject("picNascimento.Image")));
            this.picNascimento.Location = new System.Drawing.Point(309, 233);
            this.picNascimento.Name = "picNascimento";
            this.picNascimento.Size = new System.Drawing.Size(300, 30);
            this.picNascimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNascimento.TabIndex = 20;
            this.picNascimento.TabStop = false;
            // 
            // lblcpf
            // 
            this.lblcpf.Image = ((System.Drawing.Image)(resources.GetObject("lblcpf.Image")));
            this.lblcpf.Location = new System.Drawing.Point(311, 151);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(127, 31);
            this.lblcpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcpf.TabIndex = 21;
            this.lblcpf.TabStop = false;
            this.lblcpf.Click += new System.EventHandler(this.lblcpf_Click);
            // 
            // mskcpf
            // 
            this.mskcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskcpf.Location = new System.Drawing.Point(467, 201);
            this.mskcpf.Mask = "000.000.000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(140, 26);
            this.mskcpf.TabIndex = 22;
            this.mskcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpf_MaskInputRejected);
            // 
            // lblcnpj
            // 
            this.lblcnpj.Image = ((System.Drawing.Image)(resources.GetObject("lblcnpj.Image")));
            this.lblcnpj.Location = new System.Drawing.Point(624, 151);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(127, 31);
            this.lblcnpj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblcnpj.TabIndex = 23;
            this.lblcnpj.TabStop = false;
            // 
            // mskcnpj
            // 
            this.mskcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskcnpj.Location = new System.Drawing.Point(437, 201);
            this.mskcnpj.Mask = "00.000.000/0000-00";
            this.mskcnpj.Name = "mskcnpj";
            this.mskcnpj.Size = new System.Drawing.Size(170, 26);
            this.mskcnpj.TabIndex = 24;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(309, 475);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(154, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(309, 541);
            this.mskTelefone.Mask = "(99)0000-00000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(133, 22);
            this.mskTelefone.TabIndex = 26;
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Location = new System.Drawing.Point(311, 188);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(14, 13);
            this.rbCpf.TabIndex = 27;
            this.rbCpf.TabStop = true;
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged);
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Location = new System.Drawing.Point(593, 182);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(14, 13);
            this.rbCnpj.TabIndex = 28;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.UseVisualStyleBackColor = true;
            this.rbCnpj.CheckedChanged += new System.EventHandler(this.rbCnpj_CheckedChanged);
            // 
            // pctbCadastrar
            // 
            this.pctbCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("pctbCadastrar.Image")));
            this.pctbCadastrar.Location = new System.Drawing.Point(547, 648);
            this.pctbCadastrar.Name = "pctbCadastrar";
            this.pctbCadastrar.Size = new System.Drawing.Size(535, 156);
            this.pctbCadastrar.TabIndex = 29;
            this.pctbCadastrar.TabStop = false;
            this.pctbCadastrar.Click += new System.EventHandler(this.pctbCadastrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1683, 830);
            this.Controls.Add(this.pctbCadastrar);
            this.Controls.Add(this.rbCnpj);
            this.Controls.Add(this.rbCpf);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.mskcnpj);
            this.Controls.Add(this.lblcnpj);
            this.Controls.Add(this.mskcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.picNascimento);
            this.Controls.Add(this.picNome);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNascimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblcnpj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCadastrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picNome;
        private System.Windows.Forms.PictureBox picNascimento;
        private System.Windows.Forms.PictureBox lblcpf;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.PictureBox lblcnpj;
        private System.Windows.Forms.MaskedTextBox mskcnpj;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.PictureBox pctbCadastrar;
    }
}