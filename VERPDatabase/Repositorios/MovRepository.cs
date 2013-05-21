using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class MovRepository : IRepository<Movimentacao>
    {
        public bool Salvar(Movimentacao item)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Movimentacao item)
        {
            throw new NotImplementedException();
        }

        public Movimentacao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movimentacao> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Deletar(Movimentacao item)
        {
            throw new NotImplementedException();
        }
    }
}
