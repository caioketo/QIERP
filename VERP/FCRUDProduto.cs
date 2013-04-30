using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;

namespace VERP
{
    public partial class FCRUDProduto : VERP.FCRUD
    {
        public void GetRecords()
        {
            bindingSource.DataSource = DB.ProdutoRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text) ||
                p.Codigo == tbxPesquisa.Text);
        }


        public FCRUDProduto()
        {
            Campos = new string[]{"Codigo", "Descricao", "Valor"};
            Titulos = new string[] { "Código", "Descrição", "Valor" };
            Formats = new string[] { "", "", "c" };
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
    }
}
