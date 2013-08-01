using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase
{
    public class Pagamento : ClasseBase
    {
        public FormaDePagamento Forma { get; set; }
        public string FormaPagto
        {
            get
            {
                if (Forma == null)
                {
                    return "";
                }
                return Forma.Descricao;
            }
        }

        public CondicaoDePagamento Condicao { get; set; }
        public string CondicaoPagto
        {
            get
            {
                if (Condicao == null)
                {
                    return "";
                }
                return Condicao.Descricao;
            }
        }

        public double Valor { get; set; }
    }
}
