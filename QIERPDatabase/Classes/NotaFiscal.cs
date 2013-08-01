using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes
{
    public class NotaFiscal : ClasseBase
    {
        public string Numero { get; set; }
        public Venda Venda { get; set; }
        public int Pedido
        {
            get
            {
                if (Venda != null)
                {
                    return Venda.Pedido;
                }
                return 0;
            }
        }
        public Pessoa Destinatario { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
