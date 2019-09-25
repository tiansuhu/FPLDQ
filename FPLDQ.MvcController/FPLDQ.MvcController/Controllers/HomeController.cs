using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FPLDQ.MvcController
{
    public class HomeController : ControllerBase
    {
        public override string FunctionCode
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public void Index()
        {
            Response.Redirect("~/Index.html");//路由跳转到首页
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