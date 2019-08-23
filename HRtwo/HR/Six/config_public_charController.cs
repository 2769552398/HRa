using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System.Data;
using EFentity;

namespace HR.Six
{
    public class config_public_charController : Controller
    {
        Iconfig_public_charBLL ibll = IocCreat.Createconfig_public_charBLL();
        /// <summary>
        /// 公共字段设置表
        /// </summary>
        /// <returns></returns>
        // GET: config_public_char

        //职称设置
        public ActionResult profession_design()
        {
            return View();
        }
        public ActionResult Select()
        {
            //List<config_public_charModel> list = ibll.Select();
            //return Content(JsonConvert.SerializeObject(list));
            config_public_charModel cm = new config_public_charModel()
            {
                attribute_kind = "职称"
            };
            List<config_public_charModel> list = ibll.SelectByName(cm);
            return Content(JsonConvert.SerializeObject(list));

        }
        
        //职称设置删除
        public ActionResult Del(int id)
        {
            config_public_charModel p1 = new config_public_charModel()
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


        /// <summary>
        /// 公共属性设置
        /// </summary>
        /// <returns></returns>
        public ActionResult public_char()
        {
            return View();
        }
        //查询
        public ActionResult SelectAll()
        {
            List<config_public_charModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        //新增
        [HttpGet]
        public ActionResult public_char_add()
        {
            config_public_charModel p = new config_public_charModel();
            ViewData.Model = p;
            //Fill();
            return View();
        }
        [HttpPost]
        public ActionResult public_char_add(config_public_charModel pc)
        {
            if (ModelState.IsValid)
            {
                if (ibll.Add(pc) > 0)
                {
                    return Content("ok");
                }
                else
                {
                    return View(pc);
                }
            }
            else
            {
                return View();
            }
        }
        //绑定下拉框
        //private void Fill()
        //{
        //    //下拉框选项集合
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    List<config_public_charModel> dt = ibll.Select();
        //    //将数据循环赋值
        //    foreach (config_public_charModel item in dt)
        //    {
        //        SelectListItem sl = new SelectListItem()
        //        {
        //            Text = item.attribute_kind,
        //            Value = item.Id.ToString()
        //        };
        //        list.Add(sl);
        //    }
        //    ViewBag.dtr = list;
        //}



        /// <summary>
        /// 酬薪项目设置
        /// </summary>
        /// <returns></returns>
        public ActionResult salary_item()
        {
            return View();
        }
        //查询
        public ActionResult salary_itemSelect()
        {
            config_public_charModel cm = new config_public_charModel()
            {
                attribute_kind = "薪酬设置"
            };
            List<config_public_charModel> list = ibll.SelectByName(cm);
            return Content(JsonConvert.SerializeObject(list));
        }

        //新增
        [HttpGet]
        public ActionResult salary_item_register()
        {
            config_public_charModel p = new config_public_charModel();
            ViewData.Model = p;
            return View();
        }
        [HttpPost]
        public ActionResult salary_item_register(config_public_charModel pc)
        {
            if (ModelState.IsValid)
            {
                if (ibll.Add(pc) > 0)
                {
                    return Content("ok");
                }
                else
                {
                    return View(pc);
                }
            }
            else
            {
                return View();
            }
        }

        //删除
        public ActionResult salary_itemDel(int id)
        {
            config_public_charModel p1 = new config_public_charModel()
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
    }
}