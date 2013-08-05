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

namespace QIERP
{
    public partial class FVenda : BaseForm
    {
        private Produto produtoAchado;
        public Venda VendaAtual;

        public FVenda()
        {
            InitializeComponent();
        }

        public void AddItem(Item item)
        {
            if (VendaAtual == null)
            {
                VendaAtual = new Venda();
                itemBindingSource.DataSource = VendaAtual.Itens;
            }
            VendaAtual.Itens.Add(item);
            produtoAchado.Quantidade -= item.Quantidade;
            rtbTotal.Text = "Total: " + VendaAtual.Total.ToString("C2") + Environment.NewLine 
                + "Total Itens: " + VendaAtual.Itens.Count.ToString();
        }


        private void Venda_Shown(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = null;
            rtbTotal.Text = "CAIXA ABERTO" + Environment.NewLine + "PASSE O ITEM";
        }

        public void textBox2_Leave(object sender, EventArgs e)
        {
            Produto prod = DB.GetInstance().ProdutoRepo.GetAll().Where(p => p.Codigo == tbxProduto.Text).FirstOrDefault();
            if (prod != null)
            {
                produtoAchado = prod;
            }
            else
            {
                using (FCRUDProduto crud = new FCRUDProduto())
                {
                    crud.TextoInicial = tbxProduto.Text;
                    object resultado = crud.Selecionar();
                    if (resultado != null)
                    {
                        prod = (Produto)resultado;
                        produtoAchado = prod;
                        tbxProduto.Text = produtoAchado.Codigo;
                        tbxQtde.Focus();
                    }
                    else
                    {
                        tbxProduto.Focus();
                    }
                }
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (tbxQtde.Text.Equals(""))
            {
                tbxProduto.Focus();
                return;
            }
            try
            {
                Convert.ToDouble(tbxQtde.Text);
            }
            catch (Exception)
            {
                Mensagem.MostrarMsg(40004);
                tbxQtde.Focus();
                return;
            }

            AddItem(new Item(produtoAchado, Convert.ToDouble(tbxQtde.Text)));
            tbxProduto.Clear();
            tbxQtde.Clear();
        }

        private void FecharVenda(FormaDePagamento fp)
        {
            if (VendaAtual.Itens.Count == 0)
            {
                return;
            }
            using (FFechaVenda fechaVenda = new FFechaVenda())
            {
                fechaVenda.FP = fp;
                fechaVenda.fVenda = this;
                fechaVenda.VendaAtual = this.VendaAtual;
                fechaVenda.ShowDialog();

                if (VendaAtual == null)
                {
                    itemBindingSource.DataSource = null;
                    rtbTotal.Text = "CAIXA ABERTO" + Environment.NewLine + "PASSE O ITEM";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FecharVenda(null);
        }

        private void FVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (VendaAtual != null)
                {
                    if (Mensagem.MostrarMsg(30001) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }
                }
                this.Close();
            }

            if (Util.GetFP(e.KeyCode) != null)
            {
                FecharVenda(Util.GetFP(e.KeyCode));
            }
        }

        private void tbxQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(','))
            {
                e.Handled = true;
            }

        }
    }
}
