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
    /// <summary>
    /// 一级机构表
    /// </summary>
    public class config_file_first_kindController : Controller
    {
        Iconfig_file_first_kindBLL ibll = IocCreat.Createconfig_file_first_kindBLL();
        Iconfig_file_second_kindBLL iblla = IocCreat.Createconfig_file_second_kindBLL();
        // GET: config_file_first_kind
        //一级机构设置
        public ActionResult first_kind()
        {
            return View();
        }
        //查询
        public ActionResult Select()
        {
            List<config_file_first_kindModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }
        
        //新增
        public ActionResult first_kind_register()
        {
            config_file_first_kindModel t = new config_file_first_kindModel();
            t.first_kind_id = ibll.Maxfirst_kind_id().ToString();
            ViewData.Model = t;
            return View();
        }
        [HttpPost]
        public ActionResult first_kind_register(config_file_first_kindModel t)
        {
            if (ModelState.IsValid)
            {
                if (ibll.Add(t) > 0)
                {
                    return Content("ok");
                }
                else
                {
                    return View(t);
                }
            }
            else
            {
                return View();
            }
        }

        //删除
        public ActionResult Del(int id)
        {
            config_file_first_kindModel c = ibll.SelectById(id);
            List<config_file_second_kindModel> c1 = iblla.SelectById3(c.first_kind_id);
            if (c1.Count == 0)
            {
                config_file_first_kindModel f1 = new config_file_first_kindModel()
                {
                    Id = Convert.ToInt16(id)
                };
                if (ibll.Del(f1) > 0)
                {
                    return Content("ok");
                }
                else
                {
                    return Content("nook");
                }
            }
            else
            {
                return Content("nook");
            }
        }
        [HttpGet]
        //修改显示
        public ActionResult first_kind_change(int id)
        {
            config_file_first_kindModel f1 = ibll.SelectById(id);
            ViewData.Model = f1;
            return View();
        }
        [HttpPost]
        public ActionResult first_kind_change(config_file_first_kindModel st)
        {
            if (ibll.Update(st) > 0)
            {
                return Content("ok");
            }else
            {
                return Content("nook");
            }
        }
    }
}