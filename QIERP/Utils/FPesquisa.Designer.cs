namespace QIERP.Utils
{
    partial class FPesquisa
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
            this.pesquisa1 = new QIERP.Utils.Pesquisa();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisa1
            // 
            this.pesquisa1.Campo = null;
            this.pesquisa1.CampoDisplay = null;
            this.pesquisa1.CRUD = null;
            this.pesquisa1.Filter = "";
            this.pesquisa1.Fonte = null;
            this.pesquisa1.Location = new System.Drawing.Point(9, 6);
            this.pesquisa1.MinimumSize = new System.Drawing.Size(251, 51);
            this.pesquisa1.Name = "pesquisa1";
            this.pesquisa1.Objeto = null;
            this.pesquisa1.Repo = null;
            this.pesquisa1.Size = new System.Drawing.Size(452, 51);
            this.pesquisa1.TabIndex = 0;
            this.pesquisa1.Tamanho = new System.Drawing.Size(0, 0);
            this.pesquisa1.Titulo = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 34);
            this.panel1.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelecionar.Location = new System.Drawing.Point(299, 0);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(84, 32);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.Location = new System.Drawing.Point(383, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 32);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(469, 117);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pesquisa1);
            this.Name = "FPesquisa";
            this.Text = "Selecionar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QIERP.Utils.Pesquisa pesquisa1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnFechar;
    }
}
