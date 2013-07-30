namespace VERP.Edicao
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
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtEntrada = new System.Windows.Forms.RadioButton();
            this.rbtSaida = new System.Windows.Forms.RadioButton();
            this.pesClienteOuFornecedor = new VERP.Utils.Pesquisa();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gitItens
            // 
            this.gitItens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitItens.Campos = null;
            this.gitItens.CamposEdicao = null;
            this.gitItens.Location = new System.Drawing.Point(12, 144);
            this.gitItens.Name = "gitItens";
            this.gitItens.Size = new System.Drawing.Size(668, 218);
            this.gitItens.TabIndex = 2;
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(15, 26);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(388, 20);
            this.tbxDescricao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtSaida);
            this.groupBox1.Controls.Add(this.rbtEntrada);
            this.groupBox1.Location = new System.Drawing.Point(420, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbtEntrada
            // 
            this.rbtEntrada.AutoSize = true;
            this.rbtEntrada.Checked = true;
            this.rbtEntrada.Location = new System.Drawing.Point(7, 14);
            this.rbtEntrada.Name = "rbtEntrada";
            this.rbtEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbtEntrada.TabIndex = 0;
            this.rbtEntrada.TabStop = true;
            this.rbtEntrada.Text = "Entrada";
            this.rbtEntrada.UseVisualStyleBackColor = true;
            // 
            // rbtSaida
            // 
            this.rbtSaida.AutoSize = true;
            this.rbtSaida.Location = new System.Drawing.Point(84, 14);
            this.rbtSaida.Name = "rbtSaida";
            this.rbtSaida.Size = new System.Drawing.Size(54, 17);
            this.rbtSaida.TabIndex = 1;
            this.rbtSaida.TabStop = true;
            this.rbtSaida.Text = "Saída";
            this.rbtSaida.UseVisualStyleBackColor = true;
            // 
            // pesClienteOuFornecedor
            // 
            this.pesClienteOuFornecedor.Campo = null;
            this.pesClienteOuFornecedor.CampoDisplay = null;
            this.pesClienteOuFornecedor.CRUD = null;
            this.pesClienteOuFornecedor.Filter = "";
            this.pesClienteOuFornecedor.Fonte = null;
            this.pesClienteOuFornecedor.Location = new System.Drawing.Point(15, 63);
            this.pesClienteOuFornecedor.MinimumSize = new System.Drawing.Size(251, 51);
            this.pesClienteOuFornecedor.Name = "pesClienteOuFornecedor";
            this.pesClienteOuFornecedor.Objeto = null;
            this.pesClienteOuFornecedor.Repo = null;
            this.pesClienteOuFornecedor.Size = new System.Drawing.Size(549, 51);
            this.pesClienteOuFornecedor.TabIndex = 8;
            this.pesClienteOuFornecedor.Tamanho = new System.Drawing.Size(0, 0);
            this.pesClienteOuFornecedor.Titulo = null;
            // 
            // FEdicaoMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(692, 402);
            this.Controls.Add(this.pesClienteOuFornecedor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gitItens);
            this.Name = "FEdicaoMovimentacao";
            this.Load += new System.EventHandler(this.FEdicaoMovimentacao_Load);
            this.Shown += new System.EventHandler(this.FEdicaoMovimentacao_Shown);
            this.Controls.SetChildIndex(this.gitItens, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxDescricao, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pesClienteOuFornecedor, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.GridItens gitItens;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtEntrada;
        private System.Windows.Forms.RadioButton rbtSaida;
        private Utils.Pesquisa pesClienteOuFornecedor;
    }
}
