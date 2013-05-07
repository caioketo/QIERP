using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;
using VERP.Classes;

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
            Campos.Add(new Campo("Codigo", "Código", "", TiposDeCampo.Varchar, 14));
            Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
            Campos.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2));

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
