
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
            this.picitulo = new System.Windows.Forms.PictureBox();
            this.picrefaz = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picIndustria = new System.Windows.Forms.PictureBox();
            this.picTecnologia = new System.Windows.Forms.PictureBox();
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
            // lblAvançado
            // 
            this.lblAvançado.AutoSize = true;
            this.lblAvançado.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvançado.ForeColor = System.Drawing.Color.White;
            this.lblAvançado.Location = new System.Drawing.Point(32, 127);
            this.lblAvançado.Name = "lblAvançado";
            this.lblAvançado.Size = new System.Drawing.Size(1340, 27);
            this.lblAvançado.TabIndex = 1;
            this.lblAvançado.Text = "O Investidor Avançado, na comparação com outros perfis, é o mais tolerante ao ris" +
    "co. Essas são as opções recomendadas para o seu perfil:";
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
            this.picrefaz.Location = new System.Drawing.Point(1278, 609);
            this.picrefaz.Name = "picrefaz";
            this.picrefaz.Size = new System.Drawing.Size(498, 179);
            this.picrefaz.TabIndex = 9;
            this.picrefaz.TabStop = false;
            this.picrefaz.Click += new System.EventHandler(this.picrefaz_Click);
            // 
            // picRefaz
            // 
           /* this.picRefaz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRefaz.BackgroundImage")));
            this.picRefaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRefaz.Image = ((System.Drawing.Image)(resources.GetObject("picRefaz.Image")));
            this.picRefaz.Location = new System.Drawing.Point(1300, 609);
            this.picRefaz.Name = "picRefaz";
            this.picRefaz.Size = new System.Drawing.Size(508, 179);
            this.picRefaz.TabIndex = 9;
            this.picRefaz.TabStop = false;
            this.picRefaz.Click += new System.EventHandler(this.picRefaz_Click);*/
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
            this.pictureBox2.Location = new System.Drawing.Point(55, 609);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 97);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.picFinanceira_Click);
            // 
            // picIndustria
            // 
            this.picIndustria.Image = ((System.Drawing.Image)(resources.GetObject("picIndustria.Image")));
            this.picIndustria.Location = new System.Drawing.Point(466, 609);
            this.picIndustria.Name = "picIndustria";
            this.picIndustria.Size = new System.Drawing.Size(345, 97);
            this.picIndustria.TabIndex = 12;
            this.picIndustria.TabStop = false;
            this.picIndustria.Click += new System.EventHandler(this.picIndustria_Click);
            // 
            // picTecnologia
            // 
            this.picTecnologia.Image = ((System.Drawing.Image)(resources.GetObject("picTecnologia.Image")));
            this.picTecnologia.Location = new System.Drawing.Point(848, 609);
            this.picTecnologia.Name = "picTecnologia";
            this.picTecnologia.Size = new System.Drawing.Size(368, 97);
            this.picTecnologia.TabIndex = 13;
            this.picTecnologia.TabStop = false;
            this.picTecnologia.Click += new System.EventHandler(this.picTecnologia_Click);
            // 
            // picFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1820, 846);
            this.Controls.Add(this.picTecnologia);
            this.Controls.Add(this.picIndustria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picrefaz);
            this.Controls.Add(this.picitulo);
            this.Controls.Add(this.lblAvançado);
            this.Controls.Add(this.InvestidorAvancado);
            this.Name = "picFinanceira";
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
        private System.Windows.Forms.Label lblAvançado;
        private System.Windows.Forms.PictureBox picitulo;
        private System.Windows.Forms.PictureBox picrefaz;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picIndustria;
        private System.Windows.Forms.PictureBox picTecnologia;
    }
}