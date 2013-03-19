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
    public partial class Venda : Form
    {
        private Produto produtoAchado;

        public Venda()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Venda_Shown(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Id = 1;
            item.Quantidade = 1;
            item.Valor = 10;
            item.Total = 10;
            Produto prod = new Produto();
            prod.Id = 1;
            prod.Descricao = "Teste";
            item.Produto = prod;
            itemBindingSource.Add(item);
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

            itemBindingSource.Add(new Item(produtoAchado, Convert.ToDouble(tbxQtde.Text)));
        }
    }
}
