using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;
using VERPDatabase.Classes;

namespace QIERPDatabase
{
    public class Venda : BaseVenda
    {
        public BindingList<Pagamento> Pagamentos { get; set; }
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

        public Venda()
        {
            Itens = new BindingList<Item>();
            Pagamentos = new BindingList<Pagamento>();
        }
    }
}
