using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class Tabela
    {
        public List<Campo> Campos = new List<Campo>();
        public string Nome;
        public string Descricao;
        public bool Edita = true;

        public Tabela(string nome)
        {
            Nome = nome;
            Campo campo = null;
            switch (Nome)
            {
                case "Produtos":
                    Campos.Add(new Campo("Codigo", "Código", "", TiposDeCampo.Varchar, 14, 0));
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Campos.Add(new Campo("Custo", "Custo", "c", TiposDeCampo.Numeric, 15, 2, true, false));
                    Campos.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2));
                    Campos.Add(new Campo("Quantidade", "Quantidade", "", TiposDeCampo.Numeric, 15, 2, true, false));
                    Descricao = "Produtos";
                    break;
                case "FormasDePagamento":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Descricao = "Formas de Pagamento";
                    break;
                case "CondicoesDePagamento":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    campo = new Campo("FormaDescricao", "Forma de Pagamento", "", TiposDeCampo.Varchar, 50);
                    campo.Edita = false;
                    Campos.Add(campo);
                    campo = new Campo("Forma", "Forma de Pagamento", "", TiposDeCampo.Model, 50);
                    campo.TabelaRel = "FormasDePagamento";
                    campo.CampoRel = "Descricao";
                    campo.DisplayRel = "Descricao";

                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    Descricao = "Condições de Pagamento";
                    break;
                case "Movimentacao":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    campo = new Campo("Tipo", "Tipo", "", TiposDeCampo.IntegerRadio, 2);
                    campo.Opcoes[0] = "Entrada";
                    campo.Opcoes[1] = "Saída";
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    campo = new Campo("TipoDescricao", "Tipo", "", TiposDeCampo.Varchar, 50);
                    campo.Edita = false;
                    Campos.Add(campo);
                    campo = new Campo("ClienteOuFornecedor", "Cliente/Fornecedor", "", TiposDeCampo.Model, 50);
                    campo.TabelaRel = "Pessoas";
                    campo.CampoRel = "Documento";
                    campo.DisplayRel = "Nome";
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    Edita = false;
                    Descricao = "Movimentações";
                    break;
                case "NotaFiscal":
                    Campos.Add(new Campo("Numero", "Número", "", TiposDeCampo.Varchar, 20));
                    campo = new Campo("Venda", "Venda", "", TiposDeCampo.Model, 50);
                    campo.TabelaRel = "Vendas";
                    campo.CampoRel = "Pedido";
                    campo.DisplayRel = "Pedido";
                    campo.Edita = false;
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    Descricao = "Notas Fiscais";
                    break;
                case "Pessoa":
                    Campos.Add(new Campo("Documento", "Documento", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("Nome", "Nome", "", TiposDeCampo.Varchar, 50));
                    campo = new Campo("NomeFantasia", "Nome Fantasia", "", TiposDeCampo.Varchar, 50);
                    campo.Obrigatorio = false;
                    Campos.Add(campo);
                    campo = new Campo("Telefone", "Telefone", "", TiposDeCampo.ModelUnico, 50);
                    campo.TabelaRel = "Telefone";
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    campo = new Campo("Endereco", "Endereço", "", TiposDeCampo.ModelUnico, 50);
                    campo.TabelaRel = "Endereco";
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    Descricao = "Pessoas";
                    break;
                case "Telefone":
                    Campos.Add(new Campo("Numero", "Número", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("Contato", "Contato", "", TiposDeCampo.Varchar, 30));
                    Descricao = "Telefones";
                    break;
                case "Endereco":
                    Campos.Add(new Campo("Logradouro", "Logradouro", "", TiposDeCampo.Varchar, 40));
                    Campos.Add(new Campo("Numero", "Número", "", TiposDeCampo.Varchar, 10));
                    Campos.Add(new Campo("Complemento", "Complemento", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("Bairro", "Bairro", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("CEP", "CEP", "", TiposDeCampo.Varchar, 10));
                    campo = new Campo("Cidade", "Cidade", "", TiposDeCampo.Model, 50);
                    campo.TabelaRel = "Cidades";
                    campo.CampoRel = "Descricao";
                    campo.DisplayRel = "Descricao";
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    Descricao = "Endereços";
                    break;
                case "Cidade":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    campo = new Campo("UF", "UF", "", TiposDeCampo.Model, 50);
                    campo.TabelaRel = "UFs";
                    campo.CampoRel = "Codigo";
                    campo.DisplayRel = "Descricao";
                    campo.MostraGrid = false;
                    Campos.Add(campo);
                    Descricao = "Cidades";
                    break;
                case "UF":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Campos.Add(new Campo("Codigo", "Código", "", TiposDeCampo.Varchar, 2));
                    Descricao = "UFs";
                    break;
                case "CR":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Campos.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2, true, true));
                    Campos.Add(new Campo("Vencimento", "Data de Vencimento", "d", TiposDeCampo.DateTime, 0));
                    campo = new Campo("Baixa", "Data da Baixa", "d", TiposDeCampo.DateTime, 0);
                    campo.Edita = false;
                    Campos.Add(campo);
                    campo = new Campo("Baixar", "Baixar", "", TiposDeCampo.Varchar, 0);
                    campo.Edita = false;
                    campo.ButtonInGrid = true;
                    Campos.Add(campo);
                    Descricao = "Contas à Receber";
                    break;
                case "CP":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Campos.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2, true, true));
                    Campos.Add(new Campo("Vencimento", "Data de Vencimento", "d", TiposDeCampo.DateTime, 0));
                    campo = new Campo("Baixa", "Data da Baixa", "d", TiposDeCampo.DateTime, 0);
                    campo.Edita = false;
                    Campos.Add(campo);
                    campo = new Campo("Baixar", "Baixar", "", TiposDeCampo.Varchar, 0);
                    campo.Edita = false;
                    campo.ButtonInGrid = true;
                    Campos.Add(campo);
                    Descricao = "Contas à Pagar";
                    break;
                case "Cheque":
                    Campos.Add(new Campo("Numero", "Número", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("Banco", "Banco", "", TiposDeCampo.Varchar, 3));
                    Campos.Add(new Campo("Agencia", "Agência", "", TiposDeCampo.Varchar, 6));
                    Campos.Add(new Campo("Conta", "Conta", "", TiposDeCampo.Varchar, 15));
                    Campos.Add(new Campo("Emissor", "Emissor", "", TiposDeCampo.Varchar, 50));
                    Campos.Add(new Campo("Telefone", "Telefone", "", TiposDeCampo.Varchar, 15));
                    Descricao = "Cheques";
                    break;
            }
        }
    }
}
