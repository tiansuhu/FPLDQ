using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPLDQ.Common
{
    /// <summary>
    /// LoggerType 的摘要说明
    /// </summary>
    public enum LoggerType
    {
        /// <summary>
        /// 接口日志 主要记录接口数据等信息
        /// </summary>
        WebServiceLog,
        /// <summary>
        /// 接口异常日志  主要记录接口调用时发生的错误日志
        /// </summary>
        WebServiceErrorLog,
        /// <summary>
        /// 数据日志  主要记录数据库操作信息
        /// </summary>
        DataBaseLog,
        /// <summary>
        /// 数据异常  主要记录连接数据库或数据操作异常日志
        /// </summary>
        DataBaseError,
        /// <summary>
        /// 后台日志  主要记录登录、后台按钮的点击事件。例如部署或者发布流程，修改结点
        /// </summary>
        Debug,
        /// <summary>
        /// 一般错误日志
        /// </summary>
        Error,
        /// <summary>
        /// 一般日志
        /// </summary>
        Info,
    }
}
