﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity.Organization
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-18 14:54:00
    //  文件名：User
    //  版本：V1.0.1  
    //  说明： 组织用户实体类
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class User:Unit
    {
        /// <summary>
        /// 用户密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 用户QQ
        /// </summary>
        public string QQ { get; set; }
        /// <summary>
        /// 用户Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string MobilePhone { get; set; }
    }
}
