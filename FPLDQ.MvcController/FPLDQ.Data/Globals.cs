using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Xsl;

namespace FPLDQ.Data
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 11:04:14
    //  文件名：Globals
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public static class Globals
    {
        /// <summary>
        /// 当前请求端的IP地址
        /// </summary>
        static public string IPAddress
        {
            get
            {
                string userIP;

                HttpRequest Request = HttpContext.Current.Request;
                // 如果使用代理，获取真实IP
                if (string.IsNullOrEmpty(Request.ServerVariables["HTTP_X_FORWARDED_FOR"]))
                    userIP = Request.ServerVariables["REMOTE_ADDR"];
                else
                    userIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(userIP))
                    userIP = Request.UserHostAddress;

                return userIP;
            }
        }
       
    }
}
