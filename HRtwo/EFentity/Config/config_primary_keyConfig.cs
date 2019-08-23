
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class config_primary_keyConfig:EntityTypeConfiguration<config_primary_key>
    {
        public config_primary_keyConfig()
        {
            this.ToTable(nameof(config_primary_key));
        }
    }
}
