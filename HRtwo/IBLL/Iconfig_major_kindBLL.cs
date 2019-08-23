
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface Iconfig_major_kindBLL
    {
        int Add(config_major_kindModel st);
        int Del(config_major_kindModel st);
        int Update(config_major_kindModel st);
        List<config_major_kindModel> Select();
        config_major_kindModel SelectById(int id);
        object MaxId();
    }
}
                           
