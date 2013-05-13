using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase
{
    public class Produto : ClasseBase
    {
        public string Descricao { get; set; }
        public double Custo { get; set; }
        public double Valor { get; set; }
        public string Codigo { get; set; }
    }
}