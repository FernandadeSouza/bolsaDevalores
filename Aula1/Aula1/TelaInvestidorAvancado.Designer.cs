
namespace Aula1
{
    partial class TelaInvestidorAvancado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInvestidorAvancado));
            this.InvestidorAvancado = new System.Windows.Forms.Label();
            this.lblAvançado = new System.Windows.Forms.Label();
            this.lblInvestimentosAvan = new System.Windows.Forms.Label();
            this.picitulo = new System.Windows.Forms.PictureBox();
            this.picETF = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicFIIs = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picETF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFIIs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // InvestidorAvancado
            // 
            this.InvestidorAvancado.AutoSize = true;
            this.InvestidorAvancado.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestidorAvancado.ForeColor = System.Drawing.Color.Magenta;
            this.InvestidorAvancado.Location = new System.Drawing.Point(18, 28);
            this.InvestidorAvancado.Name = "InvestidorAvancado";
            this.InvestidorAvancado.Size = new System.Drawing.Size(370, 38);
            this.InvestidorAvancado.TabIndex = 0;
            this.InvestidorAvancado.Text = "Investidor Avançado";
            // 
            // lblAvançado
            // 
            this.lblAvançado.AutoSize = true;
            this.lblAvançado.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvançado.ForeColor = System.Drawing.Color.White;
            this.lblAvançado.Location = new System.Drawing.Point(20, 78);
            this.lblAvançado.Name = "lblAvançado";
            this.lblAvançado.Size = new System.Drawing.Size(454, 108);
            this.lblAvançado.TabIndex = 1;
            this.lblAvançado.Text = "O Investidor Avançado, na comparação \r\ncom outros perfis, é o mais tolerante ao r" +
    "isco. \r\nEssas são as opções recomendadas \r\npara o seu perfil:";
            // 
            // lblInvestimentosAvan
            // 
            this.lblInvestimentosAvan.AutoSize = true;
            this.lblInvestimentosAvan.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestimentosAvan.ForeColor = System.Drawing.Color.White;
            this.lblInvestimentosAvan.Location = new System.Drawing.Point(19, 240);
            this.lblInvestimentosAvan.Name = "lblInvestimentosAvan";
            this.lblInvestimentosAvan.Size = new System.Drawing.Size(449, 341);
            this.lblInvestimentosAvan.TabIndex = 2;
            this.lblInvestimentosAvan.Text = "- Ações.\r\n\r\n- Commodities ( como café,milho, etc).\r\n\r\n- Moedas ( dólar, euro etc)" +
    ".\r\n\r\n- Brazillian Depositary Receipts (BDR).\r\n\r\n- Exchange Traded Funds (ETF).\r\n" +
    "\r\n- FIIs e Fundos de Investimento.";
            // 
            // picitulo
            // 
            this.picitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picitulo.BackgroundImage")));
            this.picitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picitulo.Location = new System.Drawing.Point(775, -13);
            this.picitulo.Name = "picitulo";
            this.picitulo.Size = new System.Drawing.Size(356, 122);
            this.picitulo.TabIndex = 5;
            this.picitulo.TabStop = false;
            // 
            // picETF
            // 
            this.picETF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picETF.BackgroundImage")));
            this.picETF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picETF.Image = ((System.Drawing.Image)(resources.GetObject("picETF.Image")));
            this.picETF.Location = new System.Drawing.Point(588, 281);
            this.picETF.Name = "picETF";
            this.picETF.Size = new System.Drawing.Size(502, 137);
            this.picETF.TabIndex = 6;
            this.picETF.TabStop = false;
            this.picETF.Click += new System.EventHandler(this.picETF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 112);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PicFIIs
            // 
            this.PicFIIs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicFIIs.BackgroundImage")));
            this.PicFIIs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicFIIs.Image = ((System.Drawing.Image)(resources.GetObject("PicFIIs.Image")));
            this.PicFIIs.Location = new System.Drawing.Point(614, 115);
            this.PicFIIs.Name = "PicFIIs";
            this.PicFIIs.Size = new System.Drawing.Size(517, 159);
            this.PicFIIs.TabIndex = 8;
            this.PicFIIs.TabStop = false;
            this.PicFIIs.Click += new System.EventHandler(this.PicFIIs_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(589, 542);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(558, 182);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(843, 248);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 27);
            this.lblResult.TabIndex = 10;
            // 
            // TelaInvestidorAvancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1194, 736);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PicFIIs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picETF);
            this.Controls.Add(this.picitulo);
            this.Controls.Add(this.lblInvestimentosAvan);
            this.Controls.Add(this.lblAvançado);
            this.Controls.Add(this.InvestidorAvancado);
            this.Name = "TelaInvestidorAvancado";
            this.Text = "TelaInvestidorAvancado";
            this.Load += new System.EventHandler(this.TelaInvestidorAvancado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picETF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFIIs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvestidorAvancado;
        private System.Windows.Forms.Label lblAvançado;
        private System.Windows.Forms.Label lblInvestimentosAvan;
        private System.Windows.Forms.PictureBox picitulo;
        private System.Windows.Forms.PictureBox picETF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicFIIs;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblResult;
    }
}