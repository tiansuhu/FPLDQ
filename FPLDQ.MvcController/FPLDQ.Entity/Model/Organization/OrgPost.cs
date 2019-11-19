using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-10-10 10:06:20
    //  文件名：OrgPost
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class OrgPost
    {
        public string ObjectID { get; set; }
        public string Code { get; set; }
        public string SuperiorID { get; set; }
        public string JobLevel { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CostCenter { get; set; }
        public string ParentID { get; set; }
        public string ManagerID { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int SortKey { get; set; }
        public int State { get; set; }
        public int Visibility { get; set; }
        public string SourceID { get; set; }
        public string CalendarID { get; set; }
        public string Extend1 { get; set; }
        public string Extend2 { get; set; }
    }
}
