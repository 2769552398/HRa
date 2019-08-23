
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;
using Model;
using IOC;

namespace BLL
{
    public class config_public_charBLL : Iconfig_public_charBLL
    {
        Iconfig_public_charDAL idal = IocCreat.Createconfig_public_charDAL();
        public int Add(config_public_charModel st)
        {
            return idal.Add(st);
        }

        public int Del(config_public_charModel st)
        {
            return idal.Del(st);
        }

        public List<config_public_charModel> Select()
        {
            return idal.Select();
        }

        public config_public_charModel SelectById(int id)
        {
            return idal.SelectById(id);
        }

        public List<config_public_charModel> SelectByName(config_public_charModel st)
        {
            return idal.SelectByName(st);
        }

        public int Update(config_public_charModel st)
        {
            return idal.Update(st);
        }
    }
}
                          
