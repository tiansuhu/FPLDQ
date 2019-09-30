using FPLDQ.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPLDQ.Entity;

namespace FPLDQ.DataController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-30 10:06:16
    //  文件名：MenuData
    //  版本：V1.0.1  
    //  说明：菜单操作数据库类
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class MenuData: MenuProvider
    {
        private Database database;
        /// <summary>
        /// 构造函数
        /// </summary>
        public MenuData()
        {
            try
            {
                database = DatabaseFactory.CreateDatabase();
            }
            catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public override bool AddFunctionNode(Menu node)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="nodeid"></param>
        /// <returns></returns>
        public override bool DeleteFunctionNode(string nodeid)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 获取菜单
        /// </summary>
        /// <param name="nodeid"></param>
        /// <returns></returns>
        public override Menu GetFunctionNode(string nodeid)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 更新菜单
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public override bool UpdateFunctionNode(Menu node)
        {
            throw new NotImplementedException();
        }
    }
}
