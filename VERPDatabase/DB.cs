using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;
using VERPDatabase.Repositorios;

namespace VERPDatabase
{
    public enum Modo
    {
        Inserir,
        Editar,
        Excluir
    }

    public class DB
    {
        private static DB Instance = null;

        public static DB GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DB();
            }
            return Instance;
        }

        private List<Tabela> Tabelas = new List<Tabela>();


        public ProdutoRepository ProdutoRepo = new ProdutoRepository();
        public VendaRepository VendaRepo = new VendaRepository();
        public FPRepository FPRepo = new FPRepository();
        public CPRepository CPRepo = new CPRepository();
        public MovRepository MovRepo = new MovRepository();
        public PessoaRepository PessoaRepo = new PessoaRepository();
        public TelefoneRepository TelefoneRepo = new TelefoneRepository();
        public VerpContext context;


        public string Error { get; set; }

        private bool IncluirItem(Item item)
        {
            return true;
        }

        public bool IncluirVenda(Venda venda)
        {
            return true;
        }

        public Tabela GetTabela(string nome)
        {
            foreach (Tabela tab in Tabelas)
            {
                if (tab.Nome.ToUpper().Equals(nome.ToUpper()))
                {
                    return tab;
                }
            }
            return null;
        }

        public DB()
        {
            context = new VerpContext(VerpContext.CreateConnectionString());
            Tabelas.Add(new Tabela("Produtos"));
            Tabelas.Add(new Tabela("FormasDePagamento"));
            Tabelas.Add(new Tabela("CondicoesDePagamento"));
            Tabelas.Add(new Tabela("Movimentacao"));
            Tabelas.Add(new Tabela("Pessoa"));
            Tabelas.Add(new Tabela("Telefone"));
        }
    }
}
