
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class major_changeConfig:EntityTypeConfiguration<major_change>
    {
        public major_changeConfig()
        {
            this.ToTable(nameof(major_change));
        }
    }
}
