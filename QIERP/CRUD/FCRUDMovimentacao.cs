using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERPDatabase;
using QIERP.Utils;
using QIERPDatabase.Classes;
using QIERP.Edicao;

namespace QIERP.CRUD
{
    public partial class FCRUDMovimentacao : QIERP.FCRUD
    {
        public FCRUDMovimentacao()
        {
            tabela = DB.GetInstance().GetTabela("Movimentacao");
            Edicao = new FEdicaoMovimentacao();
            InitializeComponent();
        }

        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().MovRepo.GetAll().Where(m => m.Descricao.ToUpper().Contains(tbxPesquisa.Text)); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().MovRepo.Deletar((Movimentacao)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
