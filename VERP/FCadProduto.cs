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
    public partial class FCadProduto : Form
    {
        public Produto ProdutoAtual = null;

        public FCadProduto()
        {
            InitializeComponent();
        }

        private void FCadProduto_Shown(object sender, EventArgs e)
        {
            if (ProdutoAtual != null)
            {
                tbxCodigo.Text = ProdutoAtual.Codigo;
                tbxDescricao.Text = ProdutoAtual.Descricao;
                tbxValor.Text = ProdutoAtual.Valor.ToString("c");
            }
            else
            {
                tbxValor.Clear();
                tbxDescricao.Clear();
                tbxCodigo.Clear();
            }
        }
    }
}
