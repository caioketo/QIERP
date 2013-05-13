using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERPDatabase
{
    public class VerpContext : DbContext
    {
        public VerpContext() : base() { }
        public VerpContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VerpContext>(new DropCreateVERPDatabaseIfModelChanges<VerpContext>());
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe");

            base.OnModelCreating(modelBuilder);
        }
    }
}
