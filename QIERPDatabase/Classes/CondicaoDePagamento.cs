using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase
{
    public class CondicaoDePagamento : ClasseBase
    {
        public string Descricao { get; set; }
        public int DiasVencimento { get; set; }
        public FormaDePagamento Forma { get; set; }
        public string FormaDescricao
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
    }
}
