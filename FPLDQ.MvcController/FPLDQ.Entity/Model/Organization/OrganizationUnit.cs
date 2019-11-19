using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity.Organization
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-10-9 11:14:26
    //  文件名：OrganizationUnit
    //  版本：V1.0.1  
    //  说明： 组织单位实体类
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class OrganizationUnit : Unit
    {
        /// <summary>
        /// 微信id
        /// </summary>
        public int WeChatID { get; set; }
        /// <summary>
        /// 钉钉id
        /// </summary>
        public int DingTalkID { get; set; }
        /// <summary>
        /// 流程代码
        /// </summary>
        public string WorkflowCode { get; set; }
        /// <summary>
        /// 分类代码
        /// </summary>
        public string CategoryCode { get; set; }
        /// <summary>
        /// 是否是根组织
        /// </summary>
        public int IsRootUnit { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CostCenter { get; set; }
        /// <summary>
        /// 上级id
        /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        /// 组织经理id
        /// </summary>
        public string ManagerID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// 最近修改时间
        /// </summary>
        public DateTime ModifiedTime { get; set; }
        /// <summary>
        /// 排序键
        /// </summary>
        public int SortKey { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 可见类型
        /// </summary>
        public int Visibility { get; set; }
        /// <summary>
        /// 源id
        /// </summary>
        public string SourceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CalendarID { get; set; }
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public string Extend1 { get; set; }
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string Extend2 { get; set; }
    }
}
