using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using VERPDatabase;
using QIERP.Edicao;
using VERP.Utils;
using VERPDatabase.Classes;
using VERP.Classes;
using QIERP.Utils;

namespace QIERP.CRUD
{
    public partial class FCRUDNota : VERP.FCRUD
    {
        protected override void GetRecords()
        {
            bindingSource.DataSource = DB.GetInstance().NotaRepo.GetAll().Where(p => p.Numero.ToUpper().Contains(tbxPesquisa.Text));
        }

        public FCRUDNota()
        {
            tabela = DB.GetInstance().GetTabela("NotaFiscal");
            Edicao = new FEdicaoNota();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().NotaRepo.Deletar((NotaFiscal)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }

        private void btnImpVenda_Click(object sender, EventArgs e)
        {
            using (FSelecionaPedido sel = new FSelecionaPedido())
            {
                sel.ShowDialog();
                if (sel.resultado == null)
                {
                    return;
                }
                Edicao.Objeto = new NotaFiscal();
                ((NotaFiscal)Edicao.Objeto).Venda = sel.resultado;
            }
            Edicao.estado = Estado.Inserir;
            ((FEdicaoNota)Edicao).importacao = true;
            Edicao.ShowDialog();
        }
    }
}
