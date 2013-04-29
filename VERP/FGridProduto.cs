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
    public partial class FGridProduto : Form
    {
        public FGridProduto()
        {
            InitializeComponent();
        }

        private void GetProdutos()
        {
            if (tbxPesquisa.Text.Trim().Equals(""))
            {
                produtoBindingSource.DataSource = DB.ProdutoRepo.GetAll();
            }
            else
            {
                produtoBindingSource.DataSource = DB.ProdutoRepo.GetAll().Where(p => p.Codigo.Contains(tbxPesquisa.Text) ||
                    p.Descricao.ToUpper().Contains(tbxPesquisa.Text.ToUpper()));
            }
        }

        private void FGridProduto_Shown(object sender, EventArgs e)
        {
            tbxPesquisa.Text = "";
            GetProdutos();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            GetProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (produtoBindingSource.Current != null)
            {
                using (FCadProduto cadastro = new FCadProduto())
                {
                    cadastro.ProdutoAtual = (Produto)produtoBindingSource.Current;
                    cadastro.ShowDialog();
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            using (FCadProduto cadastro = new FCadProduto())
            {
                cadastro.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DB.ProdutoRepo.Deletar((Produto)produtoBindingSource.Current))
            {
                MessageBox.Show("Sucesso!");
            }
        }
    }
}
