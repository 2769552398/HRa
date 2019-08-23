
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;
using Model;
using IOC;
using System.Data;

namespace BLL
{
    public class config_majorBLL : Iconfig_majorBLL
    {
        Iconfig_majorDAL idal = IocCreat.Createconfig_majorDAL();
        public int Add(config_majorModel st)
        {
            return idal.Add(st);
        }

        public int Del(config_majorModel st)
        {
            return idal.Del(st);
        }

        public object MaxId()
        {
            return idal.MaxId();
        }

        public List<config_majorModel> Select()
        {
            return idal.Select();
        }


        public config_majorModel SelectById(int id)
        {
            return idal.SelectById(id);
        }

        public List<config_majorModel> SelectById2(string id)
        {
            return idal.SelectById2(id);
        }

        public int Update(config_majorModel st)
        {
            return idal.Update(st);
        }

        public string selectByIds(object id)
        {
            return idal.selectByIds(id);
        }
    }
}
                          
