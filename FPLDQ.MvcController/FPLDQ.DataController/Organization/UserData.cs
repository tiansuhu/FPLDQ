using FPLDQ.Data;
using FPLDQ.Entity;
using FPLDQ.Entity.Organization;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.DataController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 13:40:21
    //  文件名：UserData
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明：实现用户的sql实现层
    //==============================================================
    public class UserData:UserProvider
    {
        private Database database;
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserData()
        {
            database = DatabaseFactory.CreateDatabase();
        }

        
        public override bool AddUser(User user)
        {
            //TODO：实现添加用户
            return true;
        }

        public override bool UpdateUser(User user)
        {
            //TODO:实现更新用户
            throw new NotImplementedException();
        }

        public override bool DeleteUser(string userid)
        {
            //TODO:实现删除用户
            throw new NotImplementedException();
        }

        public override User GetUser(string UserId)
        {
            //TODO:实现获取用户信息
            throw new NotImplementedException();
        }
    }
}
