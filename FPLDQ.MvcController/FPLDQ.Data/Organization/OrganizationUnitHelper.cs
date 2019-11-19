using FPLDQ.Data.Organization;
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
    //  时间：2019-10-15 9:48:17
    //  文件名：OrganizationUnitHelper
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
   public class OrganizationUnitHelper
    {
        /// <summary>
        /// 添加组织
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static bool AddOrganizationUnit(OrganizationUnit unit ) {
            return OrganizationUnitProvider.Instance().AddOrganizationUnit(unit);
        }

        /// <summary>
        /// 更新组织信息
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static bool UpdateOrganizationUnit(OrganizationUnit unit)
        {
            return OrganizationUnitProvider.Instance().UpdateOrganizationUnit(unit);
        }
    }
}
