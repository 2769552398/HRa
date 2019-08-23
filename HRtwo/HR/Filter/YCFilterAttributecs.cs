using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Filter
{
    public class YCFilterAttributecs : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //1.捕获错误信息
            string message = filterContext.Exception.Message;

            //2.把错误信息给控制器的ViewBag
            filterContext.Controller.ViewData["c"] = "系统很忙，请稍后再来";

            //3.写一封邮件给管理员(...)
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error",
                ViewData = filterContext.Controller.ViewData
            };
            //4.告诉系统，不要在处理异常了
            filterContext.ExceptionHandled = true;
        }
    }
}