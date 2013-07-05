using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VERPDatabase.Classes;

namespace VERPDatabase.Repositorios
{
    public class NotaRepository : ExtRepository, IRepository<NotaFiscal>
    {
        public IQueryable<NotaFiscal> GetAll()
        {
            return DB.GetInstance().context.Notas.Local.AsQueryable().Where(p => p.DataExclusao == null);
        }

        public bool Salvar(NotaFiscal item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(NotaFiscal item)
        {
            DB.GetInstance().context.Notas.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public NotaFiscal GetById(int id)
        {
            return DB.GetInstance().context.Notas.Find(id);
        }

        public bool Deletar(NotaFiscal item)
        {
            DB.GetInstance().context.Entry<NotaFiscal>(item).State = System.Data.EntityState.Modified;
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
            return this.Inserir(objeto as NotaFiscal);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as NotaFiscal);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Notas
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
