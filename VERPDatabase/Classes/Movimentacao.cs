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
        public BindingList<ItemMovimentacao> Itens { get; set; }
    }
}
