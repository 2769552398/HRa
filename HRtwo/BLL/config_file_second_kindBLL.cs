
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
    public class config_file_second_kindBLL : Iconfig_file_second_kindBLL
    {
        Iconfig_file_second_kindDAL idal = IocCreat.Createconfig_file_second_kindDAL();
        public int Add(config_file_second_kindModel st)
        {
            return idal.Add(st);
        }

        public int Del(config_file_second_kindModel st)
        {
            return idal.Del(st);
        }

        //查询最大值
        public object Maxsecond_kind_id()
        {
            return idal.Maxsecond_kind_id();
        }

        public List<config_file_second_kindModel> Select()
        {
            return idal.Select();
        }

        public config_file_second_kindModel SelectById(int id)
        {
            return idal.SelectById(id);
        }

        public int Update(config_file_second_kindModel st)
        {
            return idal.Update(st);
        }

        //根据id查询用于机构三新增
        public config_file_second_kindModel SelectById2(string id)
        {
            return idal.SelectById2(id);
        }

        public List<config_file_second_kindModel> SelectById3(string id)
        {
            return idal.SelectById3(id);
        }
    }
}
                          
