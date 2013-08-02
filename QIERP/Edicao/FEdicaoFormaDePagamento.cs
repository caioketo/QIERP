using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERPDatabase;
using QIERP.Utils;
using QIERP.Classes;

namespace QIERP.Edicao
{
    public partial class FEdicaoFormaDePagamento : FEdicao
    {
        public FEdicaoFormaDePagamento()
        {
            InitializeComponent();
        }

        private FormaDePagamento forma;

        protected override void Gravar()
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

        protected override void Mapear()
        {
            forma.Descricao = tbxDescricao.Text;
            forma.LancaCR = cbxLancaCR.Checked;
        }

        private void MapearTela()
        {
            tbxDescricao.Text = forma.Descricao;
            cbxLancaCR.Checked = forma.LancaCR;
        }

        private void FEdicaoFormaDePagamento_Shown(object sender, EventArgs e)
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
                forma = new FormaDePagamento();
                Objeto = forma;
            }
            else if (estado == Estado.Modificar)
            {
                forma = Objeto as FormaDePagamento;
                MapearTela();
            }

            tbxDescricao.Focus();
        }

        private void FEdicaoFormaDePagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
