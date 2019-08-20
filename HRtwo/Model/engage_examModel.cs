using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_examModel
    {
        public System.Int16 Id { get; set; }
        public System.String exam_number { get; set; }
        public System.String major_kind_id { get; set; }
        public System.String major_kind_name { get; set; }
        public System.String major_id { get; set; }
        public System.String major_name { get; set; }
        public System.String register { get; set; }
        public System.DateTime regist_time { get; set; }
        public System.Int16 limite_time { get; set; }
    }
}
