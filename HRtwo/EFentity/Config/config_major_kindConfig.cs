
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class config_major_kindConfig:EntityTypeConfiguration<config_major_kind>
    {
        public config_major_kindConfig()
        {
            this.ToTable(nameof(config_major_kind));
        }
    }
}
