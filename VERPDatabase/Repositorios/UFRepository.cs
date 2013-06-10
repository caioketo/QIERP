using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class UFRepository : ExtRepository, IRepository<UF>
    {
        public IQueryable<UF> GetAll()
        {
            return DB.GetInstance().context.UFs.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(UF item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(UF item)
        {
            DB.GetInstance().context.UFs.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public UF GetById(int id)
        {
            return DB.GetInstance().context.UFs.Find(id);
        }

        public bool Deletar(UF item)
        {
            DB.GetInstance().context.Entry<UF>(item).State = System.Data.EntityState.Modified;
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
            return this.Inserir(objeto as UF);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as UF);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.UFs
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
