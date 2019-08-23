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
        //一级机构
        public DbSet<config_file_first_kind> config_file_first_kind { get; set; }
        //二级机构
        public DbSet<config_file_second_kind> config_file_second_kind { get; set; }
        //三级机构
        public DbSet<config_file_third_kind> config_file_third_kind { get; set; }
        //公共字段属性
        public DbSet<config_public_char> config_public_char { get; set; }
        //职位分类设置
        public DbSet<config_major_kind> config_major_kind { get; set; }
        //职位设置
        public DbSet<config_major> config_major { get; set; }
    }
}
