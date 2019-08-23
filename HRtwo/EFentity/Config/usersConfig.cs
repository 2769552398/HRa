
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class usersConfig:EntityTypeConfiguration<users>
    {
        public usersConfig()
        {
            this.ToTable(nameof(users));
        }
    }
}
