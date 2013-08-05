using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using QIERP.Classes;
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP
{
    public partial class FEdicaoProduto : FEdicao
    {
        private Produto produto;

        public FEdicaoProduto()
        {
            InitializeComponent();
        }

        private bool ValidarCustom()
        {
            if (DB.GetInstance().ProdutoRepo.GetAll().Where(p => p.Codigo == produto.Codigo && p.Id != produto.Id).FirstOrDefault() != null)
            {
                Mensagem.MostrarMsg(40001, "Código");
                return false;
            }

            return true;
        }

        protected override void Gravar()
        {
            if (ValidarCustom())
            {
                if (estado == Estado.Inserir)
                {
                    DB.GetInstance().ProdutoRepo.Inserir(produto);
                }
                else if (estado == Estado.Modificar)
                {
                    DB.GetInstance().ProdutoRepo.Salvar(produto);
                }

                this.Close();
            }
        }

        protected override void Mapear()
        {
            produto.Codigo = tbxCodigo.Text;
            if (tbxCusto.Text.Contains("R$"))
            {
                produto.Custo = Convert.ToDouble(tbxCusto.Text.Substring(2));
            }
            else
            {
                produto.Custo = Convert.ToDouble(tbxCusto.Text);
            }

            if (tbxValor.Text.Contains("R$"))
            {
                produto.Valor = Convert.ToDouble(tbxValor.Text.Substring(2));
            }
            else
            {
                produto.Valor = Convert.ToDouble(tbxValor.Text);
            }
            produto.Descricao = tbxDescricao.Text;
            produto.Quantidade = Convert.ToDouble(tbxQuantidade.Text);
        }

        private void MapearTela()
        {
            tbxCodigo.Text = produto.Codigo;
            tbxCusto.Text = produto.Custo.ToString(GetCampo("Codigo").Formatacao);
            tbxDescricao.Text = produto.Descricao;
            tbxQuantidade.Text = produto.Quantidade.ToString(GetCampo("Quantidade").Formatacao);
            tbxValor.Text = produto.Valor.ToString(GetCampo("Valor").Formatacao);
        }

        private void FEdicaoProduto_Shown(object sender, EventArgs e)
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
                produto = new Produto();
                Objeto = produto;
            }
            else if (estado == Estado.Modificar)
            {
                produto = Objeto as Produto;
                MapearTela();
            }

            tbxCodigo.Focus();
        }

        private void FEdicaoProduto_Load(object sender, EventArgs e)
        {
            tbxCusto.Validating += tbx_Leave;
            tbxValor.Validating += tbx_Leave;
            tbxQuantidade.Validating += tbx_Leave;
        }

        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
