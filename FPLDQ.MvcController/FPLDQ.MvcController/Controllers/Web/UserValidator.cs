using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.MvcController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-8-30 14:52:45
    //  文件名：UserValidator
    //  版本：V1.0.1  
    //  说明： 用户验证
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    [System.Serializable]
    public class UserValidator
    {
        /// <summary>
        /// 用户Code
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户头像地址
        /// </summary>
        public string UserImgPath { get; set; }
        /// <summary>
        /// 用户全名称
        /// </summary>
        public string UserFullName { get; set; }
        /// <summary>
        /// 用户三级单位
        /// </summary>
        public string UserParentUnit { get; set; }
        /// <summary>
        /// 该用户是否是管理员
        /// </summary>
        public bool IsAdmin { get; set; }
        
    }
}
