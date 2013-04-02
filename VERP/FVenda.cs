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
    public partial class FVenda : Form
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
            rtbTotal.Text = "Total: " + VendaAtual.Total.ToString("C2") + Environment.NewLine 
                + "Total Itens: " + VendaAtual.Itens.Count.ToString();
        }


        private void Venda_Shown(object sender, EventArgs e)
        {
            itemBindingSource.DataSource = null;
            rtbTotal.Text = "CAIXA ABERTO" + Environment.NewLine + "PASSE O ITEM";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            Produto prod = DB.FindProduto(tbxProduto.Text);
            if (prod != null)
            {
                produtoAchado = prod;
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
                tbxProduto.Focus();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbxQtde.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Quantidade inválida!");
                tbxQtde.Focus();
            }

            AddItem(new Item(produtoAchado, Convert.ToDouble(tbxQtde.Text)));
            tbxProduto.Clear();
            tbxQtde.Clear();
        }

        private void FecharVenda()
        {
            using (FFechaVenda fechaVenda = new FFechaVenda())
            {
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
            FecharVenda();
        }

        private void FVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (VendaAtual != null)
                {
                    if (MessageBox.Show("Deseja cancelar a venda?", "VERP", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }
                }
                this.Close();
            }
        }
    }
}
