using FPLDQ.Data.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FPLDQ.Entity.Organization;

namespace FPLDQ.DataController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-10-30 10:29:56
    //  文件名：OrganizationUnitData
    //  版本：V1.0.1  
    //  说明： 组织操作数据库类型
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class OrganizationUnitData : OrganizationUnitProvider
    {
        /// <summary>
        /// 添加组织
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public override bool AddOrganizationUnit(OrganizationUnit unit)
        {
            //TODO:添加组织
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除组织
        /// </summary>
        /// <param name="unitid"></param>
        /// <returns></returns>
        public override bool DeleteOrganizationUnit(string unitid)
        {
            //TODO:删除组织
            throw new NotImplementedException();
        }
        /// <summary>
        /// 更新组织
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public override bool UpdateOrganizationUnit(OrganizationUnit unit)
        {
            //TODO:更新组织
            throw new NotImplementedException();
        }
    }
}
