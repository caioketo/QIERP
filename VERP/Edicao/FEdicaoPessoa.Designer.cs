namespace VERP.Edicao
{
    partial class FEdicaoPessoa
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
            this.cbxCliente = new System.Windows.Forms.CheckBox();
            this.cbxVendedor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDocumento = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNomeFantasia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edcTelefone = new VERP.Utils.cmpEdicao();
            this.edcEndereco = new VERP.Utils.cmpEdicao();
            this.SuspendLayout();
            // 
            // cbxCliente
            // 
            this.cbxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxCliente.AutoSize = true;
            this.cbxCliente.Location = new System.Drawing.Point(12, 274);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(58, 17);
            this.cbxCliente.TabIndex = 1;
            this.cbxCliente.Text = "Cliente";
            this.cbxCliente.UseVisualStyleBackColor = true;
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxVendedor.AutoSize = true;
            this.cbxVendedor.Location = new System.Drawing.Point(99, 274);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(72, 17);
            this.cbxVendedor.TabIndex = 2;
            this.cbxVendedor.Text = "Vendedor";
            this.cbxVendedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Documento";
            // 
            // tbxDocumento
            // 
            this.tbxDocumento.Location = new System.Drawing.Point(16, 30);
            this.tbxDocumento.Name = "tbxDocumento";
            this.tbxDocumento.Size = new System.Drawing.Size(132, 20);
            this.tbxDocumento.TabIndex = 4;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(154, 30);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(232, 20);
            this.tbxNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // tbxNomeFantasia
            // 
            this.tbxNomeFantasia.Location = new System.Drawing.Point(392, 30);
            this.tbxNomeFantasia.Name = "tbxNomeFantasia";
            this.tbxNomeFantasia.Size = new System.Drawing.Size(254, 20);
            this.tbxNomeFantasia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome Fantasia";
            // 
            // edcTelefone
            // 
            this.edcTelefone.estado = VERP.Classes.Estado.Inserir;
            this.edcTelefone.Location = new System.Drawing.Point(16, 56);
            this.edcTelefone.Name = "edcTelefone";
            this.edcTelefone.Objeto = null;
            this.edcTelefone.Repo = null;
            this.edcTelefone.Size = new System.Drawing.Size(254, 183);
            this.edcTelefone.tabela = null;
            this.edcTelefone.TabIndex = 9;
            // 
            // edcEndereco
            // 
            this.edcEndereco.estado = VERP.Classes.Estado.Inserir;
            this.edcEndereco.Location = new System.Drawing.Point(276, 56);
            this.edcEndereco.Name = "edcEndereco";
            this.edcEndereco.Objeto = null;
            this.edcEndereco.Repo = null;
            this.edcEndereco.Size = new System.Drawing.Size(370, 183);
            this.edcEndereco.tabela = null;
            this.edcEndereco.TabIndex = 10;
            // 
            // FEdicaoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(679, 331);
            this.Controls.Add(this.edcEndereco);
            this.Controls.Add(this.edcTelefone);
            this.Controls.Add(this.tbxNomeFantasia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.cbxCliente);
            this.Name = "FEdicaoPessoa";
            this.Shown += new System.EventHandler(this.FEdicaoPessoa_Shown);
            this.Controls.SetChildIndex(this.cbxCliente, 0);
            this.Controls.SetChildIndex(this.cbxVendedor, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxDocumento, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbxNome, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tbxNomeFantasia, 0);
            this.Controls.SetChildIndex(this.edcTelefone, 0);
            this.Controls.SetChildIndex(this.edcEndereco, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxCliente;
        private System.Windows.Forms.CheckBox cbxVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDocumento;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNomeFantasia;
        private System.Windows.Forms.Label label3;
        private Utils.cmpEdicao edcTelefone;
        private Utils.cmpEdicao edcEndereco;

    }
}
