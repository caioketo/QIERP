namespace QIERP
{
    partial class FConsVenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendedorNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.formaPagtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicaoPagtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido,
            this.totalDataGridViewTextBoxColumn,
            this.ClienteNome,
            this.VendedorNome});
            this.dataGridView1.DataSource = this.vendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(865, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Pedido
            // 
            this.Pedido.DataPropertyName = "Pedido";
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "c2";
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ClienteNome
            // 
            this.ClienteNome.DataPropertyName = "ClienteNome";
            this.ClienteNome.HeaderText = "Cliente";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.ReadOnly = true;
            // 
            // VendedorNome
            // 
            this.VendedorNome.DataPropertyName = "VendedorNome";
            this.VendedorNome.HeaderText = "Vendedor";
            this.VendedorNome.Name = "VendedorNome";
            this.VendedorNome.ReadOnly = true;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(QIERPDatabase.Venda);
            this.vendaBindingSource.DataSourceChanged += new System.EventHandler(this.vendaBindingSource_DataSourceChanged);
            this.vendaBindingSource.PositionChanged += new System.EventHandler(this.vendaBindingSource_PositionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.itemBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 229);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(865, 231);
            this.dataGridView2.TabIndex = 1;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle6.Format = "c2";
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn1
            // 
            this.totalDataGridViewTextBoxColumn1.DataPropertyName = "Total";
            dataGridViewCellStyle7.Format = "c2";
            this.totalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.totalDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn1.Name = "totalDataGridViewTextBoxColumn1";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(QIERPDatabase.Item);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formaPagtoDataGridViewTextBoxColumn,
            this.condicaoPagtoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.pagamentoBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 467);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(865, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // formaPagtoDataGridViewTextBoxColumn
            // 
            this.formaPagtoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagto";
            this.formaPagtoDataGridViewTextBoxColumn.HeaderText = "FormaPagto";
            this.formaPagtoDataGridViewTextBoxColumn.Name = "formaPagtoDataGridViewTextBoxColumn";
            this.formaPagtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagtoDataGridViewTextBoxColumn.Width = 200;
            // 
            // condicaoPagtoDataGridViewTextBoxColumn
            // 
            this.condicaoPagtoDataGridViewTextBoxColumn.DataPropertyName = "CondicaoPagto";
            this.condicaoPagtoDataGridViewTextBoxColumn.HeaderText = "CondicaoPagto";
            this.condicaoPagtoDataGridViewTextBoxColumn.Name = "condicaoPagtoDataGridViewTextBoxColumn";
            this.condicaoPagtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.condicaoPagtoDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorDataGridViewTextBoxColumn1
            // 
            this.valorDataGridViewTextBoxColumn1.DataPropertyName = "Valor";
            dataGridViewCellStyle8.Format = "c2";
            this.valorDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.valorDataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn1.Name = "valorDataGridViewTextBoxColumn1";
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataSource = typeof(QIERPDatabase.Pagamento);
            // 
            // FConsVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 673);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FConsVenda";
            this.Text = "FConsVenda";
            this.Load += new System.EventHandler(this.FConsVenda_Load);
            this.Shown += new System.EventHandler(this.FConsVenda_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FConsVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicaoPagtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendedorNome;
    }
}