
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface Iconfig_file_second_kindDAL
    {
        int Add(config_file_second_kindModel st);
        int Del(config_file_second_kindModel st);
        int Update(config_file_second_kindModel st);
        List<config_file_second_kindModel> Select();
        config_file_second_kindModel SelectById(int id);

        object Maxsecond_kind_id();
        //����id��ѯ
        config_file_second_kindModel SelectById2(string id);

        //����id��ѯ,���ڻ���3��ɾ��
        List<config_file_second_kindModel> SelectById3(string id);
    }
}

