using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase;

namespace VERP
{
    public partial class FCadProduto : Form
    {
        public Produto ProdutoAtual;

        public FCadProduto()
        {
            InitializeComponent();
            ProdutoAtual = null;
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
                ProdutoAtual = new Produto();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ProdutoAtual.Id > -1)
            {
                DB.GetInstance().ProdutoRepo.Salvar(ProdutoAtual);
            }
            else
            {
                DB.GetInstance().ProdutoRepo.Inserir(ProdutoAtual);
            }
        }
    }
}
