using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using VERPDatabase;
using VERP.Edicao;
using VERP.Utils;
using VERPDatabase.Classes;

namespace VERP.CRUD
{
    public partial class FCRUDUF : VERP.FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().UFRepo.GetAll().Where(p => p.Descricao.ToUpper().Contains(tbxPesquisa.Text) ||
                p.Codigo.ToUpper().Contains(tbxPesquisa.Text));
        }

        public FCRUDUF()
        {
            tabela = DB.GetInstance().GetTabela("UF");
            Edicao = new FEdicaoUF();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().UFRepo.Deletar((UF)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
