using CheckBoxApplivcation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CheckBoxApplivcation.Controllers
{
    public class HomeController : Controller
    {
        private object stringBuilder;

        // GET: Home
        public ActionResult Index()
        {
            TestDBEntities db = new TestDBEntities();
            var data = db.EMPTABLEs.ToList();
            GenderType gt = new GenderType();
            gt.selectedRadio = "";
            gt.employee = data;
            return View(gt);
        }
        //[HttpPost]
        //public ActionResult Index(GenderType gender)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var item in gender.employee)
        //    {
        //        if (item.Gender)
        //        {
        //            sb.Append(item.EmpName+",");
        //        }
        //    }
        //    int lastIndex = sb.ToString().LastIndexOf(",");
        //    sb.Remove(lastIndex, 1);
        //    Session["mydata"] = sb;
        //    return RedirectToAction("Show");
        //}
        [HttpPost]
        public ActionResult Index(GenderType selectgd)
        {
            if (selectgd!=null)
            {
                Session["mydata"] = selectgd.selectedRadio;
            }
            return RedirectToAction("Show");
        }
        public ActionResult Show()
        {
            return View();
        }

        }
}