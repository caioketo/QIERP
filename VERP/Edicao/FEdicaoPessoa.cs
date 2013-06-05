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
            edcTelefone.tabela = DB.GetInstance().GetTabela("Telefone");
            edcTelefone.Repo = DB.GetInstance().TelefoneRepo;
        }

        protected override void Gravar()
        {
            edcTelefone.Gravar();
            pessoa.Telefone = edcTelefone.Objeto as Telefone;
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().PessoaRepo.Inserir(pessoa);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().PessoaRepo.Salvar(pessoa);
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
            edcTelefone.estado = estado;
            if (estado == Estado.Inserir)
            {
                pessoa = new Pessoa();
                Objeto = pessoa;
                edcTelefone.Objeto = new Telefone();
            }
            else if (estado == Estado.Modificar)
            {
                pessoa = Objeto as Pessoa;
                edcTelefone.Objeto = pessoa.Telefone;
                MapearTela();
                edcTelefone.MapearTela();
            }
        }

    }
}
