
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class engage_interviewConfig:EntityTypeConfiguration<engage_interview>
    {
        public engage_interviewConfig()
        {
            this.ToTable(nameof(engage_interview));
        }
    }
}
