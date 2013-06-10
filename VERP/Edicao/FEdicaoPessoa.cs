using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VERP.Classes;
using VERPDatabase;
using VERPDatabase.Classes;

namespace VERP.Edicao
{
    public partial class FEdicaoPessoa : VERP.FEdicao
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

        private void FEdicaoPessoa_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controles)
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
            }
            else if (estado == Estado.Modificar)
            {
                pessoa = Objeto as Pessoa;
                MapearTela();
            }

            cbxCliente.Checked = (DB.GetInstance().ClienteRepo.GetByPessoa(pessoa) != null);
            cbxVendedor.Checked = (DB.GetInstance().VendedorRepo.GetByPessoa(pessoa) != null);            
        }

    }
}
