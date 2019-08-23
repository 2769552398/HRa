using DAL;
using IBLL;
using IDAL;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace IOC
{
   public class IocCreat
    {
        //1级机构设置
        public static Iconfig_file_first_kindDAL Createconfig_file_first_kindDAL()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_first_kindDAL>("config_file_first_kindDAL");
        }

        public static Iconfig_file_first_kindBLL Createconfig_file_first_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_file_first_kindBLL>("config_file_first_kindBLL");
        }

        //2级机构设置
        public static Iconfig_file_second_kindDAL Createconfig_file_second_kindDAL()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_second_kindDAL>("config_file_second_kindDAL");
        }

        public static Iconfig_file_second_kindBLL Createconfig_file_second_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_file_second_kindBLL>("config_file_second_kindBLL");
        }

        //3级机构设置
        public static Iconfig_file_third_kindDAL Createconfig_file_third_kindDAL()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_file_third_kindDAL>("config_file_third_kindDAL");
        }

        public static Iconfig_file_third_kindBLL Createeconfig_file_third_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_file_third_kindBLL>("config_file_third_kindBLL");
        }

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"E:\结业项目\HRa\HRtwo\HR\Unity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的Unity节点区.Configuration是UnityConfigurationSection的父类,所以要强转转换
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;
        }
    }
}
