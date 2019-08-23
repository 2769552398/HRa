using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;

namespace EFentity
{
   public class MyDbContext:DbContext
    {
        public MyDbContext() : base("name=sql")
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<config_file_first_kind> config_file_first_kinds { get; set; }
        public DbSet<config_file_second_kind> config_file_second_kinds { get; set; }
        public DbSet<config_file_third_kind> config_file_third_kinds { get; set; }
    }
}
