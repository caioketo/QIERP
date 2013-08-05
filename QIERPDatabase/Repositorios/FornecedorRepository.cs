using QIERPDatabase;
using QIERPDatabase.Classes;
using QIERPDatabase.Repositorios;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase.Repositorios
{
    public class FornecedorRepository : ExtRepository, IRepository<Fornecedor>
    {
        public IQueryable<Fornecedor> GetAll()
        {
            DB.GetInstance().context.Fornecedores.Load();
            return DB.GetInstance().context.Fornecedores.Local.AsQueryable().Where(f => f.DataExclusao == null).AsQueryable();
        }

        public bool Salvar(Fornecedor item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Fornecedor item)
        {
            DB.GetInstance().context.Fornecedores.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Fornecedor GetById(int id)
        {
            return DB.GetInstance().context.Fornecedores.Find(id);
        }

        public bool Deletar(Fornecedor item)
        {
            DB.GetInstance().context.Entry<Fornecedor>(item).State = System.Data.EntityState.Modified;
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
            return this.GetAll().Where(p => p.Pessoa.Nome.ToUpper().Equals(text.ToUpper())).FirstOrDefault();
        }

        public override bool Inserir(object objeto)
        {
            return this.Inserir(objeto as Fornecedor);
        }

        public override bool Salvar(object objeto)
        {
            return this.Salvar(objeto as Fornecedor);
        }

        public override List<int> GetIds()
        {
            var ids = from e in DB.GetInstance().context.Fornecedores
                      where e.DataExclusao == null
                      select e.Id;
            return ids.ToList();
        }

        public override dynamic GetFields(string field)
        {
            if (field.Equals("Pessoa_Id"))
            {
                var fields = from e in DB.GetInstance().context.Fornecedores
                             where e.DataExclusao == null
                             select e.Pessoa.Id;
                return fields.ToList();
            }
            else
            {
                return null;
            }
        }

        public Fornecedor GetByPessoa(Pessoa pessoa)
        {
            if (pessoa.Id == -1)
            {
                return null;
            }
            Fornecedor fornecedor = this.GetAll().Where(f => f.Pessoa == pessoa).FirstOrDefault();
            return fornecedor;
        }
    }
}
