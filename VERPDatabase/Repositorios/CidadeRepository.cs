using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class CidadeRepository : ExtRepository, IRepository<Cidade>
    {
        public IQueryable<Cidade> GetAll()
        {
            return DB.GetInstance().context.Cidades.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(Cidade item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Cidade item)
        {
            DB.GetInstance().context.Cidades.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Cidade GetById(int id)
        {
            return DB.GetInstance().context.Cidades.Find(id);
        }

        public bool Deletar(Cidade item)
        {
            DB.GetInstance().context.Entry<Cidade>(item).State = System.Data.EntityState.Modified;
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
            return this.Inserir(objeto as Cidade);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Cidade);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Cidades
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
