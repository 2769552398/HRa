
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class engage_exam_detailsConfig:EntityTypeConfiguration<engage_exam_details>
    {
        public engage_exam_detailsConfig()
        {
            this.ToTable(nameof(engage_exam_details));
        }
    }
}
