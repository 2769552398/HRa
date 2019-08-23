
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class engage_answer_detailsConfig:EntityTypeConfiguration<engage_answer_details>
    {
        public engage_answer_detailsConfig()
        {
            this.ToTable(nameof(engage_answer_details));
        }
    }
}
