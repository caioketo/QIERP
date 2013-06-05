using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class PessoaRepository : ExtRepository, IRepository<Pessoa>
    {
        public IQueryable<Pessoa> GetAll()
        {
            return DB.GetInstance().context.Pessoas.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(Pessoa item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Pessoa item)
        {
            DB.GetInstance().context.Pessoas.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Pessoa GetById(int id)
        {
            return DB.GetInstance().context.Pessoas.Find(id);
        }

        public bool Deletar(Pessoa item)
        {
            DB.GetInstance().context.Entry<Pessoa>(item).State = System.Data.EntityState.Modified;
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
            return this.GetAll().Where(p => p.Documento.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as Pessoa);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Pessoa);
        }
    }
}
