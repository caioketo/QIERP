namespace VERP
{
    partial class FEdicaoProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDescricao.Location = new System.Drawing.Point(16, 64);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(439, 20);
            this.tbxDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCodigo.Location = new System.Drawing.Point(16, 25);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(142, 20);
            this.tbxCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxQuantidade.Location = new System.Drawing.Point(16, 103);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(70, 20);
            this.tbxQuantidade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Custo";
            // 
            // tbxCusto
            // 
            this.tbxCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCusto.Location = new System.Drawing.Point(92, 103);
            this.tbxCusto.Name = "tbxCusto";
            this.tbxCusto.Size = new System.Drawing.Size(70, 20);
            this.tbxCusto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor de Venda";
            // 
            // tbxValor
            // 
            this.tbxValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxValor.Location = new System.Drawing.Point(168, 103);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(70, 20);
            this.tbxValor.TabIndex = 9;
            // 
            // FEdicaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(485, 205);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCusto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDescricao);
            this.Name = "FEdicaoProduto";
            this.Load += new System.EventHandler(this.FEdicaoProduto_Load);
            this.Shown += new System.EventHandler(this.FEdicaoProduto_Shown);
            this.Controls.SetChildIndex(this.tbxDescricao, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxCodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxQuantidade, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxCusto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.tbxValor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxValor;
    }
}
