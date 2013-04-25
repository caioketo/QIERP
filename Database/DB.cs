using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Database
{
    public class DB
    {
        private static NpgsqlConnection Conexao = new NpgsqlConnection("Server=192.168.0.10;User Id=postgres;" +
                                "Password=visual;Database=verp");
        public static ProdutoRepository ProdutoRepo = new ProdutoRepository();
        public static VendaRepository VendaRepo = new VendaRepository();
        public static FPRepository FPRepo = new FPRepository();
        public static CPRepository CPRepo = new CPRepository();

        public static string Error { get; set; }

        private static bool IncluirItem(Item item)
        {
            return true;
        }

        public static bool IncluirVenda(Venda venda)
        {
            return true;
        }
    }
}
