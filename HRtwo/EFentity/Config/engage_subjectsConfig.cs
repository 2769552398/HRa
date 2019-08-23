
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class engage_subjectsConfig:EntityTypeConfiguration<engage_subjects>
    {
        public engage_subjectsConfig()
        {
            this.ToTable(nameof(engage_subjects));
        }
    }
}
