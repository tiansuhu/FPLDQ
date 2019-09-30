using FPLDQ.Entity;
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
    //  文件名：MenuHelper
    //  版本：V1.0.1  
    //  说明： 菜单操作帮助类
    //  修改者：tianxy
    //  修改说明： 调用方法层
    //==============================================================
    public static class MenuHelper
    {
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool AddUser(Menu node)
        {
            return MenuProvider.Instance().AddFunctionNode(node);
        }
        /// <summary>
        /// 更新菜单
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool UpdateUser(Menu node)
        {
            return MenuProvider.Instance().UpdateFunctionNode(node);
        }
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool DeleteUser(string nodeid)
        {
            return MenuProvider.Instance().DeleteFunctionNode(nodeid);
        }

        /// <summary>
        /// 根据菜单ID获取菜单信息
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static Menu GetUser(string nodeid)
        {
            return MenuProvider.Instance().GetFunctionNode(nodeid);
        }
    }
}
