
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class bonusConfig:EntityTypeConfiguration<bonus>
    {
        public bonusConfig()
        {
            this.ToTable(nameof(bonus));
        }
    }
}
