using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes
{
    public class Pessoa : ClasseBase
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
    }
}
