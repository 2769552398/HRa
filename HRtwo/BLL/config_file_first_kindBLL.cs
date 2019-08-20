
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
    public class config_file_first_kindBLL : Iconfig_file_first_kindBLL
    {
        Iconfig_file_first_kindDAL idal = IocCreat.Createconfig_file_first_kindDAL();
        public int Add(config_file_first_kindModel st)
        {
            return idal.Add(st);
        }

        public int Del(config_file_first_kindModel st)
        {
            return idal.Del(st);
        }

        public List<config_file_first_kindModel> Select()
        {
            return idal.Select();
        }

        public config_file_first_kindModel SelectById(int id)
        {
            return idal.SelectById(id);
        }

        public int Update(config_file_first_kindModel st)
        {
            return idal.Update(st);
        }
    }
}
                          
