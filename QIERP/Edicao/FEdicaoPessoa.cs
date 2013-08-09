using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP.Edicao
{
    public partial class FEdicaoPessoa : QIERP.FEdicao
    {
        private Pessoa pessoa;

        public FEdicaoPessoa()
        {
            InitializeComponent();
        }

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().PessoaRepo.Inserir(pessoa);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().PessoaRepo.Salvar(pessoa);
            }

            if (cbxCliente.Checked)
            {
                if (estado == Estado.Inserir)
                {
                    Cliente cliente = new Cliente();
                    cliente.Pessoa = pessoa;
                    DB.GetInstance().ClienteRepo.Inserir(cliente);
                }
            }
            else
            {
                if (estado == Estado.Modificar && DB.GetInstance().ClienteRepo.GetByPessoa(pessoa) != null)
                {
                    DB.GetInstance().ClienteRepo.Deletar(DB.GetInstance().ClienteRepo.GetByPessoa(pessoa));
                }
            }


            if (cbxVendedor.Checked)
            {
                if (estado == Estado.Inserir)
                {
                    Vendedor vendedor = new Vendedor();
                    vendedor.Pessoa = pessoa;
                    DB.GetInstance().VendedorRepo.Inserir(vendedor);
                }
            }
            else
            {
                if (estado == Estado.Modificar && DB.GetInstance().VendedorRepo.GetByPessoa(pessoa) != null)
                {
                    DB.GetInstance().VendedorRepo.Deletar(DB.GetInstance().VendedorRepo.GetByPessoa(pessoa));
                }
            }

            this.Close();
        }

        protected override void Mapear()
        {
            pessoa.Documento = tbxDocumento.Text;
            pessoa.Nome = tbxNome.Text;
            pessoa.NomeFantasia = tbxNomeFantasia.Text;
            edcTelefone.Gravar();
            pessoa.Telefone = (Telefone)edcTelefone.Objeto;
            edcEndereco.Gravar();
            pessoa.Endereco = (Endereco)edcEndereco.Objeto;
        }

        private void MapearTela()
        {
            tbxDocumento.Text = pessoa.Documento;
            tbxNome.Text = pessoa.Nome;
            tbxNomeFantasia.Text = pessoa.NomeFantasia;
            edcEndereco.Objeto = pessoa.Endereco;
            edcEndereco.MapearTela();
            edcTelefone.Objeto = pessoa.Telefone;
            edcTelefone.MapearTela();
            if (DB.GetInstance().ClienteRepo.GetAll().Where(c => c.Pessoa == pessoa).FirstOrDefault() == null)
            {
                cbxCliente.Checked = false;
            }
            else
            {
                cbxCliente.Checked = true;
            }
            if (DB.GetInstance().VendedorRepo.GetAll().Where(v => v.Pessoa == pessoa).FirstOrDefault() == null)
            {
                cbxVendedor.Checked = false;
            }
            else
            {
                cbxVendedor.Checked = true;
            }
        }

        private void FEdicaoPessoa_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    ((TextBox)ctr).Clear();
                }
            }
            if (estado == Estado.Inserir)
            {
                pessoa = new Pessoa();
                Objeto = pessoa;
                edcEndereco.estado = Estado.Inserir;
                edcEndereco.Objeto = new Endereco();
                edcTelefone.estado = Estado.Inserir;
                edcTelefone.Objeto = new Telefone();
            }
            else if (estado == Estado.Modificar)
            {
                pessoa = Objeto as Pessoa;
                edcEndereco.estado = Estado.Modificar;
                edcTelefone.estado = Estado.Modificar;
                MapearTela();
            }

            tbxDocumento.Focus();
        }

        private void FEdicaoPessoa_Load(object sender, EventArgs e)
        {
            edcTelefone.Repo = Util.GetRepo("Telefones");
            edcTelefone.tabela = DB.GetInstance().GetTabela("Telefones");
            edcTelefone.cmpEdicao_Load(this, null);
            edcEndereco.Repo = Util.GetRepo("Enderecos");
            edcEndereco.tabela = DB.GetInstance().GetTabela("Enderecos");
            edcEndereco.cmpEdicao_Load(this, null);
        }

    }
}
