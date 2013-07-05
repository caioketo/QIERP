using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class NotaFiscal : ClasseBase
    {
        public string Numero { get; set; }
        public Venda Venda { get; set; }
        public Pessoa Destinatario { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
