using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Edicao;
using QIERP.Utils;
using System.Data.Entity;
using System.Linq;
using QIERPDatabase;

namespace QIERP.CRUD
{
    public partial class FCRUDCondicaoDePagamento : QIERP.FCRUD
    {
        protected override void GetRecords()
        {
            DB.GetInstance().context.FormasDePagamento.Load();
            bindingSource.DataSource = DB.GetInstance().CondicaoRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text));
        }


        public FCRUDCondicaoDePagamento()
        {
            tabela = DB.GetInstance().GetTabela("CondicoesDePagamento");
            Edicao = new FEdicaoCondicaoDePagamento();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().CondicaoRepo.Deletar((CondicaoDePagamento)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
