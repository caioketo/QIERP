using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace VERP
{

    public partial class FFechaVenda : Form
    {
        public Venda VendaAtual;
        public FVenda fVenda;

        public FFechaVenda()
        {
            InitializeComponent();
        }

        private void FFechaVenda_Shown(object sender, EventArgs e)
        {
            CalculaPagto();
            pagamentoBindingSource.DataSource = VendaAtual.Pagamentos;
            formaDePagamentoBindingSource.DataSource = DB.FPRepo.GetAll();
            condicaoDePagamentoBindingSource.DataSource = DB.CPRepo.GetAll();
        }

        private void CalculaPagto()
        {
            rtbTotal.Clear();
            rtbTotal.AppendText("Total Venda: " + VendaAtual.Total.ToString("C2") + Environment.NewLine, Color.Black);
            rtbTotal.AppendText("Total Pago: " + VendaAtual.TotalPagto.ToString("C2") + Environment.NewLine, Color.Black);
            if (VendaAtual.Troco > 0)
            {
                rtbTotal.AppendText("Troco: " + VendaAtual.Troco.ToString("C2"), Color.Black);
            }
            else if (VendaAtual.Troco < 0)
            {
                rtbTotal.AppendText("Falta: " + (VendaAtual.Troco * -1).ToString("C2"), Color.Red);
            }
        }

        private string VerifyNumeric(string text)
        {
            double value = 0;
            double.TryParse(text, out value);
            return value.ToString("C2"); 
        }

        private void btnFinalizaVenda_Click(object sender, EventArgs e)
        {
            if (VendaAtual.Troco < 0)
            {
                return;
            }

            if (!DB.VendaRepo.Inserir(VendaAtual))
            {
                MessageBox.Show(DB.Error);
            }
            else
            {
                fVenda.VendaAtual = null;
                MessageBox.Show("Venda Concluída!");
                this.Close();
            }
        }

        private void FFechaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = 0;
            if (tbxValor.Text.Trim() == "")
            {
                tbxValor.Text = "0";
            }

            if (tbxValor.Text.Contains("R$"))
            {
                valor = Double.Parse(tbxValor.Text.Substring(2));
                tbxValor.Text = VerifyNumeric(tbxValor.Text.Substring(2));
            }
            else
            {
                valor = Double.Parse(tbxValor.Text);
                tbxValor.Text = VerifyNumeric(tbxValor.Text);
            }

            if (valor <= 0)
            {
                MessageBox.Show("Valor deve ser superior à 0!");
                tbxValor.Focus();
                return;
            }

            FormaDePagamento fp = DB.FPRepo.GetById((int)cmbForma.SelectedValue);

            if (fp == null)
            {
                MessageBox.Show("Favor selecionar uma forma de pagamento válida!");
                cmbForma.Focus();
                return;
            }

            CondicaoDePagamento cp = DB.CPRepo.GetById((int)cmbCondicao.SelectedValue);

            if (cp == null)
            {
                MessageBox.Show("Favor selecionar uma condição de pagamento válida!");
                cmbCondicao.Focus();
                return;
            }

            Pagamento pagto = new Pagamento();
            pagto.Condicao = cp;
            pagto.Forma = fp;
            pagto.Valor = valor;

            VendaAtual.Pagamentos.Add(pagto);
            CalculaPagto();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
