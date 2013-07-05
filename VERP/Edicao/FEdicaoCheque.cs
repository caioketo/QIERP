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

namespace QIERP.Edicao
{
    public partial class FEdicaoCheque : VERP.FEdicao
    {
        public FEdicaoCheque()
        {
            InitializeComponent();
        }

        private Cheque cheque;

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().ChequeRepo.Inserir(cheque);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().ChequeRepo.Salvar(cheque);
            }

            this.Close();
        }

        private void FEdicaoCheque_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controles)
            {
                try
                {
                    ((TextBox)ctr).Clear();
                }
                catch
                {
                }
            }
            if (estado == Estado.Inserir)
            {
                cheque = new Cheque();
                Objeto = cheque;
            }
            else if (estado == Estado.Modificar)
            {
                cheque = Objeto as Cheque;
                MapearTela();
            }
        }

    }
}
