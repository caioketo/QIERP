namespace QIERP.Edicao
{
    partial class FEdicaoNota
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tbxVenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(15, 24);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(125, 20);
            this.tbxNumero.TabIndex = 1;
            // 
            // tbxVenda
            // 
            this.tbxVenda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxVenda.Location = new System.Drawing.Point(15, 64);
            this.tbxVenda.Name = "tbxVenda";
            this.tbxVenda.ReadOnly = true;
            this.tbxVenda.Size = new System.Drawing.Size(125, 20);
            this.tbxVenda.TabIndex = 2;
            this.tbxVenda.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Venda";
            // 
            // FEdicaoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(280, 150);
            this.Controls.Add(this.tbxVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.label1);
            this.Name = "FEdicaoNota";
            this.Shown += new System.EventHandler(this.FEdicaoNota_Shown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxNumero, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxVenda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TextBox tbxVenda;
        private System.Windows.Forms.Label label2;
    }
}
