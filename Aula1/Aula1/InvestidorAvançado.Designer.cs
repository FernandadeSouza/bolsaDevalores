
namespace Aula1
{
    partial class InvestidorAvançado
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
            this.lblAvançado = new System.Windows.Forms.Label();
            this.lblSTAvançado = new System.Windows.Forms.Label();
            this.lsbAvançado = new System.Windows.Forms.ListBox();
            this.picAvançado = new System.Windows.Forms.PictureBox();
            this.btnInvestirAgora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvançado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvançado
            // 
            this.lblAvançado.AutoSize = true;
            this.lblAvançado.BackColor = System.Drawing.Color.Transparent;
            this.lblAvançado.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvançado.ForeColor = System.Drawing.Color.Black;
            this.lblAvançado.Location = new System.Drawing.Point(14, 9);
            this.lblAvançado.Name = "lblAvançado";
            this.lblAvançado.Size = new System.Drawing.Size(255, 31);
            this.lblAvançado.TabIndex = 0;
            this.lblAvançado.Text = "Investidor Avançado";
            // 
            // lblSTAvançado
            // 
            this.lblSTAvançado.AutoSize = true;
            this.lblSTAvançado.BackColor = System.Drawing.Color.Transparent;
            this.lblSTAvançado.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTAvançado.Location = new System.Drawing.Point(16, 76);
            this.lblSTAvançado.Name = "lblSTAvançado";
            this.lblSTAvançado.Size = new System.Drawing.Size(745, 46);
            this.lblSTAvançado.TabIndex = 1;
            this.lblSTAvançado.Text = "O Investidor Avançado, na comparação com os outros perfis, é o mais tolerante ao " +
    "risco. \r\nEssas são as opções recomendadas para o seu perfil:";
            this.lblSTAvançado.Click += new System.EventHandler(this.lblSTAvançado_Click);
            // 
            // lsbAvançado
            // 
            this.lsbAvançado.BackColor = System.Drawing.Color.White;
            this.lsbAvançado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbAvançado.FormattingEnabled = true;
            this.lsbAvançado.ItemHeight = 21;
            this.lsbAvançado.Items.AddRange(new object[] {
            "- Ações.",
            "",
            "- Commodities ( como café,milho,boi gordo, etc).",
            "",
            "- Moedas ( dólar; por exempo).",
            "",
            "- Brazillian Depositary Receipts (BDR).",
            "",
            "- Exchange Traded Funds (ETF).",
            "",
            "- FIIs e Fundos de Investimento."});
            this.lsbAvançado.Location = new System.Drawing.Point(20, 164);
            this.lsbAvançado.Name = "lsbAvançado";
            this.lsbAvançado.Size = new System.Drawing.Size(624, 235);
            this.lsbAvançado.TabIndex = 2;
            // 
            // picAvançado
            // 
            this.picAvançado.BackColor = System.Drawing.Color.Transparent;
            this.picAvançado.BackgroundImage = global::Aula1.Properties.Resources._3310653;
            this.picAvançado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvançado.Location = new System.Drawing.Point(684, 178);
            this.picAvançado.Name = "picAvançado";
            this.picAvançado.Size = new System.Drawing.Size(209, 176);
            this.picAvançado.TabIndex = 3;
            this.picAvançado.TabStop = false;
            // 
            // btnInvestirAgora
            // 
            this.btnInvestirAgora.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInvestirAgora.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestirAgora.Location = new System.Drawing.Point(706, 373);
            this.btnInvestirAgora.Name = "btnInvestirAgora";
            this.btnInvestirAgora.Size = new System.Drawing.Size(168, 47);
            this.btnInvestirAgora.TabIndex = 4;
            this.btnInvestirAgora.Text = "Investir Agora";
            this.btnInvestirAgora.UseVisualStyleBackColor = false;
            // 
            // InvestidorAvançado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Aula1.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnInvestirAgora);
            this.Controls.Add(this.picAvançado);
            this.Controls.Add(this.lsbAvançado);
            this.Controls.Add(this.lblSTAvançado);
            this.Controls.Add(this.lblAvançado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InvestidorAvançado";
            this.Text = "Investidor Avançado";
            this.Load += new System.EventHandler(this.InvestidorAvançado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvançado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvançado;
        private System.Windows.Forms.Label lblSTAvançado;
        private System.Windows.Forms.ListBox lsbAvançado;
        private System.Windows.Forms.PictureBox picAvançado;
        private System.Windows.Forms.Button btnInvestirAgora;
    }
}