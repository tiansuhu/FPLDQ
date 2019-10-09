using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-10-9 14:31:09
    //  文件名：FunctionAcl
    //  版本：V1.0.1  
    //  说明： 菜单权限表
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class FunctionAcl
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        public string ObjectID { get; set; }
        /// <summary>
        /// 菜单代码
        /// </summary>
        public string FunctionCode { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int Run { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 是否系统
        /// </summary>
        public int Administrator { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifiedTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
