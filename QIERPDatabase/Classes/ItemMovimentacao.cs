using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Classes
{
    public class ItemMovimentacao : ClasseBase
    {
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }

        public string Descricao
        {
            get
            {
                return Produto.Descricao;
            }
        }
    }
}
