using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERPDatabase;
using QIERP.CRUD;
using QIERP.Utils;

namespace QIERP.Edicao
{
    public partial class FEdicaoCondicaoDePagamento : QIERP.FEdicao
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
                DB.GetInstance().CondicaoRepo.Inserir(condicao);
            }
            else if (estado == Estado.Modificar)
            {
                DB.GetInstance().CondicaoRepo.Salvar(condicao);
            }

            this.Close();
        }

        protected override void Mapear()
        {
            condicao.Descricao = tbxDescricao.Text;
            condicao.DiasVencimento = Convert.ToInt32(tbxDiasVencimento.Text);
            condicao.Parcelas = Convert.ToInt32(tbxParcelas.Text);
            condicao.Forma = pesFormaDePagamento.Objeto as FormaDePagamento;
        }

        private void MapearTela()
        {
            tbxDescricao.Text = condicao.Descricao;
            tbxDiasVencimento.Text = condicao.DiasVencimento.ToString();
            tbxParcelas.Text = condicao.Parcelas.ToString();
            pesFormaDePagamento.Objeto = condicao.Forma;
            pesFormaDePagamento.Selecionar();
        }

        private void FEdicaoCondicaoDePagamento_Shown(object sender, EventArgs e)
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
                condicao = new CondicaoDePagamento();
                Objeto = condicao;
                pesFormaDePagamento.Reset();
            }
            else if (estado == Estado.Modificar)
            {
                condicao = Objeto as CondicaoDePagamento;
                MapearTela();
            }

            tbxDescricao.Focus();
        }

        private void FEdicaoCondicaoDePagamento_Load(object sender, EventArgs e)
        {
            pesFormaDePagamento.CRUD = new FCRUDFormaDePagamento();
            pesFormaDePagamento.Campo = "Descricao";
            pesFormaDePagamento.CampoDisplay = "Descricao";
            pesFormaDePagamento.Titulo = "Forma de Pagamento";
            pesFormaDePagamento.Repo = Util.GetRepo("FormasDePagamento");
            tbxDiasVencimento.Validating += tbx_Leave;
            tbxParcelas.Validating += tbxLeave;
        }
    }
}
