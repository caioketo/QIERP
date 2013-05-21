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
        }

        public dynamic GetAll(string tabela)
        {
            if (tabela == "Produtos")
            {
                return ProdutoRepo.GetAll().ToList(); ;
            }
            if (tabela == "FormasDePagamento")
            {
                return FPRepo.GetAll().ToList();
            }
            if (tabela == "CondicoesDePagamento")
            {
                return CPRepo.GetAll().ToList();
            }
            if (tabela == "Vendas")
            {
                return VendaRepo.GetAll().ToList();
            }
            if (tabela == "Movimentacao")
            {
                return MovRepo.GetAll().ToList();
            }
            return null;
        }

        public dynamic GetById(string tabela, int id)
        {
            if (tabela == "Produtos")
            {
                return ProdutoRepo.GetById(id);
            }
            if (tabela == "FormasDePagamento")
            {
                return FPRepo.GetById(id);
            }
            if (tabela == "CondicoesDePagamento")
            {
                return CPRepo.GetById(id);
            }
            if (tabela == "Vendas")
            {
                return VendaRepo.GetById(id);
            }
            if (tabela == "Movimentacao")
            {
                return MovRepo.GetById(id);
            }
            return null;
        }
    }
}
