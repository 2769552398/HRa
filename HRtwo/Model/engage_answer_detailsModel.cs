using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_answer_detailsModel
    {
        public System.Int16 Id { get; set; }
        public System.String answer_number { get; set; }
        public System.Int16 subject_id { get; set; }
        public System.String answer { get; set; }
    }
}
