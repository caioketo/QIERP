using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VERP.Edicao;
using VERP.Utils;
using VERPDatabase;

namespace VERP.CRUD
{
    public partial class FCRUDFormaDePagamento : FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().FPRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text));
        }


        public FCRUDFormaDePagamento()
        {
            tabela = DB.GetInstance().GetTabela("FormasDePagamento");
            Edicao = new FEdicaoFormaDePagamento();
            InitializeComponent();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().FPRepo.Deletar((FormaDePagamento)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
