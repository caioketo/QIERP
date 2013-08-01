namespace QIERP.Edicao
{
    partial class FEdicaoCondicaoDePagamento
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
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.pesFormaDePagamento = new QIERP.Utils.Pesquisa();
            this.tbxDiasVencimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(16, 30);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(251, 20);
            this.tbxDescricao.TabIndex = 2;
            // 
            // pesFormaDePagamento
            // 
            this.pesFormaDePagamento.Campo = null;
            this.pesFormaDePagamento.CampoDisplay = null;
            this.pesFormaDePagamento.CRUD = null;
            this.pesFormaDePagamento.Filter = "";
            this.pesFormaDePagamento.Fonte = null;
            this.pesFormaDePagamento.Location = new System.Drawing.Point(16, 57);
            this.pesFormaDePagamento.MinimumSize = new System.Drawing.Size(251, 51);
            this.pesFormaDePagamento.Name = "pesFormaDePagamento";
            this.pesFormaDePagamento.Objeto = null;
            this.pesFormaDePagamento.Repo = null;
            this.pesFormaDePagamento.Size = new System.Drawing.Size(316, 51);
            this.pesFormaDePagamento.TabIndex = 3;
            this.pesFormaDePagamento.Tamanho = new System.Drawing.Size(0, 0);
            this.pesFormaDePagamento.Titulo = null;
            // 
            // tbxDiasVencimento
            // 
            this.tbxDiasVencimento.Location = new System.Drawing.Point(273, 30);
            this.tbxDiasVencimento.Name = "tbxDiasVencimento";
            this.tbxDiasVencimento.Size = new System.Drawing.Size(59, 20);
            this.tbxDiasVencimento.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dias p/ Vencimento";
            // 
            // FEdicaoCondicaoDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(564, 284);
            this.Controls.Add(this.tbxDiasVencimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pesFormaDePagamento);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FEdicaoCondicaoDePagamento";
            this.Load += new System.EventHandler(this.FEdicaoCondicaoDePagamento_Load);
            this.Shown += new System.EventHandler(this.FEdicaoCondicaoDePagamento_Shown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxDescricao, 0);
            this.Controls.SetChildIndex(this.pesFormaDePagamento, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxDiasVencimento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescricao;
        private Utils.Pesquisa pesFormaDePagamento;
        private System.Windows.Forms.TextBox tbxDiasVencimento;
        private System.Windows.Forms.Label label2;
    }
}
