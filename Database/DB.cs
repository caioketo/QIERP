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
        public static string Error { get; set; }

        private static bool IncluirItem(Item item)
        {
            return true;
        }

        public static bool IncluirVenda(Venda venda)
        {
            using (NpgsqlCommand comando = new NpgsqlCommand())
            {
                comando.Connection = Conexao;
                comando.CommandText = "insert into Vendas (dinheiro, cheque, debito, credito) values (@dinheiro, @cheque, @debito, @credito) returning id";
                comando.Parameters.AddWithValue("dinheiro", venda.PagtoDin);
                comando.Parameters.AddWithValue("cheque", venda.PagtoCheq);
                comando.Parameters.AddWithValue("debito", venda.PagtoDeb);
                comando.Parameters.AddWithValue("credito", venda.PagtoCred);
                try
                {
                    int vendaId = comando.ExecuteNonQuery();

                    foreach (Item item in venda.Itens)
                    {
                        if (!IncluirItem(item))
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
    }
}
