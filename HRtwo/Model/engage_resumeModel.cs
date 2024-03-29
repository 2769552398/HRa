using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_resumeModel
    {
        public System.Int16 Id { get; set; }
        public System.String human_name { get; set; }
        public System.String engage_type { get; set; }
        public System.String human_address { get; set; }
        public System.String human_postcode { get; set; }
        public System.String human_major_kind_id { get; set; }
        public System.String human_major_kind_name { get; set; }
        public System.String human_major_id { get; set; }
        public System.String human_major_name { get; set; }
        public System.String human_telephone { get; set; }
        public System.String human_homephone { get; set; }
        public System.String human_mobilephone { get; set; }
        public System.String human_email { get; set; }
        public System.String human_hobby { get; set; }
        public System.String human_specility { get; set; }
        public System.String human_sex { get; set; }
        public System.String human_religion { get; set; }
        public System.String human_party { get; set; }
        public System.String human_nationality { get; set; }
        public System.String human_race { get; set; }
        public System.DateTime human_birthday { get; set; }
        public System.Int16 human_age { get; set; }
        public System.String human_educated_degree { get; set; }
        public System.Int16 human_educated_years { get; set; }
        public System.String human_educated_major { get; set; }
        public System.String human_college { get; set; }
        public System.String human_idcard { get; set; }
        public System.String human_birthplace { get; set; }
        public System.Decimal demand_salary_standard { get; set; }
        public System.String human_history_records { get; set; }
        public System.String remark { get; set; }
        public System.String recomandation { get; set; }
        public System.String human_picture { get; set; }
        public System.String attachment_name { get; set; }
        public System.Int16 check_status { get; set; }
        public System.String register { get; set; }
        public System.DateTime regist_time { get; set; }
        public System.String checker { get; set; }
        public System.DateTime check_time { get; set; }
        public System.Int16 interview_status { get; set; }
        public System.Double total_points { get; set; }
        public System.Int16 test_amount { get; set; }
        public System.String test_checker { get; set; }
        public System.DateTime test_check_time { get; set; }
        public System.String pass_register { get; set; }
        public System.DateTime pass_regist_time { get; set; }
        public System.String pass_checker { get; set; }
        public System.DateTime pass_check_time { get; set; }
        public System.Int16 pass_check_status { get; set; }
        public System.String pass_checkComment { get; set; }
        public System.String pass_passComment { get; set; }
    }
}
