using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class salary_standard_detailsModel
    {
        public System.Int16 Id { get; set; }
        public System.String standard_id { get; set; }
        public System.String standard_name { get; set; }
        public System.Int16 item_id { get; set; }
        public System.String item_name { get; set; }
        public System.Decimal salary { get; set; }

    }
}
