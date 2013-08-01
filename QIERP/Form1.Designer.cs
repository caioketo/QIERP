namespace QIERP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condiçõesDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasÀReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasÀPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasFiscaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.clientesVendedoresToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirVendaToolStripMenuItem,
            this.consultaVendaToolStripMenuItem,
            this.notasFiscaisToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // abrirVendaToolStripMenuItem
            // 
            this.abrirVendaToolStripMenuItem.Name = "abrirVendaToolStripMenuItem";
            this.abrirVendaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.abrirVendaToolStripMenuItem.Text = "Abrir Venda";
            this.abrirVendaToolStripMenuItem.Click += new System.EventHandler(this.abrirVendaToolStripMenuItem_Click);
            // 
            // consultaVendaToolStripMenuItem
            // 
            this.consultaVendaToolStripMenuItem.Name = "consultaVendaToolStripMenuItem";
            this.consultaVendaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.consultaVendaToolStripMenuItem.Text = "Consulta Venda";
            this.consultaVendaToolStripMenuItem.Click += new System.EventHandler(this.consultaVendaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formasDePagamentoToolStripMenuItem,
            this.condiçõesDePagamentoToolStripMenuItem});
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "Formas de Pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // condiçõesDePagamentoToolStripMenuItem
            // 
            this.condiçõesDePagamentoToolStripMenuItem.Name = "condiçõesDePagamentoToolStripMenuItem";
            this.condiçõesDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.condiçõesDePagamentoToolStripMenuItem.Text = "Condições de Pagamento";
            this.condiçõesDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.condiçõesDePagamentoToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            this.movimentaçõesToolStripMenuItem.Click += new System.EventHandler(this.movimentaçõesToolStripMenuItem_Click);
            // 
            // clientesVendedoresToolStripMenuItem
            // 
            this.clientesVendedoresToolStripMenuItem.Name = "clientesVendedoresToolStripMenuItem";
            this.clientesVendedoresToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.clientesVendedoresToolStripMenuItem.Text = "Clientes/Vendedores";
            this.clientesVendedoresToolStripMenuItem.Click += new System.EventHandler(this.clientesVendedoresToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasÀReceberToolStripMenuItem,
            this.contasÀPagarToolStripMenuItem,
            this.chequesToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasÀReceberToolStripMenuItem
            // 
            this.contasÀReceberToolStripMenuItem.Name = "contasÀReceberToolStripMenuItem";
            this.contasÀReceberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.contasÀReceberToolStripMenuItem.Text = "Contas à Receber";
            this.contasÀReceberToolStripMenuItem.Click += new System.EventHandler(this.contasÀReceberToolStripMenuItem_Click);
            // 
            // contasÀPagarToolStripMenuItem
            // 
            this.contasÀPagarToolStripMenuItem.Name = "contasÀPagarToolStripMenuItem";
            this.contasÀPagarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.contasÀPagarToolStripMenuItem.Text = "Contas à Pagar";
            this.contasÀPagarToolStripMenuItem.Click += new System.EventHandler(this.contasÀPagarToolStripMenuItem_Click);
            // 
            // chequesToolStripMenuItem
            // 
            this.chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            this.chequesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chequesToolStripMenuItem.Text = "Cheques";
            this.chequesToolStripMenuItem.Click += new System.EventHandler(this.chequesToolStripMenuItem_Click);
            // 
            // notasFiscaisToolStripMenuItem
            // 
            this.notasFiscaisToolStripMenuItem.Name = "notasFiscaisToolStripMenuItem";
            this.notasFiscaisToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.notasFiscaisToolStripMenuItem.Text = "Notas Fiscais";
            this.notasFiscaisToolStripMenuItem.Click += new System.EventHandler(this.notasFiscaisToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 320);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condiçõesDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasÀReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasÀPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasFiscaisToolStripMenuItem;
    }
}

