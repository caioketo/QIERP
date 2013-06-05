﻿using System;
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
                    Edita = false;
                    Descricao = "Movimentações";
                    break;
                case "Pessoa":
                    Campos.Add(new Campo("Documento", "Documento", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("Nome", "Nome", "", TiposDeCampo.Varchar, 50));
                    campo = new Campo("NomeFantasia", "Nome Fantasia", "", TiposDeCampo.Varchar, 50);
                    campo.Obrigatorio = false;
                    Campos.Add(campo);
                    Descricao = "Pessoas";
                    break;
                case "Telefone":
                    Campos.Add(new Campo("Numero", "Número", "", TiposDeCampo.Varchar, 20));
                    Campos.Add(new Campo("Contato", "Contato", "", TiposDeCampo.Varchar, 30));
                    Descricao = "Telefones";
                    break;
            }
        }
    }
}
