
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class salary_standardConfig:EntityTypeConfiguration<salary_standard>
    {
        public salary_standardConfig()
        {
            this.ToTable(nameof(salary_standard));
        }
    }
}
