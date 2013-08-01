using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIERP.Classes;
using QIERP.Utils;
using QIERPDatabase;
using QIERPDatabase.Classes;
using QIERP.CRUD;

namespace QIERP.Edicao
{
    public partial class FEdicaoMovimentacao : QIERP.FEdicao
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

        protected override void Mapear()
        {
            movimentacao.Descricao = tbxDescricao.Text;
            if (rbtEntrada.Checked)
            {
                movimentacao.Tipo = 0;
            }
            else
            {
                movimentacao.Tipo = 1;
            }
            movimentacao.ClienteOuFornecedor = pesClienteOuFornecedor.Objeto as Pessoa;
        }

        private void MapearTela()
        {
            tbxDescricao.Text = movimentacao.Descricao;
            if (movimentacao.Tipo == 1)
            {
                rbtSaida.Checked = true;
            }
            else
            {
                rbtEntrada.Checked = true;
            }
            pesClienteOuFornecedor.Objeto = movimentacao.ClienteOuFornecedor;
            pesClienteOuFornecedor.Selecionar();
        }


        private void FEdicaoMovimentacao_Shown(object sender, EventArgs e)
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
            pesClienteOuFornecedor.CRUD = new FCRUDPessoa();
            pesClienteOuFornecedor.Campo = "Documento";
            pesClienteOuFornecedor.CampoDisplay = "Nome";
            pesClienteOuFornecedor.Titulo = "Cliente/Fornecedor";
            pesClienteOuFornecedor.Repo = Util.GetRepo("Pessoas");
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
