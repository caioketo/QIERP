using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERP.Utils;
using VERPDatabase;

namespace VERP
{
    public partial class FConsProduto : Form
    {
        public FVenda Venda;
        private BindingList<Produto> Produtos;
        private void GetProdutos()
        {
            Produtos = new BindingList<Produto>(DB.GetInstance().ProdutoRepo.GetAll().Cast<Produto>().Where(p => p.Descricao.Contains(tbxProduto.Text)).ToList());
            dgvProdutos.DataSource = Produtos;
        }

        public FConsProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            GetProdutos();
        }
        
        private void FConsProduto_Load(object sender, EventArgs e)
        {
            GetProdutos();
        }

        private void tbxProduto_TextChanged(object sender, EventArgs e)
        {
            GetProdutos();
        }

        private void FConsProduto_Shown(object sender, EventArgs e)
        {
            tbxProduto.Focus();
        }

        private void FConsProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Mensagem.MostrarMsg(30000) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                Venda.tbxProduto.Text = ((Produto)dgvProdutos.CurrentRow.DataBoundItem).Codigo;
                this.Close();
            }
        }
    }
}
