using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_exam_detailsModel
    {
        public System.Int16 Id { get; set; }
        public System.String exam_number { get; set; }
        public System.String first_kind_id { get; set; }
        public System.String first_kind_name { get; set; }
        public System.String second_kind_id { get; set; }
        public System.String second_kind_name { get; set; }
        public System.Int16 question_amount { get; set; }
    }
}
