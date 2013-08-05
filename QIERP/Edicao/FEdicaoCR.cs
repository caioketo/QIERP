using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP.Edicao
{
    public partial class FEdicaoCR : QIERP.FEdicao
    {
        public FEdicaoCR()
        {
            InitializeComponent();
        }

        private ContaReceber conta;

        protected override void Gravar()
        {
            if (estado == Estado.Inserir)
            {
                DB.GetInstance().CRRepo.Inserir(conta);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().CRRepo.Salvar(conta);
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

        private void FEdicaoCR_Shown(object sender, EventArgs e)
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
                conta = new ContaReceber();
                Objeto = conta;
            }
            else if (estado == Estado.Modificar)
            {
                conta = Objeto as ContaReceber;
                MapearTela();
            }

            tbxDescricao.Focus();
        }

        private void FEdicaoCR_Load(object sender, EventArgs e)
        {
            tbxValor.Validating += tbx_Leave;
        }
    }
}
