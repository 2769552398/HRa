
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
    public class config_major_kindBLL : Iconfig_major_kindBLL
    {
        Iconfig_major_kindDAL idal = IocCreat.Createconfig_major_kindDAL();
        public int Add(config_major_kindModel st)
        {
            return idal.Add(st);
        }

        public int Del(config_major_kindModel st)
        {
            return idal.Del(st);
        }

        public object MaxId()
        {
            return idal.MaxId();
        }

        public List<config_major_kindModel> Select()
        {
            return idal.Select();
        }

        public config_major_kindModel SelectById(int id)
        {
            return idal.SelectById(id);
        }

        public int Update(config_major_kindModel st)
        {
            return idal.Update(st);
        }
    }
}
                          
