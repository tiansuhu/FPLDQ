using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLDQ.Data
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 10:20:19
    //  文件名：DataProviders
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    /// <summary>
    /// 提供数据库实例对象
    /// </summary>
    public sealed class DataProviders
    {

        private DataProviders()
        {
        }

        /// <summary>
        /// Creates an instance of the provider using Activator. This instance should be
        /// cached since it is an expesivie operation
        /// </summary>
        public static object CreateInstance(Provider dataProvider)
        {
            if (null == dataProvider)
            {
                return null;
            }

            //Get the type
            Type type = Type.GetType(dataProvider.Type);

            object newObject = null;
            if (type != null)
            {
                newObject = Activator.CreateInstance(type);
            }

            return newObject;
        }

        /// <summary>
        /// 使用完整类型限定名创建类型实例
        /// </summary>
        /// <param name="typeStr">完整的类型限定名称</param>
        /// <returns></returns>
        public static object CreateInstance(string typeStr)
        {
            if (string.IsNullOrEmpty(typeStr))
                return null;

            try
            {
                return Activator.CreateInstance(Type.GetType(typeStr));
            }
            catch
            {
                return null;
            }
        }

    }
}
