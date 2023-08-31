
namespace Aula1
{
    partial class Bcadastro
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
            this.dGVCadastro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVCadastro
            // 
            this.dGVCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCadastro.Location = new System.Drawing.Point(12, 26);
            this.dGVCadastro.Name = "dGVCadastro";
            this.dGVCadastro.Size = new System.Drawing.Size(757, 392);
            this.dGVCadastro.TabIndex = 0;
            // 
            // Bcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVCadastro);
            this.Name = "Bcadastro";
            this.Text = "Bcadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dGVCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVCadastro;
    }
}