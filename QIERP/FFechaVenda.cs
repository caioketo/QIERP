using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERPDatabase;
using QIERP.Utils;
using QIERP.CRUD;
using QIERPDatabase.Classes;
using VERPDatabase.Classes;

namespace QIERP
{

    public partial class FFechaVenda : BaseForm
    {
        public bool Orcamento;
        public BaseVenda VendaOrcAtual;
        public FormaDePagamento FP = null;
        public FVenda fVenda;

        public FFechaVenda()
        {
            InitializeComponent();
        }

        private void FFechaVenda_Shown(object sender, EventArgs e)
        {
            VendaOrcAtual.Cliente = new Cliente();
            VendaOrcAtual.Vendedor = new Vendedor();
            pesCliente.CRUD = new FCRUDPessoa();
            pesCliente.Campo = "Nome";
            pesCliente.CampoDisplay = "Nome";
            pesCliente.Titulo = "Cliente";
            pesCliente.Repo = DB.GetInstance().PessoaRepo;
            pesCliente.Filter = "Clientes";
            pesCliente.onLoad();
            pesVendedor.CRUD = new FCRUDPessoa();
            pesVendedor.Campo = "Nome";
            pesVendedor.CampoDisplay = "Nome";
            pesVendedor.Titulo = "Vendedor";
            pesVendedor.Repo = DB.GetInstance().PessoaRepo;
            pesVendedor.onLoad();

            if (!Orcamento)
            {
                CalculaPagto();
                pagamentoBindingSource.DataSource = ((Venda)VendaOrcAtual).Pagamentos;
                formaDePagamentoBindingSource.DataSource = DB.GetInstance().FPRepo.GetAll();
                if (FP != null)
                {
                    cmbForma.SelectedItem = FP;
                    cmbCondicao.Focus();
                }
                AtualizaCondicoes();
            }
            else
            {
                cmbCondicao.Visible = false;
                cmbForma.Visible = false;
                tbxValor.Visible = false;
                dataGridView1.Visible = false;
                button1.Visible = false;
                pesCliente.Location = new Point(74, 187);
                pesVendedor.Location = new Point(74, 249);
                btnFinalizaVenda.Location = new Point(74, 313);
                rtbTotal.Clear();
                rtbTotal.AppendText("Total Orçamento: " + VendaOrcAtual.Total.ToString("C2") + Environment.NewLine, Color.Black);
            }
        }

        public void AtualizaCondicoes()
        {
            try
            {
                FormaDePagamento fp = (FormaDePagamento)cmbForma.SelectedItem;
                if (fp != null)
                {
                    condicaoDePagamentoBindingSource.DataSource = DB.GetInstance().CondicaoRepo.GetAll().Where(c => c.Forma.Id == fp.Id).ToList();
                }
            }
            catch
            {
                return;
            }
        }

        private void CalculaPagto()
        {
            rtbTotal.Clear();
            rtbTotal.AppendText("Total Venda: " + ((Venda)VendaOrcAtual).Total.ToString("C2") + Environment.NewLine, Color.Black);
            rtbTotal.AppendText("Total Pago: " + ((Venda)VendaOrcAtual).TotalPagto.ToString("C2") + Environment.NewLine, Color.Black);
            if (((Venda)VendaOrcAtual).Troco > 0)
            {
                rtbTotal.AppendText("Troco: " + ((Venda)VendaOrcAtual).Troco.ToString("C2"), Color.Black);
            }
            else if (((Venda)VendaOrcAtual).Troco < 0)
            {
                rtbTotal.AppendText("Falta: " + (((Venda)VendaOrcAtual).Troco * -1).ToString("C2"), Color.Red);
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
            if (!Orcamento)
            {
                if (((Venda)VendaOrcAtual).Troco < 0)
                {
                    return;
                }
            }

            if (pesCliente.Objeto == null)
            {
                return;
            }

            if (pesVendedor.Objeto == null)
            {
                return;
            }

            VendaOrcAtual.Cliente = DB.GetInstance().ClienteRepo.GetByPessoa((Pessoa)pesCliente.Objeto);
            VendaOrcAtual.Vendedor = DB.GetInstance().VendedorRepo.GetByPessoa((Pessoa)pesVendedor.Objeto);

            if (!Orcamento)
            {
                if (!DB.GetInstance().VendaRepo.Inserir(((Venda)VendaOrcAtual)))
                {
                    return;
                }
            }
            else
            {
                if (!DB.GetInstance().OrcamentoRepo.Inserir(((Orcamento)VendaOrcAtual)))
                {
                    return;
                }
            }
            fVenda.VendaOrcAtual = null;
            Mensagem.MostrarMsg(10000);
            this.Close();
        }

        private void FFechaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
                Mensagem.MostrarMsg(40003);
                tbxValor.Focus();
                return;
            }

            FormaDePagamento fp = DB.GetInstance().FPRepo.GetById((int)cmbForma.SelectedValue);

            if (fp == null)
            {
                Mensagem.MostrarMsg(40000, "Forma de Pagamento");
                cmbForma.Focus();
                return;
            }

            CondicaoDePagamento cp = DB.GetInstance().CondicaoRepo.GetById((int)cmbCondicao.SelectedValue);

            if (cp == null)
            {
                Mensagem.MostrarMsg(40000, "Condição de Pagamento");
                cmbCondicao.Focus();
                return;
            }

            Pagamento pagto = new Pagamento();
            pagto.Condicao = cp;
            pagto.Forma = fp;
            pagto.Valor = valor;

            ((Venda)VendaOrcAtual).Pagamentos.Add(pagto);
            CalculaPagto();
        }

        private void cmbForma_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizaCondicoes();
        }

        private void tbxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(','))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
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
