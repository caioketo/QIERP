namespace VERP.Utils
{
    partial class Pesquisa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxPesquisa = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxPesquisa
            // 
            this.tbxPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPesquisa.Location = new System.Drawing.Point(3, 20);
            this.tbxPesquisa.Name = "tbxPesquisa";
            this.tbxPesquisa.Size = new System.Drawing.Size(245, 20);
            this.tbxPesquisa.TabIndex = 0;
            this.tbxPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPesquisa_KeyDown);
            this.tbxPesquisa.Leave += new System.EventHandler(this.tbxPesquisa_Leave);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(4, 6);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(35, 13);
            this.lblCampo.TabIndex = 1;
            this.lblCampo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "<ENTER> Para pesquisar";
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.tbxPesquisa);
            this.MinimumSize = new System.Drawing.Size(251, 51);
            this.Name = "Pesquisa";
            this.Size = new System.Drawing.Size(251, 51);
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPesquisa;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label label1;
    }
}
