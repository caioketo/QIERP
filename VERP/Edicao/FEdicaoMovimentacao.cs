using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VERP.Classes;
using VERP.Utils;
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
            int mult = 1;
            if (movimentacao.Tipo == 1)
            {
                mult = -1;
            }
            foreach (ItemMovimentacao item in movimentacao.Itens)
            {
                item.Produto.Quantidade += item.Quantidade * mult;
                if (movimentacao.Tipo == 0)
                {
                    item.Produto.Custo = item.Valor;
                }
                DB.GetInstance().ProdutoRepo.Salvar(item.Produto);
            }

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


        private ItemMovimentacao FindItemProduto(Produto produto)
        {
            foreach (ItemMovimentacao item in movimentacao.Itens)
            {
                if (item.Produto.Id == produto.Id)
                {
                    return item;
                }
            }
            return null;
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
            gitItens.Campos = new List<Campo>();
            gitItens.Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
            gitItens.Campos.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2));
            gitItens.Campos.Add(new Campo("Quantidade", "Quantidade", "", TiposDeCampo.Numeric, 15, 2, true, false));
            gitItens.CamposEdicao = new List<Campo>();
            gitItens.CamposEdicao.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2));
            gitItens.CamposEdicao.Add(new Campo("Quantidade", "Quantidade", "", TiposDeCampo.Numeric, 15, 2, true, false));
            gitItens.pesPesquisa.Campo = "Código";
            gitItens.pesPesquisa.CampoDisplay = "Descricao";
            gitItens.pesPesquisa.CRUD = new FCRUDProduto();
            gitItens.pesPesquisa.Repo = DB.GetInstance().ProdutoRepo;
            gitItens.addItem -= AddItem;
            gitItens.addItem += AddItem;
            gitItens.removeItem -= RemoveItem;
            gitItens.removeItem += RemoveItem;
            gitItens.bindingSource.DataSource = movimentacao.Itens;
            gitItens.onLoad();
        }

        private void FEdicaoMovimentacao_Load(object sender, EventArgs e)
        {
            
        }

        public void AddItem(object[] Objeto)
        {
            ItemMovimentacao item = new ItemMovimentacao();
            item.Produto = (Produto)Objeto[0];
            item.Valor = Convert.ToDouble(((string)Objeto[1]).Substring(3));
            item.Quantidade = Convert.ToDouble(Objeto[2]);

            if (FindItemProduto(item.Produto) != null)
            {
                Mensagem.MostrarMsg(40005);
                return;
            }

            movimentacao.Itens.Add(item);
        }

        public void RemoveItem(object Objeto)
        {
            movimentacao.Itens.Remove((ItemMovimentacao)Objeto);
        }
    }
}
