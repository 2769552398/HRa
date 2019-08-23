
using System.Text;
using System.Threading.Tasks;
using EFentity;
using IDAL;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System;
using System.Data.Entity.Infrastructure;

namespace DAL
{
    public class config_file_first_kindDAL : DaoBase<config_file_first_kind>, Iconfig_file_first_kindDAL
    {

        static MyDbContext db = CreateDbContext();

        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(config_file_first_kind entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<config_file_first_kind>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);

            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);
        }


        private static MyDbContext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbContext;
            if (db == null)
            {
                db = new MyDbContext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }
        //添加
        public int Add(config_file_first_kindModel st)
        {
            config_file_first_kind st1 = new config_file_first_kind()
            {
                //需要添加的列
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id

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
                    Id = item.Id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    first_kind_salary_id = item.first_kind_salary_id,
                    first_kind_sale_id = item.first_kind_sale_id
                };
                list2.Add(sm);
            }
            return list2;
        }
        //根据id查询
        public config_file_first_kindModel SelectById(int id)
        {
            config_file_first_kind list = SelectBy(e => e.Id == (id)).FirstOrDefault();
            config_file_first_kindModel sm = new config_file_first_kindModel()
            {
                //需要查询的列
                Id = list.Id,
                first_kind_id = list.first_kind_id,
                first_kind_name = list.first_kind_name,
                first_kind_salary_id = list.first_kind_salary_id,
                first_kind_sale_id = list.first_kind_sale_id
            };
            return sm;
        }
        //修改
        public int Update(config_file_first_kindModel st)
        {
            config_file_first_kind st1 = new config_file_first_kind()
            {
                //需要修改的列
                Id = st.Id,
                first_kind_id = st.first_kind_id,
                first_kind_name = st.first_kind_name,
                first_kind_salary_id = st.first_kind_salary_id,
                first_kind_sale_id = st.first_kind_sale_id
            };
            return Update(st1);
        }


        //查询最大编号
        public object Maxfirst_kind_id()
        {
            var result = Convert.ToInt32(db.config_file_first_kind.Select(e => e.first_kind_id).Max());
            return result + 1;
        }


        //根据id查询
        public config_file_first_kindModel SelectById2(string id)
        {
            config_file_first_kind list = SelectBy(e => e.first_kind_id.Equals(id)).FirstOrDefault();
            config_file_first_kindModel sm = new config_file_first_kindModel()
            {
                //需要查询的列
                Id = list.Id,
                first_kind_id = list.first_kind_id,
                first_kind_name = list.first_kind_name,
                first_kind_salary_id = list.first_kind_salary_id,
                first_kind_sale_id = list.first_kind_sale_id
            };
            return sm;
        }


    }
}
