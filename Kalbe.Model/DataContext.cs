using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalbe.Model
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Name=KalbeConn")
        {
            //Database.SetInitializer(new Initializer());
            Database.SetInitializer<DataContext>(null);
        }

        public virtual DbSet<Barang> Barang { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<MasterTransaction> MasterTransaction { get; set; }

        public virtual DbSet<DetailTransaction> DetailTransaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
