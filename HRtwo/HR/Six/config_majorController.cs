using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using IOC;
using Newtonsoft.Json;
using System.Data;

namespace HR.Six
{
    public class config_majorController : Controller
    {
        Iconfig_majorBLL ibll = IocCreat.Createconfig_majorBLL();
        Iconfig_major_kindBLL iblld = IocCreat.Createconfig_major_kindBLL();
        /// <summary>
        /// 职位设置
        /// </summary>
        /// <returns></returns>
        // GET: config_major
        public ActionResult major()
        {
            return View();
        }
        //查询
        public ActionResult Select()
        {
            List<config_majorModel> list = ibll.Select();
            return Content(JsonConvert.SerializeObject(list));
        }

        //新增
        [HttpGet]
        public ActionResult major_add()
        {
            config_majorModel p = new config_majorModel();
            p.major_id = ibll.MaxId().ToString();
            ViewData.Model = p;
            Fill();
            return View();
        }
        [HttpPost]
        public ActionResult major_add(config_majorModel cm)
        {
            if (ModelState.IsValid)
            {
                string id = cm.major_kind_id;
                // DataTable dt = ibll.selectByIds(id);
                //string name = dt.Rows[0]["major_kind_name"].ToString();
                string name = ibll.selectByIds(id);
                config_majorModel cmm = new config_majorModel
                {
                    major_kind_id=cm.major_kind_id,
                    major_kind_name=name,
                    major_id=cm.major_id,
                    major_name=cm.major_name,
                    test_amount=0
                };
                if (ibll.Add(cmm) > 0)
                {
                    return Content("ok");
                }
                else
                {
                    return View(cmm);
                }
            }
            else
            {
                return View();
            }
        }

        //绑定下拉框
        private void Fill()
        {
            //下拉框选项集合
            List<SelectListItem> list = new List<SelectListItem>();
            List<config_major_kindModel> dt = iblld.Select();
            //将数据循环赋值
            foreach (config_major_kindModel item in dt)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Text = item.major_kind_name,
                    Value = item.major_kind_id.ToString()
                };
                list.Add(sl);
            }
            
            ViewBag.dtr = list;
        }
        //删除
        public ActionResult Del(int id)
        {
            config_majorModel p1 = new config_majorModel()
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