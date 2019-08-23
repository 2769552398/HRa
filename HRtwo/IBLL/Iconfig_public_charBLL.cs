
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface Iconfig_public_charBLL
    {
        int Add(config_public_charModel st);
        int Del(config_public_charModel st);
        int Update(config_public_charModel st);
        List<config_public_charModel> Select();
        config_public_charModel SelectById(int id);
        List<config_public_charModel> SelectByName(config_public_charModel st);
    }
}
                           
