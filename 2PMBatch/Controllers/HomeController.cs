using _2PMBatch.DB_connect_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2PMBatch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
         {
            suryaEntities tblobj = new suryaEntities();
            var res = tblobj.tbl_reg.ToList();
            return View(res);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}