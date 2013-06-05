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
            this.edcTelefone = new VERP.Utils.cmpEdicao();
            this.SuspendLayout();
            // 
            // edcTelefone
            // 
            this.edcTelefone.estado = VERP.Classes.Estado.Inserir;
            this.edcTelefone.Location = new System.Drawing.Point(12, 330);
            this.edcTelefone.Name = "edcTelefone";
            this.edcTelefone.Objeto = null;
            this.edcTelefone.Repo = null;
            this.edcTelefone.Size = new System.Drawing.Size(46, 50);
            this.edcTelefone.tabela = null;
            this.edcTelefone.TabIndex = 1;
            // 
            // FEdicaoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(927, 516);
            this.Controls.Add(this.edcTelefone);
            this.Name = "FEdicaoPessoa";
            this.Shown += new System.EventHandler(this.FEdicaoPessoa_Shown);
            this.Controls.SetChildIndex(this.edcTelefone, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.cmpEdicao edcTelefone;
    }
}
