using FPLDQ.Common;
using FPLDQ.Data;
using FPLDQ.Entity.Organization;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Collections.Generic;

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
            try
            {
                database = DatabaseFactory.CreateDatabase();
            }
            catch (Exception ex)
            {
                Log.WriteDebugLog("用户数据库操作连接失败" + ex.ToString());
            }
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public override bool AddUser(User user)
        {
            try
            {
                //TODO：实现添加用户
            }
            catch (Exception ex)
            {
                Log.WriteDebugLog("添加用户失败:" + ex.ToString());
            }

           
            return true;
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public override bool UpdateUser(User user)
        {
            //TODO:实现更新用户
            throw new NotImplementedException();
        }
        /// <summary>
        /// 批量更新用户
        /// </summary>
        /// <param name="userlist"></param>
        /// <returns></returns>
        public override bool UpdateUsers(List<User> userlist)
        {
            //TODO:实现批量更新用户
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

        public override User GetUserbyCode(string UserCode)
        {
            //TODO:实现通过用户Code获取用户信息
            string sql = "SELECT Objectid,Code,Name,QQ,Email,Password FROM SYS_User  WHERE Code = @userCode";
            System.Data.Common.DbCommand dbCommand = database.GetSqlStringCommand(sql);
            database.AddInParameter(dbCommand, "@userCode", DbType.String, UserCode);

            User currentuser = null;
            using (IDataReader reder = database.ExecuteReader(sql))
            {
                if (reder.Read())
                {
                    currentuser = UserMapping.CreateUserMapping().MappUser(reder);
                }
            }

            return currentuser;

        }
    }
}
