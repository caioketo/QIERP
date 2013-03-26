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
        private Venda VendaAtual;

        public FVenda()
        {
            InitializeComponent();
        }

        public void AddItem(Item item)
        {
            VendaAtual.Itens.Add(item);
            rtbTotal.Text = "Total: " + VendaAtual.Total.ToString("C2") + Environment.NewLine 
                + "Total Itens: " + VendaAtual.Itens.Count.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Venda_Shown(object sender, EventArgs e)
        {
            VendaAtual = new Venda();
            itemBindingSource.DataSource = VendaAtual.Itens;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            Produto prod = Database.Database.FindProduto(tbxProduto.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FFechaVenda fechaVenda = new FFechaVenda();
            fechaVenda.VendaAtual = this.VendaAtual;
            fechaVenda.ShowDialog();
        }
    }
}
