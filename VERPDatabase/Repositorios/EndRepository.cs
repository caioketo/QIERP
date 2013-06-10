using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class EndRepository : ExtRepository, IRepository<Endereco>
    {
        public IQueryable<Endereco> GetAll()
        {
            return DB.GetInstance().context.Enderecos.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(Endereco item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Endereco item)
        {
            DB.GetInstance().context.Enderecos.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Endereco GetById(int id)
        {
            return DB.GetInstance().context.Enderecos.Find(id);
        }

        public bool Deletar(Endereco item)
        {
            DB.GetInstance().context.Entry<Endereco>(item).State = System.Data.EntityState.Modified;
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
            return this.GetAll().Where(p => p.Logradouro.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as Endereco);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Endereco);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Enderecos
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
