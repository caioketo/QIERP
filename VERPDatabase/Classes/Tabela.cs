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

        public Tabela(string nome)
        {
            Nome = nome;

            switch (Nome)
            {
                case "Produtos":
                    Campos.Add(new Campo("Codigo", "Código", "", TiposDeCampo.Varchar, 14, 0));
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Campos.Add(new Campo("Custo", "Custo", "c", TiposDeCampo.Numeric, 15, 2, true, false));
                    Campos.Add(new Campo("Valor", "Valor", "c", TiposDeCampo.Numeric, 15, 2));
                    Campos.Add(new Campo("Quantidade", "Quantidade", "", TiposDeCampo.Numeric, 15, 2, true, false));
                    break;
                case "FormasDePagamento":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    break;
                case "CondicoesDePagamento":
                    Campos.Add(new Campo("Descricao", "Descrição", "", TiposDeCampo.Varchar, 50));
                    Campo formaDesc = new Campo("FormaDescricao", "Forma de Pagamento", "", TiposDeCampo.Varchar, 50);
                    formaDesc.Edita = false;
                    Campos.Add(formaDesc);
                    Campo forma = new Campo("Forma", "Forma de Pagamento", "", TiposDeCampo.Model, 50);
                    forma.Tabela = "FormasDePagamento";
                    forma.MostraGrid = false;
                    Campos.Add(forma);
                    break;
            }
        }
    }
}
