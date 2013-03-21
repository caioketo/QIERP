using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Venda
    {
        public BindingList<Item> Itens { get; set; }

        public Venda()
        {
            Itens = new BindingList<Item>();
        }
    }
}
