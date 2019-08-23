
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface Iconfig_file_third_kindDAL
    {
        /// <summary>
        /// 三级机构表
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int Add(config_file_third_kindModel st);
        int Del(config_file_third_kindModel st);
        int Update(config_file_third_kindModel st);
        List<config_file_third_kindModel> Select();
        config_file_third_kindModel SelectById(int id);
    }
}

