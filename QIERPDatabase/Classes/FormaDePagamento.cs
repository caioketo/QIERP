using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase
{
    public class FormaDePagamento : ClasseBase
    {
        public string Descricao { get; set; }
        public bool LancaCR { get; set; }
    }
}
