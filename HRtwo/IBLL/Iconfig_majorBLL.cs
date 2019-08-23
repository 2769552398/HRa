
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IBLL
{
   public interface Iconfig_majorBLL
    {
        int Add(config_majorModel st);
        int Del(config_majorModel st);
        int Update(config_majorModel st);
        List<config_majorModel> Select();
        config_majorModel SelectById(int id);
        List<config_majorModel> SelectById2(string id);
        object MaxId();
        string selectByIds(object id);
    }
}
                           
