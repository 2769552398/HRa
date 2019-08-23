using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Six
{
    public class config_file_third_kindController : Controller
    {

        Iconfig_file_third_kindBLL ibll = IocCreat.Createeconfig_file_third_kindBLL();
        Iconfig_file_second_kindBLL iblla = IocCreat.Createconfig_file_second_kindBLL();
        Iconfig_file_first_kindBLL ibllb = IocCreat.Createconfig_file_first_kindBLL();

        //首页
        public ActionResult third_kind()
        {
            return View();
        }

        //查询全部
        public ActionResult Select()
        {
            List<config_file_third_kindModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }


        //新增
        public ActionResult third_kind_register()
        {
            //如果添加失败
            config_file_third_kindModel t = new config_file_third_kindModel();
            t.third_kind_id = ibll.Maxthird_kind_id().ToString();
            ViewData.Model = t;
            FillDrop();
            FillDrop2();
            //FillDrop3();
            return View();
        }


        // POST: config_file_third_kind/Create
        [HttpPost]
        public ActionResult third_kind_register(config_file_third_kindModel t)
        {
            string first_kind_id = t.first_kind_id;
            string second_kind_id = t.second_kind_id;
            config_file_first_kindModel f1 = ibllb.SelectById2(first_kind_id);
            config_file_second_kindModel f2 = iblla.SelectById2(second_kind_id);
            config_file_third_kindModel t2 = new config_file_third_kindModel()
            {
                first_kind_id = f1.first_kind_id,
                first_kind_name = f1.first_kind_name,
                second_kind_id = f2.second_kind_id,
                second_kind_name = f2.second_kind_name,
                third_kind_id = t.third_kind_id,
                third_kind_name = t.third_kind_name,
                third_kind_is_retail = t.third_kind_is_retail,
                third_kind_sale_id = t.third_kind_sale_id

            };
            if (ibll.Add(t2) > 0)
            {
                return Content("ok");
            }
            else
            {
                return View(t);
            }
        }


        //修改显示
        // GET: config_file_third_kind/Edit/5
        public ActionResult third_kind_change(int id)
        {
            config_file_third_kindModel s1 = ibll.SelectById(id);
            ViewData.Model = s1;
            FillDrop();
            return View();
        }

        //修改
        [HttpPost]
        public ActionResult third_kind_change(config_file_third_kindModel t)
        {
            if (ibll.Update(t) > 0)
            {
                //同一个控制器,只要写Action名,不同控制器要写Action名,控制器名
                return Content("ok");
            }
            else
            {
                return Content("nook");
            }
        }

        public ActionResult SelectByfirst_kind_id()
        {
            string id = Request["fid"];
            List<config_file_second_kindModel> c = iblla.SelectById3(id);
            return Content(JsonConvert.SerializeObject(c));
        }


        //删除
        public ActionResult Del(int id)
        {
            config_file_third_kindModel f1 = new config_file_third_kindModel()
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


        //是否为零售店   下拉框
        private void FillDrop()
        {
            List<SelectListItem> list = new List<SelectListItem> {
                     new SelectListItem { Text = "是", Value = "是",Selected = true},
                      new SelectListItem { Text = "否", Value = "否" }
                  };
            ViewBag.dtr = list;
        }


        //1级机构下拉框
        private void FillDrop2()
        {
            //下拉狂选项集合
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_file_first_kindModel> dt = ibllb.Select();
            //将数据循环赋值
            foreach (config_file_first_kindModel item in dt)
            {
                int s = Convert.ToInt32(item.first_kind_id);
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.first_kind_name,
                    Value = s.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dtr1 = list;
        }

        //2级机构下拉框
        private void FillDrop3()
        {
            //下拉狂选项集合
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_file_second_kindModel> dt = iblla.Select();
            //将数据循环赋值
            foreach (config_file_second_kindModel item in dt)
            {
                int s = Convert.ToInt32(item.second_kind_id);
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.second_kind_name,
                    Value = s.ToString()
                };
                list.Add(sl);
            }
            ViewBag.dtr2 = list;
        }

    }
}