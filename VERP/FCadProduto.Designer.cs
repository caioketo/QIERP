namespace VERP
{
    partial class FCadProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(16, 30);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(281, 20);
            this.tbxDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(16, 70);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(82, 20);
            this.tbxCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(138, 70);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(82, 20);
            this.tbxValor.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(2, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 32);
            this.panel1.TabIndex = 6;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(693, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(81, 31);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(611, 0);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 31);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FCadProduto";
            this.Text = "FCadProduto";
            this.Shown += new System.EventHandler(this.FCadProduto_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnGravar;
    }
}