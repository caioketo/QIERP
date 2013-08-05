namespace QIERP.Edicao
{
    partial class FEdicaoFormaDePagamento
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
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLancaCR = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDescricao.Location = new System.Drawing.Point(15, 26);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(388, 20);
            this.tbxDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // cbxLancaCR
            // 
            this.cbxLancaCR.AutoSize = true;
            this.cbxLancaCR.Location = new System.Drawing.Point(15, 53);
            this.cbxLancaCR.Name = "cbxLancaCR";
            this.cbxLancaCR.Size = new System.Drawing.Size(160, 17);
            this.cbxLancaCR.TabIndex = 2;
            this.cbxLancaCR.Text = "Lança no Contas à Receber";
            this.cbxLancaCR.UseVisualStyleBackColor = true;
            // 
            // FEdicaoFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(415, 189);
            this.Controls.Add(this.cbxLancaCR);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FEdicaoFormaDePagamento";
            this.Load += new System.EventHandler(this.FEdicaoFormaDePagamento_Load);
            this.Shown += new System.EventHandler(this.FEdicaoFormaDePagamento_Shown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxDescricao, 0);
            this.Controls.SetChildIndex(this.cbxLancaCR, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxLancaCR;
    }
}
