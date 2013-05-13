using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class Venda
    {
        public BindingList<Item> Itens { get; set; }
        public BindingList<Pagamento> Pagamentos { get; set; }
        public int Id { get; set; }
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

        public Venda()
        {
            Itens = new BindingList<Item>();
            Pagamentos = new BindingList<Pagamento>();
        }
    }
}
