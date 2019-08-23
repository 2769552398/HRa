
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class salary_standard_detailsConfig:EntityTypeConfiguration<salary_standard_details>
    {
        public salary_standard_detailsConfig()
        {
            this.ToTable(nameof(salary_standard_details));
        }
    }
}
