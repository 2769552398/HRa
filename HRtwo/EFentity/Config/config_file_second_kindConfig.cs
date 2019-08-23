
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class config_file_second_kindConfig:EntityTypeConfiguration<config_file_second_kind>
    {
        public config_file_second_kindConfig()
        {
            this.ToTable(nameof(config_file_second_kind));
        }
    }
}
