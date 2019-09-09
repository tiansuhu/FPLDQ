using FPLDQ.MvcController.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace FPLDQ.MvcController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-8-30 14:49:09
    //  文件名：ControllerBase
    //  版本：V1.0.1  
    //  说明： Controller基础类
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
   public  abstract class ControllerBase: Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract string FunctionCode { get; }


        public UserValidator _UserValidator = null;
        /// <summary>
        /// 获取当前登录用户
        /// </summary>
        public UserValidator UserValidator
        {
            get
            {
                if (this._UserValidator == null)
                {
                    string message = string.Empty;
                    this._UserValidator = UserValidatorFactory.GetUserValidator(this,"", out message);// Session[Sessions.GetUserValidator()] as UserValidator;
                    // 如果Session用户为空 则跳转到登陆页面
                    if (this._UserValidator == null)
                    {
                        this.RedirectLogin();
                    }
                }
                return this._UserValidator;
            }
        }

        /// <summary>
        /// 跳转到登陆页面
        /// </summary>
        public void RedirectLogin()
        {
           // Response.Redirect("", false);
            RedirectToAction("Index", "Home", false);
        }

    }
}
