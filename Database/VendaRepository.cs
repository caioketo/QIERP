using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class VendaRepository : IRepository<Venda>
    {
        public bool Salvar(Venda item)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Venda item)
        {
            return DB.IncluirVenda(item);
        }

        public Venda GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Venda> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Deletar(Venda item)
        {
            throw new NotImplementedException();
        }
    }
}
