
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
        int Add(config_file_third_kindModel st);
        int Del(config_file_third_kindModel st);
        int Update(config_file_third_kindModel st);
        List<config_file_third_kindModel> Select();
        config_file_third_kindModel SelectById(int id);

        //求最大值
        object Maxthird_kind_id();

        //根据机构2的编号查询,用于机构2的删除
        List<config_file_third_kindModel> SelectById2(string id);
    }
}

