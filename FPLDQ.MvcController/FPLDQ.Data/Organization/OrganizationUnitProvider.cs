using FPLDQ.Entity.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Data.Organization
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-10-15 9:49:43
    //  文件名：OrganizationUnitProvider
    //  版本：V1.0.1  
    //  说明：组织抽象类 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public abstract class OrganizationUnitProvider
    {
        private static readonly OrganizationUnitProvider _defaultInstance;

        static OrganizationUnitProvider()
        {
            _defaultInstance =
                DataProviders.CreateInstance("FPLDQ.DataController.OrganizationUnitData, FPLDQ.DataController") as
                OrganizationUnitProvider;
        }

        /// <summary>
        /// 返回DistributorProvider实例对象
        /// </summary>
        /// <returns></returns>
        public static OrganizationUnitProvider Instance()
        {
            return _defaultInstance;
        }

        #region 组织操作方法
        /// <summary>
        /// 添加组织
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public abstract bool AddOrganizationUnit(OrganizationUnit unit);

        /// <summary>
        /// 更新组织信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public abstract bool UpdateOrganizationUnit(OrganizationUnit unit);


        /// <summary>
        /// 删除组织
        /// </summary>
        /// <param name="unitid"></param>
        /// <returns></returns>
        public abstract bool DeleteOrganizationUnit(string unitid);
        
        #endregion
    }
}
