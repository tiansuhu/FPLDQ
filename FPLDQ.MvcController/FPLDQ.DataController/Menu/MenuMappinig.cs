using FPLDQ.Common;
using FPLDQ.Entity;
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
    //  时间：2019-9-30 10:07:00
    //  文件名：MenuMappinig
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
   public  class MenuMappinig
    {

        public static MenuMappinig CreateUserMapping()
        {
            MenuMappinig _munemapping = new MenuMappinig();
            return _munemapping;
        }
        /// <summary>
        /// 将dr数据转化成用户实例
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public Menu drMappFunctionNode(DataRow dr)
        {
            Menu m = new Menu();
            try
            {
                m.ObjectID = dr["ObjectID"] + string.Empty;
                m.Code = dr["Code"] + string.Empty;
                m.Description = dr["Description"] + string.Empty;
                m.DisplayName = dr["DisplayName"] + string.Empty;
                m.IconCss = dr["IconCss"] + string.Empty;
                m.IconType = dr["IconType"] + string.Empty;
                m.IconUrl = dr["IconUrl"] + string.Empty;
                m.IsInherit = dr["IsInherit"] + string.Empty;
                m.IsSystem = dr["IsSystem"] + string.Empty;
                m.LockedBy = dr["LockedBy"] + string.Empty;
                m.MobileEnable = dr["MobileEnable"] + string.Empty;
                m.NodeType = dr["NodeType"] + string.Empty;
               // m.OpenNewWindow = dr["OpenNewWindow"] + string.Empty;
                m.ParentCode = dr["ParentCode"] + string.Empty;
                m.PortalEnable = dr["PortalEnable"] + string.Empty;
                m.SortKey = dr["SortKey"] + string.Empty;
                m.Url = dr["Url"] + string.Empty;
                return m;
            }
            catch (Exception ex)
            {
                //TODO:记录当前的错误日志
                Log.WriteDebugLog("菜单转化失败:" + ex.ToString());
                return null;
            }
        }

    }

}
