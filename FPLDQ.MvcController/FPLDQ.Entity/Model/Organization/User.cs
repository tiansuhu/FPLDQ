using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity.Organization
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-18 14:54:00
    //  文件名：User
    //  版本：V1.0.1  
    //  说明： 组织用户实体类
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class User : Unit
    {
        /// <summary>
        /// 用户代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Appellation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EmployeeNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeRank { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SecretaryID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EntryDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DepartureDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ServiceState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PrivacyLevel { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// 头像id
        /// </summary>
        public string ImageID { get; set; }
        /// <summary>
        /// 头像地址
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 银行省份
        /// </summary>
        public string BankProvince { get; set; }
        /// <summary>
        /// 银行市
        /// </summary>
        public string BankCity { get; set; }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 银行账号
        /// </summary>
        public string BankAccount { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 微信账号
        /// </summary>
        public string WeChatAccount { get; set; }
        /// <summary>
        /// 钉钉账号
        /// </summary>
        public string DingTalkAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DingTalkID { get; set; }
        /// <summary>
        /// 办公电话
        /// </summary>
        public string OfficePhone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        public string RTX { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ { get; set; }
        /// <summary>
        /// 飞信
        /// </summary>
        public string Skype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FacsimileTelephoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PostOfficeBox { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// 是否是系统管理员
        /// </summary>
        public int IsAdministrator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsConsoleUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsSystemUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IsVirtualUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RelationUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int DoLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SID { get; set; }
        public int MobileType { get; set; }
        public string JPushID { get; set; }
        public string MobileToken { get; set; }
        public int NotifyType { get; set; }
        public string DefaultLanguage { get; set; }
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
