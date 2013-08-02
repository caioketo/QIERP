namespace QIERP.CRUD
{
    partial class FCRUDNota
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
            this.btnImpVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tbxPesquisa
            // 
            this.tbxPesquisa.Size = new System.Drawing.Size(469, 31);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(389, 12);
            // 
            // btnImpVenda
            // 
            this.btnImpVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImpVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImpVenda.Location = new System.Drawing.Point(487, 12);
            this.btnImpVenda.Name = "btnImpVenda";
            this.btnImpVenda.Size = new System.Drawing.Size(105, 31);
            this.btnImpVenda.TabIndex = 16;
            this.btnImpVenda.Text = "Imp. Venda";
            this.btnImpVenda.UseVisualStyleBackColor = true;
            this.btnImpVenda.Click += new System.EventHandler(this.btnImpVenda_Click);
            // 
            // FCRUDNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(874, 332);
            this.Controls.Add(this.btnImpVenda);
            this.Name = "FCRUDNota";
            this.Controls.SetChildIndex(this.tbxPesquisa, 0);
            this.Controls.SetChildIndex(this.btnInserir, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnSelecionar, 0);
            this.Controls.SetChildIndex(this.btnImpVenda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImpVenda;
    }
}
