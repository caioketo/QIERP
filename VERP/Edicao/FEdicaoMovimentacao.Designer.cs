﻿namespace VERP.Edicao
{
    partial class FEdicaoMovimentacao
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
            this.gitItens = new VERP.Utils.GridItens();
            this.SuspendLayout();
            // 
            // gitItens
            // 
            this.gitItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitItens.Campos = null;
            this.gitItens.CamposEdicao = null;
            this.gitItens.Location = new System.Drawing.Point(12, 92);
            this.gitItens.Name = "gitItens";
            this.gitItens.Size = new System.Drawing.Size(668, 218);
            this.gitItens.TabIndex = 2;
            // 
            // FEdicaoMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(692, 356);
            this.Controls.Add(this.gitItens);
            this.Name = "FEdicaoMovimentacao";
            this.Load += new System.EventHandler(this.FEdicaoMovimentacao_Load);
            this.Shown += new System.EventHandler(this.FEdicaoMovimentacao_Shown);
            this.Controls.SetChildIndex(this.gitItens, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.GridItens gitItens;
    }
}
