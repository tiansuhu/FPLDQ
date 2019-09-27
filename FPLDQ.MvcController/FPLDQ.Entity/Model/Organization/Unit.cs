using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity.Organization
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-26 14:48:30
    //  文件名：Unit
    //  版本：V1.0.1  
    //  说明： 组织单位
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public  class Unit
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 唯一ID
        /// </summary>
        public string ObjectId { get; set; }

        
    }
}
