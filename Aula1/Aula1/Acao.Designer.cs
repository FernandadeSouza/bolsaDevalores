
namespace Aula1
{
    partial class frmAcao
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
            this.dGVAcao = new System.Windows.Forms.DataGridView();
            this.btnAcoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAcao)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVAcao
            // 
            this.dGVAcao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAcao.Location = new System.Drawing.Point(32, 38);
            this.dGVAcao.Name = "dGVAcao";
            this.dGVAcao.Size = new System.Drawing.Size(1143, 563);
            this.dGVAcao.TabIndex = 0;
            // 
            // btnAcoes
            // 
            this.btnAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcoes.Location = new System.Drawing.Point(1148, 615);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(124, 35);
            this.btnAcoes.TabIndex = 1;
            this.btnAcoes.Text = "Voltar";
            this.btnAcoes.UseVisualStyleBackColor = true;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // frmAcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1311, 662);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.dGVAcao);
            this.Name = "frmAcao";
            this.Text = "Acao";
            this.Load += new System.EventHandler(this.frmAcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAcao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVAcao;
        private System.Windows.Forms.Button btnAcoes;
    }
}