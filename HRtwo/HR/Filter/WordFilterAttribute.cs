using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace HR.Filter
{
    public class WordFilterAttribute: ActionFilterAttribute
    {
        //UserBLL u = new UserBLL();
        //过滤非法字符，然后用*替换

        //进入action前
       
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //1.获取传过来的值
            string zhi = filterContext.ActionParameters["name"].ToString();

            //2.获取非法字符表中的所有非法字符(从数据库的非法字符表获取)
           // List<string> list = u.Fill();
            
            //3.如果值中包含非法字符，就用*替换
            //foreach (string item in list) {
            //    zhi=zhi.Replace(item, "*");
            //}

            //4. 把替换后的内容重新赋值给传过来的值
            filterContext.ActionParameters["name"] = zhi;

        }
    }
}