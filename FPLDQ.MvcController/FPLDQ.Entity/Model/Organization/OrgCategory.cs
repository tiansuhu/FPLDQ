using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-10-10 10:04:00
    //  文件名：OrgCategory
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class OrgCategory
    {
        public string  ObjectID {get;set;}
        public string Code { get; set; }
	    public string DisplayName { get; set; }
	    public string Description { get; set; }
    }
}
