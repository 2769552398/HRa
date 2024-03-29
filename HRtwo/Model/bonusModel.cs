using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class bonusModel
    {
        public System.Int16 Id { get; set; }
        public System.String major_kind_id { get; set; }
        public System.String major_kind_name { get; set; }
        public System.String major_id { get; set; }
        public System.String major_name { get; set; }
        public System.String human_id { get; set; }
        public System.String human_name { get; set; }
        public System.String bonus_item { get; set; }
        public System.Decimal bonus_worth { get; set; }
        public System.String bonus_degree { get; set; }
        public System.String remark { get; set; }
        public System.String register { get; set; }
        public System.String checker { get; set; }
        public System.DateTime regist_time { get; set; }
        public System.DateTime check_time { get; set; }
        public System.Int16 check_status { get; set; }
    }
}
