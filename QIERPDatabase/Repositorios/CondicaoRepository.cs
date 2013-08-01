using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace QIERPDatabase
{
    public class CondicaoRepository : IRepository<CondicaoDePagamento>
    {
        public IQueryable<CondicaoDePagamento> GetAll()
        {
            DB.GetInstance().context.CondicoesDePagamento.Load();
            return DB.GetInstance().context.CondicoesDePagamento.Local.AsQueryable().Where(cp => cp.DataExclusao == null);
        }

        public bool Salvar(CondicaoDePagamento item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(CondicaoDePagamento item)
        {
            DB.GetInstance().context.CondicoesDePagamento.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public CondicaoDePagamento GetById(int id)
        {
            return DB.GetInstance().context.CondicoesDePagamento.Find(id);
        }

        public bool Deletar(CondicaoDePagamento item)
        {
            DB.GetInstance().context.Entry<CondicaoDePagamento>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }
    }
}
