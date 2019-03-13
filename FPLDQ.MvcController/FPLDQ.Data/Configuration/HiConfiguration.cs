using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Xml;
using System.Globalization;

namespace FPLDQ.Data
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 10:22:07
    //  文件名：HiConfiguration
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class HiConfiguration
    {
    }

    /// <summary>
    /// 提供程序
    /// </summary>
    public class Provider
    {
        string name;
        string providerType;
        NameValueCollection providerAttributes = new NameValueCollection();

        /// <summary>
        /// 初始化提供程序
        /// </summary>
        /// <param name="attributes"></param>
        public Provider(XmlAttributeCollection attributes)
        {
            if (attributes != null)
            {
                // Set the name of the provider
                //
                name = attributes["name"].Value;

                // Set the type of the provider
                //
                providerType = attributes["type"].Value;

                // Store all the attributes in the attributes bucket
                //
                foreach (XmlAttribute attribute in attributes)
                {
                    if ((attribute.Name != "name") && (attribute.Name != "type"))
                        providerAttributes.Add(attribute.Name, attribute.Value);
                }
            }
        }

        /// <summary>
        /// 提供程序的名称
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// 提供程序的类型
        /// </summary>
        public string Type
        {
            get { return providerType; }
        }

        /// <summary>
        /// 提供程序的属性集
        /// </summary>
        public NameValueCollection Attributes
        {
            get { return providerAttributes; }
        }

    }
}
