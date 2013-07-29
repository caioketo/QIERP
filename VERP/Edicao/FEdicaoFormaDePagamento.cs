using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VERPDatabase;
using VERP.Utils;
using VERP.Classes;

namespace VERP.Edicao
{
    public partial class FEdicaoFormaDePagamento : FEdicao
    {
        public FEdicaoFormaDePagamento()
        {
            InitializeComponent();
        }

        private FormaDePagamento forma;

        protected void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().FPRepo.Inserir(forma);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().FPRepo.Salvar(forma);
            }

            this.Close();
        }

        private void FEdicaoFormaDePagamento_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controles)
            {
                ((TextBox)ctr).Clear();
            }
            if (estado == Estado.Inserir)
            {
                forma = new FormaDePagamento();
                Objeto = forma;
            }
            else if (estado == Estado.Modificar)
            {
                forma = Objeto as FormaDePagamento;
                //MapearTela();
            }
        }
    }
}
