using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class FPRepository : IRepository<FormaDePagamento>
    {
        private List<FormaDePagamento> FPs = new List<FormaDePagamento>();

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
            foreach (FormaDePagamento pag in FPs)
            {
                if (pag.Id == id)
                {
                    return pag;
                }
            }
            return null;
        }

        public IQueryable<FormaDePagamento> GetAll()
        {
            if (FPs.Count == 0)
            {
                FormaDePagamento fp1 = new FormaDePagamento();
                fp1.Id = 1;
                fp1.Descricao = "Dinheiro";
                FormaDePagamento fp2 = new FormaDePagamento();
                fp2.Id = 2;
                fp2.Descricao = "Cartão de Crédito";
                FPs.Add(fp1);
                FPs.Add(fp2);
            }
            return FPs.AsQueryable();
        }

        public bool Deletar(FormaDePagamento item)
        {
            throw new NotImplementedException();
        }
    }
}
