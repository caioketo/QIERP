using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class CRRepository : ExtRepository, IRepository<ContaReceber>
    {
        public IQueryable<ContaReceber> GetAll()
        {
            return DB.GetInstance().context.CRs.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(ContaReceber item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(ContaReceber item)
        {
            DB.GetInstance().context.CRs.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public ContaReceber GetById(int id)
        {
            return DB.GetInstance().context.CRs.Find(id);
        }

        public bool Deletar(ContaReceber item)
        {
            DB.GetInstance().context.Entry<ContaReceber>(item).State = System.Data.EntityState.Modified;
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
            return this.GetAll().Where(p => p.Descricao.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as ContaReceber);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as ContaReceber);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.CRs
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
