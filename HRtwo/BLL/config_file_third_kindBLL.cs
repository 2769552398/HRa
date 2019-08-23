
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
    public class config_file_third_kindBLL : Iconfig_file_third_kindBLL
    {

        Iconfig_file_third_kindDAL idal = IocCreat.Createconfig_file_third_kindDAL();
        public int Add(config_file_third_kindModel st)
        {
            return idal.Add(st);
        }

        public int Del(config_file_third_kindModel st)
        {
            return idal.Del(st);
        }

        public List<config_file_third_kindModel> Select()
        {
            return idal.Select();
        }

        public config_file_third_kindModel SelectById(int id)
        {
            return idal.SelectById(id);
        }

        public int Update(config_file_third_kindModel st)
        {
            return idal.Update(st);
        }

        //�����ֵ
        public object Maxthird_kind_id()
        {
            return idal.Maxthird_kind_id();
        }


        //���ݻ���2�ı�Ų�ѯ,���ڻ���2��ɾ��
        public List<config_file_third_kindModel> SelectById2(string id)
        {
            return idal.SelectById2(id);
        }
    }
}
                          
