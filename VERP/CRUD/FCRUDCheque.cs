using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QIERP.Edicao;
using VERP.Utils;
using VERPDatabase;
using VERPDatabase.Classes;

namespace QIERP.CRUD
{
    public partial class FCRUDCheque : VERP.FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().ChequeRepo.GetAll().Where(p => p.Numero.ToUpper().Contains(tbxPesquisa.Text));
        }

        public FCRUDCheque()
        {
            tabela = DB.GetInstance().GetTabela("Cheque");
            Edicao = new FEdicaoCheque();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().ChequeRepo.Deletar((Cheque)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
