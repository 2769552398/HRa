
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface Iconfig_file_second_kindBLL
    {
        int Add(config_file_second_kindModel st);
        int Del(config_file_second_kindModel st);
        int Update(config_file_second_kindModel st);
        List<config_file_second_kindModel> Select();
        config_file_second_kindModel SelectById(int id);
    }
}
                           
