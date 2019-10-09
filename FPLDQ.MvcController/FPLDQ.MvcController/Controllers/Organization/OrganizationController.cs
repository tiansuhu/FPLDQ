using FPLDQ.Data;
using FPLDQ.Entity.Organization;
using FPLDQ.MvcController.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace FPLDQ.MvcController
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
    //[Authorize]
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
            ActionResultEntity result = new ActionResultEntity();
            try
            {
                // 用户名和密码不为空，则使用用户名和密码登录
                if (string.IsNullOrEmpty(userCode) || string.IsNullOrEmpty(password))
                {
                    result.Result = false;
                    if (string.IsNullOrEmpty(userCode))
                        result.Message += "用户账号为空";

                    if (string.IsNullOrEmpty(password))
                        result.Message += "用户密码为空";

                    return Json(result, JsonRequestBehavior.AllowGet);
                }

                User loginuser=  UserHelper.GetUserbyCode(userCode);
                if (loginuser == null)
                {
                    result.Result = false;
                    result.Message = "当前用户不存在";
                    return Json(result, JsonRequestBehavior.AllowGet);
                }

                if (loginuser.Password == password)//如果用户密码一致 登录成功
                {
                    UserValidator uservalidator = UserValidatorFactory.GetUserValidatorByUser(loginuser);
                    this.Session[Sessions.GetUserValidator()] = uservalidator;

                    result.Result = true;
                    result.Message = "验证成功";
                }
                else
                {
                    result.Result = false;
                    result.Message = "用户密码不正确";
                }
                return Json(result, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                result.Result = false;
                result.Message = ex.ToString();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// 获取当前用户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public JsonResult GetCurrentUser()
        {
            ActionResultEntity result = new ActionResultEntity();
            try
            {
                UserValidator currentuser = this.UserValidator ;
                if (currentuser != null)
                {
                    result.Result = true;
                    result.Message = "";
                    result.Data = currentuser;
                }
                else
                {
                    result.Result = false;
                }
                    
            }
            catch
            {
                result.Result = false;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }



    }
}
