using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Entity
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019-9-30 9:50:22
    //  文件名：Menu
    //  版本：V1.0.1  
    //  说明： 菜单实例
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class Menu
    {
        /// <summary>
        /// id
        /// </summary>
       public string ObjectID { get; set; }
        /// <summary>
        /// code
        /// </summary>
       public string Code        {get;set;}
        /// <summary>
        /// 是否是系统
        /// </summary>
	   public string IsSystem    {get;set;}
        /// <summary>
        /// 上级code
        /// </summary>
       public string ParentCode  {get;set;}
        /// <summary>
        /// 名称
        /// </summary>
       public string DisplayName {get;set;}
        /// <summary>
        /// 
        /// </summary>
       public string LockedBy    {get;set;}
        /// <summary>
        /// 描述
        /// </summary>
       public string Description {get;set;}
        /// <summary>
        /// 排序键
        /// </summary>
       public string SortKey     {get;set;}
        /// <summary>
        /// 菜单类型
        /// </summary>
       public string NodeType    {get;set;}
        /// <summary>
        /// 是否在新窗口打开
        /// </summary>
       public bool OpenNewWindow { get;set;}
        /// <summary>
        /// 
        /// </summary>
       public string IsInherit   {get;set;}
        /// <summary>
        /// 图标类型
        /// </summary>
       public string IconType    {get;set;}
        /// <summary>
        /// 图标样式
        /// </summary>
       public string IconCss     {get;set;}
        /// <summary>
        /// 图标地址
        /// </summary>
       public string IconUrl     {get;set;}
        /// <summary>
        /// 地址
        /// </summary>
       public string Url         {get;set;}
        /// <summary>
        /// pc端
        /// </summary>
       public string PortalEnable{get;set;}
        /// <summary>
        /// 移动端
        /// </summary>
       public string MobileEnable{get;set;}
        
    }
}
