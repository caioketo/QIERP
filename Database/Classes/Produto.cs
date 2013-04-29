using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Codigo { get; set; }

        public Produto()
        {
            this.Id = -1;
        }

        public Produto(int id)
        {
            this.Id = id;
        }
    }
}
