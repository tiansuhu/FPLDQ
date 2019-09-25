using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.MvcController.Controllers
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-8-30 14:56:01
    //  文件名：UserValidatorFactory
    //  版本：V1.0.1  
    //  说明： 身份验证类工厂
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class UserValidatorFactory
    {
        public static UserValidator GetUserValidator(System.Web.Mvc.Controller Controller, string PortalRoot, out string Message)
        {

            Message = null;
            string windowsAlias = string.Empty;       // Windows 集成中获取到的帐号
            string urlAlias = string.Empty;           // URL 中获取到的帐号
            UserValidator userInSession = null;   // Session 中的对象

            // 1.取 Session 帐号
            userInSession = Controller.Session[Sessions.GetUserValidator()] as UserValidator;
            try
            {
                urlAlias = Controller.Request.QueryString[SheetEnviroment.Param_LoginName];
            }
            catch { }
            //异步话，这里已经登录成功了
            if (userInSession != null)
            {
                if (string.IsNullOrEmpty(urlAlias) || (!string.IsNullOrEmpty(urlAlias) && userInSession.UserCode == urlAlias))
                {
                    return userInSession;
                }
            }
            return userInSession;
        }
    }
}
