using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DB
    {
        public static ProdutoRepository ProdutoRepo = new ProdutoRepository();

        public static bool SalvaVenda(Venda VendaAtual)
        {
            DB.Error = "Não implementado!";
            return true;
            //throw new NotImplementedException();
        }

        public static string Error { get; set; }
    }
}
