using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DB
    {
        public static Produto FindProduto(string codigo)
        {
            Produto retorno = new Produto();
            retorno.Descricao = "prod1";
            retorno.Valor = 10;
            return retorno;
        }

        public static bool SalvaVenda(Venda VendaAtual)
        {
            DB.Error = "Não implementado!";
            return true;
            //throw new NotImplementedException();
        }

        public static string Error { get; set; }
    }
}
