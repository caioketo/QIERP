using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ProdutoRepository : IRepository<Produto>
    {
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


        public IQueryable<Produto> GetAll()
        {
            List<Produto> lista = new List<Produto>();
            return lista.AsQueryable();
        }
    }
}
