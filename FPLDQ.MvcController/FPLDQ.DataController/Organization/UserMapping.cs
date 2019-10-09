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
        public User drMappUser(DataRow dr)
        {
            User u = new User();
            try
            {
                u.ObjectID = dr["Objectid"] + string.Empty;
                u.Code = dr["Code"] + string.Empty;
                u.Name = dr["Name"] + string.Empty;
                u.QQ = dr["QQ"] + string.Empty;
                u.Email = dr["Email"] + string.Empty;
                u.Password = dr["Password"] + string.Empty;

                return u;
            }
            catch (Exception ex)
            {
                //TODO:记录当前的错误日志
                Log.WriteDebugLog("用户登录失败:"+ex.ToString());
                return null;
            }
        }

    }
}
