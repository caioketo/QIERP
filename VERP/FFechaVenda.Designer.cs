namespace VERP
{
    partial class FFechaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.btnFinalizaVenda = new System.Windows.Forms.Button();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.formaDePagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCondicao = new System.Windows.Forms.ComboBox();
            this.condicaoDePagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicaoPagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.formaDePagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoDePagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbTotal
            // 
            this.rtbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTotal.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTotal.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtbTotal.Location = new System.Drawing.Point(12, 12);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.ReadOnly = true;
            this.rtbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbTotal.Size = new System.Drawing.Size(791, 158);
            this.rtbTotal.TabIndex = 8;
            this.rtbTotal.TabStop = false;
            this.rtbTotal.Text = "Total Venda: R$ 50,00\nTotal Pago: R$ 70,00\nTroco: R$ 20,00";
            // 
            // btnFinalizaVenda
            // 
            this.btnFinalizaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizaVenda.Location = new System.Drawing.Point(12, 421);
            this.btnFinalizaVenda.Name = "btnFinalizaVenda";
            this.btnFinalizaVenda.Size = new System.Drawing.Size(791, 44);
            this.btnFinalizaVenda.TabIndex = 9;
            this.btnFinalizaVenda.Text = "Finalizar Venda";
            this.btnFinalizaVenda.UseVisualStyleBackColor = true;
            this.btnFinalizaVenda.Click += new System.EventHandler(this.btnFinalizaVenda_Click);
            // 
            // cmbForma
            // 
            this.cmbForma.DataSource = this.formaDePagamentoBindingSource;
            this.cmbForma.DisplayMember = "Descricao";
            this.cmbForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Location = new System.Drawing.Point(12, 176);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(272, 37);
            this.cmbForma.TabIndex = 0;
            this.cmbForma.ValueMember = "Id";
            // 
            // formaDePagamentoBindingSource
            // 
            this.formaDePagamentoBindingSource.DataSource = typeof(Database.FormaDePagamento);
            // 
            // cmbCondicao
            // 
            this.cmbCondicao.DataSource = this.condicaoDePagamentoBindingSource;
            this.cmbCondicao.DisplayMember = "Descricao";
            this.cmbCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cmbCondicao.FormattingEnabled = true;
            this.cmbCondicao.Location = new System.Drawing.Point(290, 176);
            this.cmbCondicao.Name = "cmbCondicao";
            this.cmbCondicao.Size = new System.Drawing.Size(247, 37);
            this.cmbCondicao.TabIndex = 1;
            this.cmbCondicao.ValueMember = "Id";
            // 
            // condicaoDePagamentoBindingSource
            // 
            this.condicaoDePagamentoBindingSource.DataSource = typeof(Database.CondicaoDePagamento);
            // 
            // tbxValor
            // 
            this.tbxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValor.Location = new System.Drawing.Point(543, 176);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(210, 35);
            this.tbxValor.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Forma,
            this.CondicaoPagto,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pagamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(790, 184);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.TabStop = false;
            // 
            // Forma
            // 
            this.Forma.DataPropertyName = "FormaPagto";
            this.Forma.HeaderText = "Forma de Pagamento";
            this.Forma.Name = "Forma";
            this.Forma.ReadOnly = true;
            this.Forma.Width = 300;
            // 
            // CondicaoPagto
            // 
            this.CondicaoPagto.DataPropertyName = "CondicaoPagto";
            this.CondicaoPagto.HeaderText = "Condição de Pagamento";
            this.CondicaoPagto.Name = "CondicaoPagto";
            this.CondicaoPagto.ReadOnly = true;
            this.CondicaoPagto.Width = 300;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "c";
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataSource = typeof(Database.Pagamento);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(760, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Forma";
            this.dataGridViewTextBoxColumn1.HeaderText = "Forma de Pagamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FFechaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.cmbCondicao);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.btnFinalizaVenda);
            this.Controls.Add(this.rtbTotal);
            this.KeyPreview = true;
            this.Name = "FFechaVenda";
            this.Text = "FFechaVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FFechaVenda_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FFechaVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.formaDePagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condicaoDePagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.Button btnFinalizaVenda;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbCondicao;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource formaDePagamentoBindingSource;
        private System.Windows.Forms.BindingSource condicaoDePagamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicaoPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}