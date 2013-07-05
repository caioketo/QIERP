using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class Cheque : ClasseBase
    {
        public string Numero { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Emissor { get; set; }
        public string Telefone { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
