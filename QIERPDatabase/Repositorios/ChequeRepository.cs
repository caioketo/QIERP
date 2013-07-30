using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class ChequeRepository : ExtRepository, IRepository<Cheque>
    {
        public IQueryable<Cheque> GetAll()
        {
            return DB.GetInstance().context.Cheques.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(Cheque item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Cheque item)
        {
            DB.GetInstance().context.Cheques.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Cheque GetById(int id)
        {
            return DB.GetInstance().context.Cheques.Find(id);
        }

        public bool Deletar(Cheque item)
        {
            DB.GetInstance().context.Entry<Cheque>(item).State = System.Data.EntityState.Modified;
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

        public override dynamic GetByText(string text)
        {
            return this.GetAll().Where(p => p.Numero.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as Cheque);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Cheque);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Cheques
                      where e.DataExclusao == null
                      select e.Id;
            return ids.ToList();
        }

        public override dynamic GetFields(string field)
        {
            return null;
        }
    }
}
