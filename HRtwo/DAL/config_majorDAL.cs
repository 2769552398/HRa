
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
using System.Data;

namespace DAL
{
    public class config_majorDAL : DaoBase<config_major>, Iconfig_majorDAL
    {
        
        //添加
        public int Add(config_majorModel st)
        {
            config_major st1 = new config_major()
            {
                //需要添加的列
                major_kind_id = st.major_kind_id,
                major_kind_name = st.major_kind_name,
                major_id = st.major_id,
                major_name = st.major_name
            };
            return Add(st1);
        }
        //删除
        public int Del(config_majorModel st)
        {
            config_major st1 = new config_major()
            {
                Id = st.Id
            };
            return Delete(st1);
        }
        //查询
        public List<config_majorModel> Select()
        {
            List<config_major> list = SelectAll();
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel sm = new config_majorModel()
                {
                    //需要查询的列
                    Id=item.Id,
                    major_kind_id=item.major_kind_id,
                    major_kind_name=item.major_kind_name,
                    major_id=item.major_id,
                    major_name=item.major_name
                };
                list2.Add(sm);
            }
            return list2;
        }
        //根据id查询
        public config_majorModel SelectById(int id)
        {
            config_major list = SelectBy(e => e.Id==(id)).FirstOrDefault();
            config_majorModel sm = new config_majorModel()
            {
                Id = list.Id,
                major_kind_id = list.major_kind_id,
                major_kind_name = list.major_kind_name,
                major_id = list.major_id,
                major_name = list.major_name
            };
            return sm;
        }
        //修改
        public int Update(config_majorModel st)
        {
            config_major st1 = new config_major()
            {
                //需要修改的列
            };
            return Update(st1);
        }

        //根据职位
        public List<config_majorModel> SelectById2(string id)
        {
            List<config_major> list = SelectBy(e => e.major_kind_id.Equals(id));
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel sm = new config_majorModel()
                {
                    //需要查询的列
                    Id = item.Id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_id = item.major_id,
                    major_name = item.major_name
                };
                list2.Add(sm);
            }
            return list2;
        }



        //查询最大的编号进行+1
        static MyDbContext db = CreateDbContext();

        private Boolean RemoveHoldingEntityInContext(config_major entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<config_major>();
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
            var result = Convert.ToInt32(db.config_major.Select(e => e.major_id).Max());
            return result + 1;
        }

        public string selectByIds(object id)
        {
            string sql = string.Format("select [major_kind_name] from [dbo].[config_major_kind] where [major_kind_id]='{0}'", id);
            return DBHelper.SelectSinger(sql).ToString();
        }
    }
}
