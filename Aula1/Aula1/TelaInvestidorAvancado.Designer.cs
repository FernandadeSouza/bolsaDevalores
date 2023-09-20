
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
            this.lblFinanceira = new System.Windows.Forms.Label();
            this.picitulo = new System.Windows.Forms.PictureBox();
            this.picrefaz = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picIndustria = new System.Windows.Forms.PictureBox();
            this.picTecnologia = new System.Windows.Forms.PictureBox();
            this.lblIndustria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrefaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndustria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTecnologia)).BeginInit();
            this.SuspendLayout();
            // 
            // InvestidorAvancado
            // 
            this.InvestidorAvancado.AutoSize = true;
            this.InvestidorAvancado.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestidorAvancado.ForeColor = System.Drawing.Color.Magenta;
            this.InvestidorAvancado.Location = new System.Drawing.Point(707, 30);
            this.InvestidorAvancado.Name = "InvestidorAvancado";
            this.InvestidorAvancado.Size = new System.Drawing.Size(370, 38);
            this.InvestidorAvancado.TabIndex = 0;
            this.InvestidorAvancado.Text = "Investidor Avançado";
            // 
            // lblFinanceira
            // 
            this.lblFinanceira.AutoSize = true;
            this.lblFinanceira.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinanceira.ForeColor = System.Drawing.Color.Magenta;
            this.lblFinanceira.Location = new System.Drawing.Point(50, 106);
            this.lblFinanceira.Name = "lblFinanceira";
            this.lblFinanceira.Size = new System.Drawing.Size(380, 29);
            this.lblFinanceira.TabIndex = 1;
            this.lblFinanceira.Text = "Ações de Categoria Financeira:";
            // 
            // picitulo
            // 
            this.picitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picitulo.BackgroundImage")));
            this.picitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picitulo.Location = new System.Drawing.Point(1442, 12);
            this.picitulo.Name = "picitulo";
            this.picitulo.Size = new System.Drawing.Size(366, 142);
            this.picitulo.TabIndex = 5;
            this.picitulo.TabStop = false;
            // 
            // picrefaz
            // 
            this.picrefaz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picrefaz.BackgroundImage")));
            this.picrefaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picrefaz.Image = ((System.Drawing.Image)(resources.GetObject("picrefaz.Image")));
            this.picrefaz.Location = new System.Drawing.Point(1280, 637);
            this.picrefaz.Name = "picrefaz";
            this.picrefaz.Size = new System.Drawing.Size(498, 179);
            this.picrefaz.TabIndex = 9;
            this.picrefaz.TabStop = false;
            this.picrefaz.Click += new System.EventHandler(this.picrefaz_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 719);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 97);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.picFinanceira_Click);
            // 
            // picIndustria
            // 
            this.picIndustria.Image = ((System.Drawing.Image)(resources.GetObject("picIndustria.Image")));
            this.picIndustria.Location = new System.Drawing.Point(468, 719);
            this.picIndustria.Name = "picIndustria";
            this.picIndustria.Size = new System.Drawing.Size(345, 97);
            this.picIndustria.TabIndex = 12;
            this.picIndustria.TabStop = false;
            this.picIndustria.Click += new System.EventHandler(this.picIndustria_Click);
            // 
            // picTecnologia
            // 
            this.picTecnologia.Image = ((System.Drawing.Image)(resources.GetObject("picTecnologia.Image")));
            this.picTecnologia.Location = new System.Drawing.Point(862, 719);
            this.picTecnologia.Name = "picTecnologia";
            this.picTecnologia.Size = new System.Drawing.Size(368, 97);
            this.picTecnologia.TabIndex = 13;
            this.picTecnologia.TabStop = false;
            this.picTecnologia.Click += new System.EventHandler(this.picTecnologia_Click);
            // 
            // lblIndustria
            // 
            this.lblIndustria.AutoSize = true;
            this.lblIndustria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustria.ForeColor = System.Drawing.Color.Magenta;
            this.lblIndustria.Location = new System.Drawing.Point(50, 248);
            this.lblIndustria.Name = "lblIndustria";
            this.lblIndustria.Size = new System.Drawing.Size(357, 29);
            this.lblIndustria.TabIndex = 14;
            this.lblIndustria.Text = "Ações de Categoria Indústria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(50, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ações de Categoria Tecnologia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1820, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1930, 58);
            this.label3.TabIndex = 17;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1684, 58);
            this.label4.TabIndex = 18;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TelaInvestidorAvancado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1820, 846);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIndustria);
            this.Controls.Add(this.picTecnologia);
            this.Controls.Add(this.picIndustria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picrefaz);
            this.Controls.Add(this.picitulo);
            this.Controls.Add(this.lblFinanceira);
            this.Controls.Add(this.InvestidorAvancado);
            this.Name = "TelaInvestidorAvancado";
            this.Text = "TelaInvestidorAvancado";
            this.Load += new System.EventHandler(this.TelaInvestidorAvancado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrefaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndustria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTecnologia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvestidorAvancado;
        private System.Windows.Forms.Label lblFinanceira;
        private System.Windows.Forms.PictureBox picitulo;
        private System.Windows.Forms.PictureBox picrefaz;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picIndustria;
        private System.Windows.Forms.PictureBox picTecnologia;
        private System.Windows.Forms.Label lblIndustria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}