using FPLDQ.Common;
using FPLDQ.Entity.Organization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.DataController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-26 15:06:59
    //  文件名：UserMapping
    //  版本：V1.0.1  
    //  说明： datatable转实例层
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class UserMapping
    {
        public static UserMapping CreateUserMapping()
        {
            UserMapping _usermapping = new UserMapping();
            return _usermapping;
        }
        /// <summary>
        /// 将dr数据转化成用户实例
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public User MappUser(IDataReader reader)
        {
            if (null == reader)
            {
                Log.WriteDebugLog("当前用户不存在");
                return null;
            }
            User u = new User();
            u.ObjectID = (string)reader["ObjectID"];
            if (reader["Appellation"] != DBNull.Value)
                u.Appellation = (string)reader["Appellation"];
            u.BankAccount = (string)reader["Appellation"];
            //u.BankCity = (DateTime)reader["AddedDate"];
            
            return u;
        }

    }
}
