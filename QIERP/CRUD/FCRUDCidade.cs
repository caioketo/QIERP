using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using QIERPDatabase;
using QIERPDatabase.Classes;
using QIERP.Utils;
using QIERP.Edicao;
using System.Linq.Expressions;

namespace QIERP.CRUD
{
    public partial class FCRUDCidade : QIERP.FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().CidadeRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text));
        }

        public FCRUDCidade()
        {
            tabela = DB.GetInstance().GetTabela("Cidade");
            Edicao = new FEdicaoCidade();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().CidadeRepo.Deletar((Cidade)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
