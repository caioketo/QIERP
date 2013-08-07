using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes.DTO
{
    public class DTO_Orcamento
    {
        public int Numero { get; set; }
        public string ClienteNome { get; set; }
        public string VendedorNome { get; set; }
        public BindingList<Item> Itens { get; set; }

        public DTO_Orcamento()
        {
            Itens = new BindingList<Item>();
        }
    }
}
