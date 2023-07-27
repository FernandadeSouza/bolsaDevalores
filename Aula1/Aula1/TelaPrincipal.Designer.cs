
namespace Aula1
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbPrincipal = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblbacktext = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPrincipal
            // 
            this.pcbPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pcbPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbPrincipal.Image = global::Aula1.Properties.Resources.b3;
            this.pcbPrincipal.Location = new System.Drawing.Point(284, 104);
            this.pcbPrincipal.Name = "pcbPrincipal";
            this.pcbPrincipal.Size = new System.Drawing.Size(254, 183);
            this.pcbPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPrincipal.TabIndex = 0;
            this.pcbPrincipal.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.Location = new System.Drawing.Point(319, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 36);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "CODE CASH $ \r\n";
            // 
            // lblbacktext
            // 
            this.lblbacktext.AutoSize = true;
            this.lblbacktext.BackColor = System.Drawing.Color.Transparent;
            this.lblbacktext.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbacktext.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblbacktext.Location = new System.Drawing.Point(144, 57);
            this.lblbacktext.Name = "lblbacktext";
            this.lblbacktext.Size = new System.Drawing.Size(531, 44);
            this.lblbacktext.TabIndex = 2;
            this.lblbacktext.Text = "Conheça os benefícios dos diversos ativos de Bolsa e alavanque \r\n                " +
    "            seus resultados no longo prazo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(299, 331);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 33);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(433, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula1.Properties.Resources.QLI4V2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblbacktext);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pcbPrincipal);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "TelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Bem-Vindo ao CODE CASH $";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPrincipal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblbacktext;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLogin;
    }
}

