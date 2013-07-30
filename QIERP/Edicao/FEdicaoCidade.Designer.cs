namespace VERP.Edicao
{
    partial class FEdicaoCidade
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
            this.pesEstado = new VERP.Utils.Pesquisa();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(12, 25);
            this.tbxDescricao.MaxLength = 50;
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(343, 20);
            this.tbxDescricao.TabIndex = 2;
            // 
            // pesEstado
            // 
            this.pesEstado.Campo = null;
            this.pesEstado.CampoDisplay = null;
            this.pesEstado.CRUD = null;
            this.pesEstado.Filter = "";
            this.pesEstado.Fonte = null;
            this.pesEstado.Location = new System.Drawing.Point(12, 52);
            this.pesEstado.MinimumSize = new System.Drawing.Size(251, 51);
            this.pesEstado.Name = "pesEstado";
            this.pesEstado.Objeto = null;
            this.pesEstado.Repo = null;
            this.pesEstado.Size = new System.Drawing.Size(343, 51);
            this.pesEstado.TabIndex = 3;
            this.pesEstado.Tamanho = new System.Drawing.Size(0, 0);
            this.pesEstado.Titulo = null;
            // 
            // FEdicaoCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(372, 195);
            this.Controls.Add(this.pesEstado);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FEdicaoCidade";
            this.Load += new System.EventHandler(this.FEdicaoCidade_Load);
            this.Shown += new System.EventHandler(this.FEdicaoCidade_Shown);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxDescricao, 0);
            this.Controls.SetChildIndex(this.pesEstado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescricao;
        private Utils.Pesquisa pesEstado;
    }
}
