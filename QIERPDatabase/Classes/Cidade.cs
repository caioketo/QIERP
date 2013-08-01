using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes
{
    public class Cidade : ClasseBase
    {
        public string Descricao { get; set; }
        public UF Estado { get; set; }
    }
}
