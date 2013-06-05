using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class Movimentacao : ClasseBase
    {
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public string TipoDescricao
        {
            get
            {
                if (Tipo == 0)
                {
                    return "Entrada";
                }
                else
                {
                    return "Saída";
                }
            }
        }
        public BindingList<ItemMovimentacao> Itens { get; set; }

        public Movimentacao()
        {
            Itens = new BindingList<ItemMovimentacao>();
        }
    }
}
