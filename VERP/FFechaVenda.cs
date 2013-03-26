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

        public FFechaVenda()
        {
            InitializeComponent();
        }

        private void FFechaVenda_Load(object sender, EventArgs e)
        {
            
        }

        private void FFechaVenda_Shown(object sender, EventArgs e)
        {
            CalculaPagto();
        }

        private void CalculaPagto()
        {
            double pagto = 0;
            if (tbxDinheiro.Text.Trim() != "")
            {
                pagto += Double.Parse(tbxDinheiro.Text.Substring(2));
            }
            if (tbxCredito.Text.Trim() != "")
            {
                pagto += Double.Parse(tbxCredito.Text.Substring(2));
            }
            if (tbxDebito.Text.Trim() != "")
            {
                pagto += Double.Parse(tbxDebito.Text.Substring(2));
            }
            if (tbxCheque.Text.Trim() != "")
            {
                pagto += Double.Parse(tbxCheque.Text.Substring(2));
            }


            rtbTotal.Clear();
            rtbTotal.AppendText("Total Venda: " + VendaAtual.Total.ToString("C2") + Environment.NewLine, Color.Black);
            rtbTotal.AppendText("Total Pago: " + pagto.ToString("C2") + Environment.NewLine, Color.Black);
            if (pagto > VendaAtual.Total)
            {
                rtbTotal.AppendText("Troco: " + ((Double)(pagto - VendaAtual.Total)).ToString("C2"), Color.Red);
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
            if (tbxDinheiro.Text.Contains("R$"))
            {
                tbxDinheiro.Text = VerifyNumeric(tbxDinheiro.Text.Substring(2));
            }
            else
            {
                tbxDinheiro.Text = VerifyNumeric(tbxDinheiro.Text);
            }
            CalculaPagto();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (tbxCredito.Text.Contains("R$"))
            {
                tbxCredito.Text = VerifyNumeric(tbxCredito.Text.Substring(2));
            }
            else
            {
                tbxCredito.Text = VerifyNumeric(tbxCredito.Text);
            }
            CalculaPagto();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (tbxDebito.Text.Contains("R$"))
            {
                tbxDebito.Text = VerifyNumeric(tbxDebito.Text.Substring(2));
            }
            else
            {
                tbxDebito.Text = VerifyNumeric(tbxDebito.Text);
            }
            CalculaPagto();
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (tbxCheque.Text.Contains("R$"))
            {
                tbxCheque.Text = VerifyNumeric(tbxCheque.Text.Substring(2));
            }
            else
            {
                tbxCheque.Text = VerifyNumeric(tbxCheque.Text);
            }
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
