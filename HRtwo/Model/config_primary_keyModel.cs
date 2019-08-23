using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_primary_keyModel
    {
        public System.Int16 Id { get; set; }
        public System.String primary_key_table { get; set; }
        public System.String primary_key { get; set; }
        public System.String key_name { get; set; }
        public System.Boolean primary_key_status { get; set; }

    }
}
