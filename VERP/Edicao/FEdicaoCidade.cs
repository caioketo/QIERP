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
    public partial class FEdicaoCidade : VERP.FEdicao
    {
        private Cidade cidade;

        public FEdicaoCidade()
        {
            InitializeComponent();
        }

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().CidadeRepo.Inserir(cidade);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().CidadeRepo.Salvar(cidade);
            }

            this.Close();
        }

        private void FEdicaoCidade_Shown(object sender, EventArgs e)
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
                cidade = new Cidade();
                Objeto = cidade;
            }
            else if (estado == Estado.Modificar)
            {
                cidade = Objeto as Cidade;
                MapearTela();
            }
        }

    }
}
