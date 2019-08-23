using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace HR.Filter
{
    public class LoginFilterAttribute: ActionFilterAttribute
    {
        //登录过滤器,判断有没有登录
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Session["user"] == null)
            {
                filterContext.HttpContext.Response.Redirect("/Text3/Login");
            }
        }
    }
}