using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VERP.Classes;
using VERPDatabase;
using VERPDatabase.Classes;

namespace VERP
{
    public partial class FCRUDProduto : VERP.FCRUD
    {
        public void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().ProdutoRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text) ||
                p.Codigo == tbxPesquisa.Text);
        }


        public FCRUDProduto()
        {
            tabela = DB.GetInstance().GetTabela("Produtos");
            Edicao = new FEdicaoProduto();
            InitializeComponent();
        }

        private void FCRUDProduto_Shown(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void FCRUDProduto_Activated(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DB.GetInstance().ProdutoRepo.Deletar((Produto)bindingSource.Current);
            DB.GetInstance().context.SaveChanges();
            GetRecords();
        }
    }
}
