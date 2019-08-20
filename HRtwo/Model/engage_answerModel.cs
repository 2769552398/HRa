using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_answerModel
    {
        public System.Int16 Id { get; set; }
        public System.String answer_number { get; set; }
        public System.String exam_number { get; set; }
        public System.Int16 resume_id { get; set; }
        public System.Int16 interview_id { get; set; }
        public System.String human_name { get; set; }
        public System.String human_idcard { get; set; }
        public System.String major_kind_id { get; set; }
        public System.String major_kind_name { get; set; }
        public System.String major_id { get; set; }
        public System.String major_name { get; set; }
        public System.DateTime test_time { get; set; }
        public System.String use_time { get; set; }
        public System.Decimal total_point { get; set; }
    }
}
