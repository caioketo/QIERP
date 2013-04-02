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
        public double PagtoDin { get; set; }
        public double PagtoCred { get; set; }
        public double PagtoDeb { get; set; }
        public double PagtoCheq { get; set; }
        public double Troco
        {
            get
            {
                return (PagtoCheq + PagtoCred + PagtoDeb + PagtoDin) - Total;
            }
        }
        public double TotalPagto
        {
            get
            {
                return (PagtoCheq + PagtoCred + PagtoDeb + PagtoDin);
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
        }
    }
}
