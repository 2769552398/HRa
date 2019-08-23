
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class engage_answerConfig:EntityTypeConfiguration<engage_answer>
    {
        public engage_answerConfig()
        {
            this.ToTable(nameof(engage_answer));
        }
    }
}
