using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Common
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-27 11:53:26
    //  文件名：Log
    //  版本：V1.0.1  
    //  说明： 添加日志记录
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public static class Log
    {
        /// <summary>
        /// 记录错误日志
        /// </summary>
        /// <param name="error"></param>
        public static void WriteErrorLog(string log)
        {
            LogHelper.Error(LoggerType.Error, log);
        }
        /// <summary>
        /// 记录一般日志
        /// </summary>
        /// <param name="log"></param>
        public static void WriteLog(string log)
        {
            LogHelper.Info(LoggerType.Info, log);
        }

        /// <summary>
        /// 记录bug日志
        /// </summary>
        /// <param name="log"></param>
        public static void WriteDebugLog(string log)
        {
            LogHelper.Debug(LoggerType.Debug, log);
        }

        /// <summary>
        /// 记录接口日志
        /// </summary>
        /// <param name="log"></param>
        public static void WriteServiceLog(string log)
        {
            LogHelper.Info(LoggerType.WebServiceLog, log);
        }

    }
}
