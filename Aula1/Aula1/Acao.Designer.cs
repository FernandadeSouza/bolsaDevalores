﻿
namespace Aula1
{
    partial class Acao
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
            ((System.ComponentModel.ISupportInitialize)(this.dGVAcao)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVAcao
            // 
            this.dGVAcao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAcao.Location = new System.Drawing.Point(12, 12);
            this.dGVAcao.Name = "dGVAcao";
            this.dGVAcao.Size = new System.Drawing.Size(766, 411);
            this.dGVAcao.TabIndex = 0;
            // 
            // Acao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVAcao);
            this.Name = "Acao";
            this.Text = "Acao";
            ((System.ComponentModel.ISupportInitialize)(this.dGVAcao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVAcao;
    }
}