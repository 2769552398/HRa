
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class engage_examConfig:EntityTypeConfiguration<engage_exam>
    {
        public engage_examConfig()
        {
            this.ToTable(nameof(engage_exam));
        }
    }
}
