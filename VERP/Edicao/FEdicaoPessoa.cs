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
        }

    }
}
