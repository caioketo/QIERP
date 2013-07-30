using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class CPRepository : ExtRepository, IRepository<ContaPagar>
    {
        public IQueryable<ContaPagar> GetAll()
        {
            return DB.GetInstance().context.CPs.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(ContaPagar item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(ContaPagar item)
        {
            DB.GetInstance().context.CPs.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public ContaPagar GetById(int id)
        {
            return DB.GetInstance().context.CPs.Find(id);
        }

        public bool Deletar(ContaPagar item)
        {
            DB.GetInstance().context.Entry<ContaPagar>(item).State = System.Data.EntityState.Modified;
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
            return this.Inserir(objeto as ContaPagar);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as ContaPagar);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.CPs
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
