using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace FPLDQ.MvcController.Controllers
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-18 14:44:40
    //  文件名：OrganizationController
    //  版本：V1.0.1  
    //  说明： 组织结构操作类
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    [Authorize]
    public class OrganizationController : ControllerBase
    {
        public override string FunctionCode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="userCode">用户代码</param>
        /// <param name="password">用户密码</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public JsonResult LoginIn(string userCode, string password)
        {
            bool loginResult = false;
            object result= new { };
            try
            {
                // 用户名和密码不为空，则使用用户名和密码登录
               
            }
            catch (Exception ex)
            {
               
            }

            // 验证单点登录
            if (this.UserValidator != null) loginResult = true;

            
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
