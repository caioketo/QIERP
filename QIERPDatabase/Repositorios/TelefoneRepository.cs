using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes;

namespace QIERPDatabase.Repositorios
{
    public class TelefoneRepository : ExtRepository, IRepository<Telefone>
    {
        public IQueryable<Telefone> GetAll()
        {
            return DB.GetInstance().context.Telefones.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(Telefone item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Telefone item)
        {
            DB.GetInstance().context.Telefones.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Telefone GetById(int id)
        {
            return DB.GetInstance().context.Telefones.Find(id);
        }

        public bool Deletar(Telefone item)
        {
            DB.GetInstance().context.Entry<Telefone>(item).State = System.Data.EntityState.Modified;
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
            return this.Inserir(objeto as Telefone);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Telefone);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Telefones
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
