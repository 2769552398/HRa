
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class config_majorConfig:EntityTypeConfiguration<config_major>
    {
        public config_majorConfig()
        {
            this.ToTable(nameof(config_major));
        }
    }
}
