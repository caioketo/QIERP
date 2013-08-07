using QIERPDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using QIERPDatabase.Classes.DTO;
using QIERPDatabase.Classes;

namespace QIERPDatabase.Repositorios
{
    public partial class OrcamentoRepository: IRepository<Orcamento>
    {
        public IQueryable<Orcamento> GetAll()
        {
            DB.GetInstance().context.Orcamentos.Load();
            return DB.GetInstance().context.Orcamentos.Local.AsQueryable();
        }

        public bool Salvar(Orcamento item)
        {
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public bool Inserir(Orcamento item)
        {
            item.Numero = DB.GetInstance().context.GetSequence("sqnOrcamento");
            DB.GetInstance().context.Orcamentos.Add(item);
            DB.GetInstance().context.SaveChanges();
            return true;
        }

        public Orcamento GetById(int id)
        {
            return DB.GetInstance().context.Orcamentos.Find(id);
        }

        public bool Deletar(Orcamento item)
        {
            DB.GetInstance().context.Entry<Orcamento>(item).State = System.Data.EntityState.Modified;
            item.DataExclusao = DateTime.Now;
            return true;
        }

        public DTO_Orcamento GetDTOById(int id)
        {
            Orcamento orc = DB.GetInstance().context.Orcamentos.Find(id);
            return new DTO_Orcamento
            {
                Numero = orc.Numero,
                ClienteNome = orc.ClienteNome,
                VendedorNome = orc.VendedorNome,
                Itens = orc.Itens
            };
        }
    }
}
