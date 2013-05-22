using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using VERPDatabase.Repositorios;

namespace VERPDatabase
{
    public class FPRepository : ExtRepository, IRepository<FormaDePagamento>
    {
        public IQueryable<FormaDePagamento> GetAll()
        {
            DB.GetInstance().context.FormasDePagamento.Load();
            return DB.GetInstance().context.FormasDePagamento.Local.AsQueryable().Where(fp => fp.DataExclusao == null).AsQueryable();
        }

        public bool Salvar(FormaDePagamento item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(FormaDePagamento item)
        {
            DB.GetInstance().context.FormasDePagamento.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public FormaDePagamento GetById(int id)
        {
            return DB.GetInstance().context.FormasDePagamento.Find(id);
        }

        public bool Deletar(FormaDePagamento item)
        {
            DB.GetInstance().context.Entry<FormaDePagamento>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }

        public override dynamic GetAllExt()
        {
            return this.GetAll().ToList();
        }

        public override dynamic GetByIdExt(int id)
        {
            return this.GetById(id);
        }
    }
}
