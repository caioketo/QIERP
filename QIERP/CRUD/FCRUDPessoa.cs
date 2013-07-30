using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VERPDatabase;
using VERPDatabase.Classes;
using VERP.Utils;
using VERP.Edicao;
using VERPDatabase.Repositorios;

namespace VERP.CRUD
{
    public partial class FCRUDPessoa : VERP.FCRUD
    {
        protected override void GetRecords()
        {
            if (Filter.Equals("Clientes"))
            {
                List<int> clientesIds = DB.GetInstance().ClienteRepo.GetFields("Pessoa_Id");
                bindingSource.DataSource = DB.GetInstance().PessoaRepo.GetAll().Where(p => (p.Nome.ToUpper().Contains(tbxPesquisa.Text) ||
                p.NomeFantasia.ToUpper().Contains(tbxPesquisa.Text) || p.Documento.Contains(tbxPesquisa.Text)) && (clientesIds.Contains(p.Id)));
            }
            else if (Filter.Equals("Vendedores"))
            {
                List<int> vendedoresIds = DB.GetInstance().VendedorRepo.GetFields("Pessoa_Id");
                bindingSource.DataSource = DB.GetInstance().PessoaRepo.GetAll().Where(p => (p.Nome.ToUpper().Contains(tbxPesquisa.Text) ||
                p.NomeFantasia.ToUpper().Contains(tbxPesquisa.Text) || p.Documento.Contains(tbxPesquisa.Text)) && (vendedoresIds.Contains(p.Id)));
            }
            else
            {
                bindingSource.DataSource = DB.GetInstance().PessoaRepo.GetAll().Where(p => p.Nome.ToUpper().Contains(tbxPesquisa.Text) ||
                p.NomeFantasia.ToUpper().Contains(tbxPesquisa.Text) || p.Documento.Contains(tbxPesquisa.Text));
            }
        }

        public FCRUDPessoa()
        {
            tabela = DB.GetInstance().GetTabela("Pessoa");
            Edicao = new FEdicaoPessoa();
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem.MostrarMsg(30002) == System.Windows.Forms.DialogResult.Yes)
            {
                DB.GetInstance().PessoaRepo.Deletar((Pessoa)bindingSource.Current);
                DB.GetInstance().context.SaveChanges();
                GetRecords();
            }
        }
    }
}
