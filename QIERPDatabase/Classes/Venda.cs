using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase
{
    public class Venda : ClasseBase
    {
        public BindingList<Item> Itens { get; set; }
        public BindingList<Pagamento> Pagamentos { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public int Pedido { get; set; }
        public double Troco
        {
            get
            {
                return TotalPagto - Total;
            }
        }
        public double TotalPagto
        {
            get
            {
                double t = 0;
                foreach (Pagamento pagamento in Pagamentos)
                {
                    t += pagamento.Valor;
                }
                return t;
            }
        }
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

        public Venda()
        {
            Itens = new BindingList<Item>();
            Pagamentos = new BindingList<Pagamento>();
        }
    }
}
