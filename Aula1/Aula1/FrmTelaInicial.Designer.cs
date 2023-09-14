
namespace Aula1
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.picCodeInicial = new System.Windows.Forms.PictureBox();
            this.picCadastro = new System.Windows.Forms.PictureBox();
            this.PicLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCodeInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // picCodeInicial
            // 
            this.picCodeInicial.Image = ((System.Drawing.Image)(resources.GetObject("picCodeInicial.Image")));
            this.picCodeInicial.Location = new System.Drawing.Point(218, 12);
            this.picCodeInicial.Name = "picCodeInicial";
            this.picCodeInicial.Size = new System.Drawing.Size(1162, 633);
            this.picCodeInicial.TabIndex = 0;
            this.picCodeInicial.TabStop = false;
            // 
            // picCadastro
            // 
            this.picCadastro.Image = ((System.Drawing.Image)(resources.GetObject("picCadastro.Image")));
            this.picCadastro.Location = new System.Drawing.Point(218, 549);
            this.picCadastro.Name = "picCadastro";
            this.picCadastro.Size = new System.Drawing.Size(511, 147);
            this.picCadastro.TabIndex = 2;
            this.picCadastro.TabStop = false;
            this.picCadastro.Click += new System.EventHandler(this.picCadastro_Click);
            // 
            // PicLogin
            // 
            this.PicLogin.Image = ((System.Drawing.Image)(resources.GetObject("PicLogin.Image")));
            this.PicLogin.Location = new System.Drawing.Point(949, 571);
            this.PicLogin.Name = "PicLogin";
            this.PicLogin.Size = new System.Drawing.Size(368, 116);
            this.PicLogin.TabIndex = 4;
            this.PicLogin.TabStop = false;
            this.PicLogin.Click += new System.EventHandler(this.PicLogin_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aula1.Properties.Resources.hide;
            this.ClientSize = new System.Drawing.Size(1543, 852);
            this.Controls.Add(this.PicLogin);
            this.Controls.Add(this.picCadastro);
            this.Controls.Add(this.picCodeInicial);
            this.Name = "TelaPrincipal";
            this.Text = "Bem-Vindo ao CODE CASH $ ";
            ((System.ComponentModel.ISupportInitialize)(this.picCodeInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCodeInicial;
        private System.Windows.Forms.PictureBox picCadastro;
        private System.Windows.Forms.PictureBox PicLogin;
    }
}