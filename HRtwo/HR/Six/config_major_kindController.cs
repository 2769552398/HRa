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
    public class config_major_kindController : Controller
    {
        Iconfig_major_kindBLL ibll = IocCreat.Createconfig_major_kindBLL();

        Iconfig_majorBLL iblla = IocCreat.Createconfig_majorBLL();

        /// <summary>
        /// 职位分类设置
        /// </summary>
        /// <returns></returns>
        // GET: config_major_kind
        public ActionResult config_major_kind()
        {
            return View();
        }
        //查询
        public ActionResult Select()
        {
            List<config_major_kindModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        //职位分类设置添加
        [HttpGet]
        public ActionResult major_kind_add()
        {
            config_major_kindModel t = new config_major_kindModel();
            t.major_kind_id = ibll.MaxId().ToString();
            ViewData.Model = t;
            return View();
        }
        [HttpPost]
        public ActionResult major_kind_add(config_major_kindModel t)
        {
            if (ModelState.IsValid)
            {
                if (ibll.Add(t) > 0)
                {
                    return Content("ok");
                }else
                {
                    return View(t);
                }
            }else
            {
                return View();
            }
         
        }

        //删除
        public ActionResult Del(int id)
        {
            config_major_kindModel c = ibll.SelectById(id);
            List<config_majorModel> c2 = iblla.SelectById2(c.major_kind_id);
            if (c2.Count == 0)
            {
                config_major_kindModel p1 = new config_major_kindModel()
                {
                    Id = Convert.ToInt16(id)
                };
                if (ibll.Del(p1) > 0)
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
    }
}