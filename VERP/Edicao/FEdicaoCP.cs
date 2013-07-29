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
    public partial class FEdicaoCP : VERP.FEdicao
    {
        public FEdicaoCP()
        {
            InitializeComponent();
        }

        private ContaPagar conta;

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().CPRepo.Inserir(conta);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().CPRepo.Salvar(conta);
            }

            this.Close();
        }

        protected override void Mapear()
        {
            conta.Descricao = tbxDescricao.Text;
            if (tbxValor.Text.Contains("R$"))
            {
                conta.Valor = Convert.ToDecimal(tbxValor.Text.Substring(3));
            }
            else
            {
                conta.Valor = Convert.ToDecimal(tbxValor.Text);
            }
            conta.Vencimento = dtpVencimento.Value;
        }

        private void MapearTela()
        {
            tbxDescricao.Text = conta.Descricao;
            tbxValor.Text = conta.Valor.ToString(GetCampo("Valor").Formatacao);
            dtpVencimento.Value = conta.Vencimento;
        }

        private void FEdicaoCP_Shown(object sender, EventArgs e)
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
                conta = new ContaPagar();
                Objeto = conta;
            }
            else if (estado == Estado.Modificar)
            {
                conta = Objeto as ContaPagar;
                MapearTela();
            }
        }
    }
}
