
using System.Text;
using System.Threading.Tasks;
using EFentity;
using IDAL;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class config_file_first_kindDAL : DaoBase<config_file_first_kind>, Iconfig_file_first_kindDAL
    {
        //添加
        public int Add(config_file_first_kindModel st)
        {
            config_file_first_kind st1 = new config_file_first_kind()
            {
                //需要添加的列
              

            };
            return Add(st1);
        }
        //删除
        public int Del(config_file_first_kindModel st)
        {
            config_file_first_kind st1 = new config_file_first_kind()
            {
                Id = st.Id
            };
            return Delete(st1);
        }
        //查询
        public List<config_file_first_kindModel> Select()
        {
            List<config_file_first_kind> list = SelectAll();
            List<config_file_first_kindModel> list2 = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind item in list)
            {
                config_file_first_kindModel sm = new config_file_first_kindModel()
                {
                    //需要查询的列
                    Id=item.Id,
                    first_kind_id=item.first_kind_id,
                    first_kind_name=item.first_kind_name,
                    first_kind_salary_id=item.first_kind_salary_id,
                    first_kind_sale_id=item.first_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }
        //根据id查询
        public config_file_first_kindModel SelectById(int id)
        {
            config_file_first_kind list = SelectBy(e => e.Id==(id)).FirstOrDefault();
            config_file_first_kindModel sm = new config_file_first_kindModel()
            {
                //需要查询的列
                Id=list.Id,
                first_kind_id=list.first_kind_id,
                first_kind_name=list.first_kind_name,
                first_kind_salary_id=list.first_kind_salary_id,
                first_kind_sale_id=list.first_kind_sale_id
            };
            return sm;
        }
        //修改
        public int Update(config_file_first_kindModel st)
        {
            config_file_first_kind st1 = new config_file_first_kind()
            {
                //需要修改的列
                Id=st.Id,
                first_kind_id=st.first_kind_id,
                first_kind_name=st.first_kind_name,
                first_kind_salary_id=st.first_kind_salary_id,
                first_kind_sale_id=st.first_kind_sale_id
            };
            return Update(st1);
        }
    }
}
