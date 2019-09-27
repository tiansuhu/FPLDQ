using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.MvcController
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-26 14:16:52
    //  文件名：ActionResultEntity
    //  版本：V1.0.1  
    //  说明： Json返回结果的类型
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class ActionResultEntity
    {
        /// <summary>
        /// 返回结果是否正确
        /// </summary>
        public bool Result { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 返回结果消息
        /// </summary>
        public string Message { get; set; }
    }
}
