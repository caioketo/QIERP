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
    public partial class FEdicaoMovimentacao : VERP.FEdicao
    {
        public FEdicaoMovimentacao()
        {
            InitializeComponent();
        }

        private Movimentacao movimentacao;

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().MovRepo.Inserir(movimentacao);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().MovRepo.Salvar(movimentacao);
            }

            this.Close();
        }

        private void FEdicaoMovimentacao_Shown(object sender, EventArgs e)
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
                movimentacao = new Movimentacao();
                Objeto = movimentacao;
            }
            else if (estado == Estado.Modificar)
            {
                movimentacao = Objeto as Movimentacao;
                MapearTela();
            }
        }
    }
}
