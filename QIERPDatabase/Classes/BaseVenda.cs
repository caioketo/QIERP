using QIERPDatabase;
using QIERPDatabase.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes
{
    public class BaseVenda : ClasseBase
    {
        public BindingList<Item> Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }

        public double Total
        {
            get
            {
                double t = 0;
                foreach (Item item in Itens)
                {
                    t += item.Total;
                }
                return t;
            }
        }
        public string ClienteNome
        {
            get
            {
                if (Cliente != null && Cliente.Pessoa != null)
                {
                    return Cliente.Pessoa.Nome;
                }
                return "";
            }
        }

        public string VendedorNome
        {
            get
            {
                if (Vendedor != null && Vendedor.Pessoa != null)
                {
                    return Vendedor.Pessoa.Nome;
                }
                return "";
            }
        }
    }
}
