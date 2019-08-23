
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFentity.Config
{
   public class config_question_second_kindConfig:EntityTypeConfiguration<config_question_second_kind>
    {
        public config_question_second_kindConfig()
        {
            this.ToTable(nameof(config_question_second_kind));
        }
    }
}
