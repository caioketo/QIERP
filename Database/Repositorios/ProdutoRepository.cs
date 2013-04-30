using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ProdutoRepository : IRepository<Produto>
    {
        public IQueryable<Produto> GetAll()
        {
            List<Produto> lista = new List<Produto>();
            Produto prod = new Produto();
            prod.Codigo = "1";
            prod.Descricao = "Teste";
            prod.Id = 1;
            prod.Valor = 100;
            lista.Add(prod);
            return lista.AsQueryable();
        }

        public bool Salvar(Produto item)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Produto item)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Deletar(Produto item)
        {
            throw new NotImplementedException();
        }
    }
}
