﻿using FPLDQ.Entity;
using FPLDQ.Entity.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Data
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 13:40:10
    //  文件名：UserHelper
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 调用方法层
    //==============================================================
    public static class UserHelper
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool AddUser(User User)
        {
            return UserProvider.Instance().AddUser(User);
        }
        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool UpdateUser(User User)
        {
            return UserProvider.Instance().UpdateUser(User);
        }

        public static bool UpdateUsers(List<User> userlist)
        {
            return UserProvider.Instance().UpdateUsers(userlist);
        }


        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool DeleteUser(string userId)
        {
            return UserProvider.Instance().DeleteUser(userId);
        }

        /// <summary>
        /// 根据用户ID获取用户信息
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static User GetUser(string UserId)
        {
            return UserProvider.Instance().GetUser(UserId);
        }

        /// <summary>
        /// 根据用户Code获取用户信息
        /// </summary>
        /// <param name="userCode">用户Code</param>
        /// <returns></returns>
        public static User GetUserbyCode(string userCode)
        {
            return UserProvider.Instance().GetUserbyCode(userCode);
        }

        

    }
}
