using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class FPRepository : IRepository<FormaDePagamento>
    {
        public bool Salvar(FormaDePagamento item)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(FormaDePagamento item)
        {
            throw new NotImplementedException();
        }

        public FormaDePagamento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<FormaDePagamento> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Deletar(FormaDePagamento item)
        {
            throw new NotImplementedException();
        }
    }
}
