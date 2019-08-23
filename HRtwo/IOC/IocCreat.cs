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

        //职称设置
        public static Iconfig_public_charDAL Createconfig_public_charDAL()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_public_charDAL>("config_public_charDAL");
        }

        public static Iconfig_public_charBLL Createconfig_public_charBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }

        //职位分类设置
        public static Iconfig_major_kindDAL Createconfig_major_kindDAL()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_major_kindDAL>("config_major_kindDAL");
        }

        public static Iconfig_major_kindBLL Createconfig_major_kindBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_major_kindBLL>("config_major_kindBLL");
        }


        //职位设置
        public static Iconfig_majorDAL Createconfig_majorDAL()
        {
            UnityContainer ioc = CreatIoc("containerOne");
            return ioc.Resolve<config_majorDAL>("config_majorDAL");
        }

        public static Iconfig_majorBLL Createconfig_majorBLL()
        {
            UnityContainer ioc = CreatIoc("containerTwo");
            return ioc.Resolve<Iconfig_majorBLL>("config_majorBLL");
        }

        private static UnityContainer CreatIoc(string name)
        {
            UnityContainer ioc = new UnityContainer();
            //生成文件(Unity.config)对象
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\NET\MQQ\HRa\HRtwo\HR\Unity.config";
            //生成配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            //读取配置对象的Unity节点区.Configuration是UnityConfigurationSection的父类,所以要强转转换
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, name);
            return ioc;
        }
    }
}
