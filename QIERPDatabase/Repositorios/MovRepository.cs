using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class MovRepository : IRepository<Movimentacao>
    {
        public bool Salvar(Movimentacao item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Movimentacao item)
        {
            DB.GetInstance().context.Movimentacoes.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Movimentacao GetById(int id)
        {
            return DB.GetInstance().context.Movimentacoes.Find(id);
        }

        public IQueryable<Movimentacao> GetAll()
        {
            DB.GetInstance().context.Movimentacoes.Load();
            return DB.GetInstance().context.Movimentacoes.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Deletar(Movimentacao item)
        {
            DB.GetInstance().context.Entry<Movimentacao>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }
    }
}
