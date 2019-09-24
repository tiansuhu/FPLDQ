using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FPLDQ.MvcController
{
    
   
    public class AccountController : ControllerBase
    {

        public override string FunctionCode
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
    }

}