using QIERPDatabase;
using QIERPDatabase.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class Orcamento : BaseVenda
    {
        public int Numero { get; set; }

        public Orcamento()
        {
            Itens = new BindingList<Item>();
        }

    }
}
