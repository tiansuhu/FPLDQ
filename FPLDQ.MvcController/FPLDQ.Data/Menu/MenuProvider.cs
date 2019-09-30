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
    public abstract class MenuProvider
    {
        private static readonly MenuProvider _defaultInstance;

        static MenuProvider()
        {
            _defaultInstance =
                DataProviders.CreateInstance("FPLDQ.DataController.MenuData, FPLDQ.DataController") as
                MenuProvider;
        }

        /// <summary>
        /// 返回DistributorProvider实例对象
        /// </summary>
        /// <returns></returns>
        public static MenuProvider Instance()
        {
            return _defaultInstance;
        }

        #region 菜单操作方法
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public abstract bool AddFunctionNode(Menu node);

        /// <summary>
        /// 更新菜单信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public abstract bool UpdateFunctionNode(Menu node);

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public abstract bool DeleteFunctionNode(string nodeid);


        /// <summary>
        /// 根据用户ID获取菜单信息
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public abstract Menu GetFunctionNode(string nodeid);

        #endregion
    }
}
