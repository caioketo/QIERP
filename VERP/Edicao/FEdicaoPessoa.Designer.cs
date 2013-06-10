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
            this.SuspendLayout();
            // 
            // cbxCliente
            // 
            this.cbxCliente.AutoSize = true;
            this.cbxCliente.Location = new System.Drawing.Point(12, 459);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(58, 17);
            this.cbxCliente.TabIndex = 1;
            this.cbxCliente.Text = "Cliente";
            this.cbxCliente.UseVisualStyleBackColor = true;
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.AutoSize = true;
            this.cbxVendedor.Location = new System.Drawing.Point(99, 459);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(72, 17);
            this.cbxVendedor.TabIndex = 2;
            this.cbxVendedor.Text = "Vendedor";
            this.cbxVendedor.UseVisualStyleBackColor = true;
            // 
            // FEdicaoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(927, 516);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.cbxCliente);
            this.Name = "FEdicaoPessoa";
            this.Shown += new System.EventHandler(this.FEdicaoPessoa_Shown);
            this.Controls.SetChildIndex(this.cbxCliente, 0);
            this.Controls.SetChildIndex(this.cbxVendedor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxCliente;
        private System.Windows.Forms.CheckBox cbxVendedor;

    }
}
