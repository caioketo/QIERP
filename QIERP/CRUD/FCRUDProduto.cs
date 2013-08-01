using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP
{
    public partial class FCRUDProduto : QIERP.FCRUD
    {
        protected override void GetRecords()
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DB.GetInstance().ProdutoRepo.Deletar((Produto)bindingSource.Current);
            DB.GetInstance().context.SaveChanges();
            GetRecords();
        }
    }
}
