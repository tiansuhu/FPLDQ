using FPLDQ.Data;
using FPLDQ.Entity;
using FPLDQ.Entity.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FPLDQ.Data
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 13:31:27
    //  文件名：UserProvider
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： user访问数据库入口 定义层面
    //==============================================================
    public abstract class UserProvider
    {
        private static readonly UserProvider _defaultInstance;

        static UserProvider()
        {
            _defaultInstance =
                DataProviders.CreateInstance("FPLDQ.DataController.UserData, FPLDQ.DataController") as
                UserProvider;
        }

        /// <summary>
        /// 返回DistributorProvider实例对象
        /// </summary>
        /// <returns></returns>
        public static UserProvider Instance()
        {
            return _defaultInstance;
        }

        #region 用户操作方法
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public abstract bool AddUser(User user);

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public abstract bool UpdateUser(User user);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public abstract bool DeleteUser(string userid);


        /// <summary>
        /// 根据用户ID获取用户信息
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public abstract User GetUser(string UserId);

        /// <summary>
        /// 根据用户Code 获取用户信息
        /// </summary>
        /// <param name="UserCode"></param>
        /// <returns></returns>
        public abstract User GetUserbyCode(string UserCode);
        #endregion
    }
}
