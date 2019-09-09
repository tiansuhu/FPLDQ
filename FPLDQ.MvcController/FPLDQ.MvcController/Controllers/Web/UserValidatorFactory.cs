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
            /*

            string tempImagesPath = AppConfig.TempImagesPath;

            // 2.如果 Windows 集成，并且当前 Windows 帐号和 Session 不一致，那么切换用户
            windowsAlias = Controller.User.Identity.Name;
            if (!string.IsNullOrEmpty(windowsAlias))
            {
                if (windowsAlias.IndexOf("|") > -1) windowsAlias = windowsAlias.Substring(windowsAlias.LastIndexOf("|") + 1);
                string windowsAliasNoDomain = windowsAlias;
                if (windowsAlias.IndexOf("\\") > -1)
                {
                    windowsAliasNoDomain = windowsAlias.Substring(windowsAlias.IndexOf("\\") + 1);
                }
                if (userInSession == null || (userInSession.UserCode != windowsAlias && userInSession.UserCode != windowsAliasNoDomain))
                {
                    Dictionary<string, object> settings = AppUtility.Engine.SettingManager.GetSheetSettings();
                    // 切换Windows帐号登录
                    if ((bool)settings[H3.Settings.CustomSetting.Setting_ADLoginNameIncludeDomain])
                    {
                        // 带域帐号的登录
                        userInSession = GetUserValidator(AppUtility.Engine, tempImagesPath, windowsAlias, settings);
                    }
                    if (userInSession == null)
                    {
                        // 不带域帐号的登录
                        userInSession = GetUserValidator(AppUtility.Engine, tempImagesPath, windowsAliasNoDomain, settings);
                    }
                    if (userInSession == null || userInSession.User.State == Organization.State.Inactive)
                    {
                        Message = Configs.Global.ResourceManager.GetString("UserValidatorFactory_User") + windowsAlias + " " + Configs.Global.ResourceManager.GetString("UserValidatorFactory_Mssg");
                        return null;
                    }
                    Controller.Session[Sessions.GetUserValidator()] = userInSession;
                    FormsAuthentication.SetAuthCookie(userInSession.UserCode, false);
                }

                return userInSession;
            }

            // 4.如果非Windows认证，那么检测URL认证帐号信息(此方式得去除)
            urlAlias = Controller.Request.QueryString[SheetEnviroment.Param_LoginName];
            urlAlias = System.Web.HttpUtility.UrlDecode(urlAlias);


            // 5.移动端单点登录 SID、Token、UserCode 进行唯一登录
            string sid = Controller.Request.QueryString[OThinker.H3.Controllers.SheetEnviroment.Param_LoginSID];
            string token = Controller.Request.QueryString[OThinker.H3.Controllers.SheetEnviroment.Param_MobileToken];
            if (!string.IsNullOrEmpty(urlAlias)
                && !string.IsNullOrEmpty(sid)
                && !string.IsNullOrEmpty(token)
                && AppConfig.ConnectionMode == ConnectionStringParser.ConnectionMode.Mono)
            {
                OThinker.Organization.User user = AppUtility.Engine.Organization.GetUserByCode(urlAlias);
                if (user != null)
                {
                    if (sid == user.SID && OThinker.Security.MD5Encryptor.GetMD5(token) == user.MobileToken)
                    {
                        userInSession = GetUserValidator(OThinker.H3.Controllers.AppUtility.Engine, urlAlias);
                        Controller.Session[Sessions.GetUserValidator()] = userInSession;
                        FormsAuthentication.SetAuthCookie(userInSession.UserCode, false);
                    }
                }
            }

            // 6.支持H3的SSO,URL中传入 Token
            token = Controller.Request.QueryString["Token"] + string.Empty;
            string secret = ConfigurationManager.AppSettings["Secret"] + string.Empty;
            if (token != string.Empty && secret != string.Empty)
            {
                string userCode = AppUtility.Engine.SSOManager.GetUserCode(OThinker.H3.Configs.ProductInfo.ProductName, secret, token);
                userInSession = GetUserValidator(OThinker.H3.Controllers.AppUtility.Engine, userCode);
                if (userInSession != null)
                {
                    Controller.Session[Sessions.GetUserValidator()] = userInSession;
                    FormsAuthentication.SetAuthCookie(userInSession.UserCode, false);
                }
            }
            */
            return userInSession;
        }
    }
}
