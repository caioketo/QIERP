using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pagamento
    {
        public FormaDePagamento Forma { get; set; }
        public string FormaPagto
        {
            get
            {
                return Forma.Descricao;
            }
        }
        public double Valor { get; set; }
    }
}
