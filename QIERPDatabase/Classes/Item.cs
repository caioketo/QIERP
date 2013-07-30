using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase
{
    public class Item : ClasseBase
    {
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Total { get; set; }
        public string Descricao
        {
            get
            {
                return Produto.Descricao;
            }
        }

        public Item() { }
        public Item(Produto prod, double qtde)
        {
            this.Produto = prod;
            this.Quantidade = qtde;
            this.Valor = prod.Valor;
            this.Total = this.Valor * this.Quantidade;
        }
    }
}
