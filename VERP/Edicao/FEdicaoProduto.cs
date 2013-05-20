using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using VERP.Classes;
using VERP.Utils;
using VERPDatabase;

namespace VERP
{
    public partial class FEdicaoProduto : VERP.FEdicao
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

        private void FEdicaoProduto_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controles)
            {
                ((TextBox)ctr).Clear();
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
        }
    }
}
