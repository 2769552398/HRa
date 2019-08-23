
using System.Text;
using System.Threading.Tasks;
using EFentity;
using IDAL;
using Model;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Data.Entity.Infrastructure;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class config_major_kindDAL : DaoBase<config_major_kind>, Iconfig_major_kindDAL
    {
        /// <summary>
        /// 职位分类设置
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        //添加
        public int Add(config_major_kindModel st)
        {
            config_major_kind st1 = new config_major_kind()
            {
                //需要添加的列
                major_kind_id=st.major_kind_id,
                major_kind_name=st.major_kind_name
            };
            return Add(st1);
        }

        //删除
        public int Del(config_major_kindModel st)
        {
            config_major_kind st1 = new config_major_kind()
            {
                Id=st.Id
            };
            return Delete(st1);
        }

        //查询最大的编号进行+1
        static MyDbContext db = CreateDbContext();

        private Boolean RemoveHoldingEntityInContext(config_major_kind entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<config_major_kind>();
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
        
        public object MaxId()
        {
            var result = Convert.ToInt32(db.config_major_kind.Select(e => e.major_kind_id).Max());
            return result + 1;
        }

        //查询
        public List<config_major_kindModel> Select()
        {
            List<config_major_kind> list = SelectAll();
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel sm = new config_major_kindModel()
                {
                    //需要查询的列
                    Id=item.Id,
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name
                };
                list2.Add(sm);
            }
            return list2;
        }
        //根据id查询
        public config_major_kindModel SelectById(int id)
        {
            config_major_kind list = SelectBy(e => e.Id==(id)).FirstOrDefault();
            config_major_kindModel sm = new config_major_kindModel()
            {
                //需要查询的列
                Id = list.Id,
                major_kind_id = list.major_kind_id,
                major_kind_name = list.major_kind_name
            };
            return sm;
        }
        //修改
        public int Update(config_major_kindModel st)
        {
            config_major_kind st1 = new config_major_kind()
            {
                //需要修改的列
            };
            return Update(st1);
        }
    }
}
