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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDinheiro = new System.Windows.Forms.TextBox();
            this.tbxCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDebito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCheque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.btnFinalizaVenda = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinheiro";
            // 
            // tbxDinheiro
            // 
            this.tbxDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDinheiro.Location = new System.Drawing.Point(672, 491);
            this.tbxDinheiro.Name = "tbxDinheiro";
            this.tbxDinheiro.Size = new System.Drawing.Size(131, 35);
            this.tbxDinheiro.TabIndex = 1;
            this.tbxDinheiro.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tbxCredito
            // 
            this.tbxCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCredito.Location = new System.Drawing.Point(672, 532);
            this.tbxCredito.Name = "tbxCredito";
            this.tbxCredito.Size = new System.Drawing.Size(131, 35);
            this.tbxCredito.TabIndex = 3;
            this.tbxCredito.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crédito";
            // 
            // tbxDebito
            // 
            this.tbxDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDebito.Location = new System.Drawing.Point(672, 573);
            this.tbxDebito.Name = "tbxDebito";
            this.tbxDebito.Size = new System.Drawing.Size(131, 35);
            this.tbxDebito.TabIndex = 5;
            this.tbxDebito.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Débito";
            // 
            // tbxCheque
            // 
            this.tbxCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCheque.Location = new System.Drawing.Point(672, 614);
            this.tbxCheque.Name = "tbxCheque";
            this.tbxCheque.Size = new System.Drawing.Size(131, 35);
            this.tbxCheque.TabIndex = 7;
            this.tbxCheque.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cheque";
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 37);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(290, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 37);
            this.comboBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(543, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 35);
            this.textBox1.TabIndex = 12;
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
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pagamentoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(790, 184);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(760, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 35);
            this.button1.TabIndex = 14;
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
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataSource = typeof(Database.Pagamento);
            // 
            // Forma
            // 
            this.Forma.DataPropertyName = "FormaPagto";
            this.Forma.HeaderText = "Forma de Pagamento";
            this.Forma.Name = "Forma";
            this.Forma.ReadOnly = true;
            this.Forma.Width = 300;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FFechaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFinalizaVenda);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.tbxCheque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxDebito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCredito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDinheiro);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FFechaVenda";
            this.Text = "FFechaVenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FFechaVenda_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FFechaVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDinheiro;
        private System.Windows.Forms.TextBox tbxCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDebito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCheque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.Button btnFinalizaVenda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}