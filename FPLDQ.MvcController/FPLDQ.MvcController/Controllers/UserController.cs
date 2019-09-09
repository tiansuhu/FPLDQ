using FPLDQ.Data;
using FPLDQ.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FPLDQ.MvcController.Controllers
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 14:09:17
    //  文件名：UserController
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
   public class UserController: ControllerBase
    {
        public override string FunctionCode
        {
            get
            {
                return "";
            }
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            /* 验证添加删除功能
            UserModel User = UserHelper.GetUser("");

            bool result = UserHelper.AddUser(new UserModel());

            bool rq = UserHelper.DeleteUser("");

            bool ss = UserHelper.UpdateUser(new UserModel());
            */
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
    }
}
