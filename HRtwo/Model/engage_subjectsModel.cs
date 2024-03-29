using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_subjectsModel
    {
        public System.Int16 Id { get; set; }
        public System.String first_kind_id { get; set; }
        public System.String first_kind_name { get; set; }
        public System.String second_kind_id { get; set; }
        public System.String second_kind_name { get; set; }
        public System.String register { get; set; }
        public System.DateTime regist_time { get; set; }
        public System.String derivation { get; set; }
        public System.String content { get; set; }
        public System.String key_a { get; set; }
        public System.String key_b { get; set; }
        public System.String key_c { get; set; }
        public System.String key_d { get; set; }
        public System.String key_e { get; set; }
        public System.String correct_key { get; set; }
        public System.String changer { get; set; }
        public System.DateTime change_time { get; set; }
    }
}
