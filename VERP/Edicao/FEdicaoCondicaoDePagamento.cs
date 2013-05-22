using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VERP.Classes;
using VERPDatabase;

namespace VERP.Edicao
{
    public partial class FEdicaoCondicaoDePagamento : VERP.FEdicao
    {
        public FEdicaoCondicaoDePagamento()
        {
            InitializeComponent();
            this.Repo = DB.GetInstance().FPRepo;
        }

        private CondicaoDePagamento condicao;

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().CPRepo.Inserir(condicao);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().CPRepo.Salvar(condicao);
            }

            this.Close();
        }

        private void FEdicaoCondicaoDePagamento_Shown(object sender, EventArgs e)
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
                condicao = new CondicaoDePagamento();
                Objeto = condicao;
            }
            else if (estado == Estado.Modificar)
            {
                condicao = Objeto as CondicaoDePagamento;
                MapearTela();
            }
        }
    }
}
