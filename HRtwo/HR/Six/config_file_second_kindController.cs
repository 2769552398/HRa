using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;

namespace HR.Six
{
    public class config_file_second_kindController : Controller
    {
        Iconfig_file_second_kindBLL ibll = IocCreat.Createconfig_file_second_kindBLL();
        // GET: config_file_second_kind
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult second_kind()
        {
            return View();
        }
        public ActionResult Select()
        {
            List<config_file_second_kindModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}