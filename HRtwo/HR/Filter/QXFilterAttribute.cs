using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Filter
{
    public class QXFilterAttribute: ActionFilterAttribute
    {
        //权限过滤器
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //1.获取当前url中的权限
            //控制器
            string controller = filterContext.RouteData.GetRequiredString("controller");
            //action
            string action= filterContext.RouteData.GetRequiredString("action");
            //拼接地址
            string url = "/" + controller + "/" + action;

            //2.根据登录信息(角色ID)获得所有权限信息，已经写死
            List<string> list = new List<string>()
            {
                 "/Text3/Index",
                "/Text3/Login"
            };

            //3.判断登录的权限在表里是否存在，如果不在，就跳转提示页面；否则就继续当前页面的显示
            if (!list.Contains(url))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Ts"
                };
            }

        }
    }
}