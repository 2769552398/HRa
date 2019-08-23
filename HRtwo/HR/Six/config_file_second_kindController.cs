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
    /// 二级机构设置   
    /// </summary>
    public class config_file_second_kindController : Controller
    {
        Iconfig_file_second_kindBLL ibll = IocCreat.Createconfig_file_second_kindBLL();
        Iconfig_file_first_kindBLL iblla = IocCreat.Createconfig_file_first_kindBLL();
        Iconfig_file_third_kindBLL ibllb = IocCreat.Createeconfig_file_third_kindBLL();
        // GET: config_file_second_kind


        //查询全部
        public ActionResult second_kind()
        {
            return View();
        }


        //查询全部
        public ActionResult Select()
        {
            List<config_file_second_kindModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        //修改显示
        public ActionResult second_kind_change(int id)
        {
            config_file_second_kindModel s1 = ibll.SelectById(id);
            ViewData.Model = s1;
            return View();
        }


        //修改
        [HttpPost]
        public ActionResult second_kind_change(config_file_second_kindModel t)
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

        //删除
        public ActionResult Del(int id)
        {
            config_file_second_kindModel c = ibll.SelectById(id);
            List<config_file_third_kindModel> c1 = ibllb.SelectById2(c.second_kind_id);
            if (c1.Count==0)
            {
                config_file_second_kindModel f1 = new config_file_second_kindModel()
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


        //新增
        [HttpGet]
        public ActionResult second_kind_register()
        {
            //如果添加失败
            config_file_second_kindModel t = new config_file_second_kindModel();
            t.second_kind_id = ibll.Maxsecond_kind_id().ToString();
            ViewData.Model = t;
            FillDrop();
            return View();
        }


        //新增
        [HttpPost]
        public ActionResult second_kind_register(config_file_second_kindModel t)
        {
            string first_kind_id =t.first_kind_id;
            config_file_first_kindModel f1 = iblla.SelectById2(first_kind_id);
            config_file_second_kindModel t2 = new config_file_second_kindModel()
            {
                first_kind_id = f1.first_kind_id,
                first_kind_name = f1.first_kind_name,
                second_kind_id =t.second_kind_id,
                second_kind_name =t.second_kind_name,
                second_salary_id =t.second_salary_id,
                second_sale_id =t.second_sale_id
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
       


        //下拉框
        private void FillDrop()
        {
            //下拉狂选项集合
          List<SelectListItem> list = new List<SelectListItem>();
          List<config_file_first_kindModel> dt = iblla.Select();
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
            ViewBag.dtr = list;
        }
    }
}