using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class VendaRepository : IRepository<Venda>
    {
        private List<Venda> Vendas = new List<Venda>();

        public bool Salvar(Venda item)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(Venda item)
        {
            if (DB.GetInstance().IncluirVenda(item))
            {
                Vendas.Add(item);
                return true;
            }
            return false;
        }

        public Venda GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Venda> GetAll()
        {
            return Vendas.AsQueryable();
        }

        public bool Deletar(Venda item)
        {
            throw new NotImplementedException();
        }
    }
}
