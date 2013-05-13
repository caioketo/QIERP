using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class CPRepository : IRepository<CondicaoDePagamento>
    {
        private List<CondicaoDePagamento> CPs = new List<CondicaoDePagamento>();

        public bool Salvar(CondicaoDePagamento item)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(CondicaoDePagamento item)
        {
            throw new NotImplementedException();
        }

        public CondicaoDePagamento GetById(int id)
        {
            foreach (CondicaoDePagamento cond in CPs)
            {
                if (cond.Id == id)
                {
                    return cond;
                }
            }
            return null;
        }

        public IQueryable<CondicaoDePagamento> GetAll()
        {
            if (CPs.Count == 0)
            {
                CondicaoDePagamento fp1 = new CondicaoDePagamento();
                fp1.Id = 1;
                fp1.Descricao = "Dinheiro";
                CondicaoDePagamento fp2 = new CondicaoDePagamento();
                fp2.Id = 2;
                fp2.Descricao = "Cartão de Crédito";
                CPs.Add(fp1);
                CPs.Add(fp2);
            }
            return CPs.AsQueryable();            
        }

        public bool Deletar(CondicaoDePagamento item)
        {
            throw new NotImplementedException();
        }
    }
}
