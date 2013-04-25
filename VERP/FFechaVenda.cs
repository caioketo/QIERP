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
            Pagamento pag = new Pagamento();
            pag.Valor = 100;
            pag.Forma = new FormaDePagamento();
            pag.Forma.Descricao = "Teste";
            VendaAtual.Pagamentos.Add(pag);
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbxDinheiro.Text.Trim() == "")
            {
                tbxDinheiro.Text = "0";
            }
            
            if (tbxDinheiro.Text.Contains("R$"))
            {
                VendaAtual.PagtoDin = Double.Parse(tbxDinheiro.Text.Substring(2));
                tbxDinheiro.Text = VerifyNumeric(tbxDinheiro.Text.Substring(2));
            }
            else
            {
                VendaAtual.PagtoDin = Double.Parse(tbxDinheiro.Text);
                tbxDinheiro.Text = VerifyNumeric(tbxDinheiro.Text);
            }
            
            CalculaPagto();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tbxCredito.Text.Trim() == "")
            {
                tbxCredito.Text = "0";
            }
            if (tbxCredito.Text.Contains("R$"))
            {
                VendaAtual.PagtoCred = Double.Parse(tbxCredito.Text.Substring(2));
                tbxCredito.Text = VerifyNumeric(tbxCredito.Text.Substring(2));
            }
            else
            {
                VendaAtual.PagtoCred = Double.Parse(tbxCredito.Text);
                tbxCredito.Text = VerifyNumeric(tbxCredito.Text);
            }
            CalculaPagto();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (tbxDebito.Text.Trim() == "")
            {
                tbxDebito.Text = "0";
            }
            if (tbxDebito.Text.Contains("R$"))
            {
                VendaAtual.PagtoDeb = Double.Parse(tbxDebito.Text.Substring(2));
                tbxDebito.Text = VerifyNumeric(tbxDebito.Text.Substring(2));
            }
            else
            {
                VendaAtual.PagtoDeb = Double.Parse(tbxDebito.Text);
                tbxDebito.Text = VerifyNumeric(tbxDebito.Text);
            }
            CalculaPagto();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (tbxCheque.Text.Trim() == "")
            {
                tbxCheque.Text = "0";
            }
            if (tbxCheque.Text.Contains("R$"))
            {
                VendaAtual.PagtoCheq = Double.Parse(tbxCheque.Text.Substring(2));
                tbxCheque.Text = VerifyNumeric(tbxCheque.Text.Substring(2));
            }
            else
            {
                VendaAtual.PagtoCheq = Double.Parse(tbxCheque.Text);
                tbxCheque.Text = VerifyNumeric(tbxCheque.Text);
            }
            CalculaPagto();
        }

        private void btnFinalizaVenda_Click(object sender, EventArgs e)
        {
            if (VendaAtual.Troco < 0)
            {
                return;
            }

            if (!DB.VendaRepo.Salvar(VendaAtual))
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
