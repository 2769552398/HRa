
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface Iconfig_file_first_kindDAL
    {
        /// <summary>
        /// 一级机构表
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        int Add(config_file_first_kindModel st);
        int Del(config_file_first_kindModel st);
        int Update(config_file_first_kindModel st);
        List<config_file_first_kindModel> Select();
        config_file_first_kindModel SelectById(int id);
        //生成编号
        object Maxfirst_kind_id();
        //用于新增更具编号查询
        config_file_first_kindModel SelectById2(string id);
    }
}

