using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FPLDQ.Data
{
    //==============================================================
    //  作者：tianxy
    //  时间：2019/3/13 11:00:34
    //  文件名：DataHelper
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    
    /// <summary>
    /// 分页查询数据库操作类
    /// </summary>
    public static class DataHelper
    {

        /// <summary>
        /// 时间类型转换成字符串类型
        /// </summary>
        /// <param name="date">需转换的时间类型对象</param>
        /// <returns></returns>
        public static string GetSafeDateTimeFormat(DateTime date)
        {
            return date.ToString(CultureInfo.CurrentCulture.DateTimeFormat.SortableDateTimePattern, CultureInfo.InvariantCulture);
        }

        public static string DateComparerString(int dateComparer)
        {
            switch (dateComparer)
            {
                case -1:
                    {
                        return "<";
                    }
                case 0:
                    {
                        return "=";
                    }
                case 1:
                    {
                        return ">";
                    }
                default:
                    {
                        return "=";
                    }
            }
        }

        /// <summary>
        /// 搜索关键字特殊字符转换
        /// </summary>
        /// <param name="searchString">搜索关键字</param>
        /// <returns></returns>
        public static string CleanSearchString(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return null;

            // Do wild card replacements
            searchString = searchString.Replace("*", "%");

            // Strip any markup characters
            searchString = Globals.StripHtmlXmlTags(searchString);

            // Remove known bad SQL characters
            searchString = Regex.Replace(searchString, "--|;|'|\"", " ", RegexOptions.Compiled | RegexOptions.Multiline);

            // Finally remove any extra spaces from the string
            searchString = Regex.Replace(searchString, " {1,}", " ", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);

            return searchString;
        }

        /// <summary>
        /// 将数据库读出的数据转换为DataTable为型集合
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static DataTable ConverDataReaderToDataTable(IDataReader reader)
        {
            // 检查外部传入的参数
            if (null == reader)
            {
                return null;
            }

            // 实例化一个DataTable
            DataTable dataTable = new DataTable();
            dataTable.Locale = CultureInfo.InvariantCulture;

            int fieldCount = reader.FieldCount;

            // 在表中创建字段
            for (int counter = 0; counter < fieldCount; counter++)
            {
                dataTable.Columns.Add(reader.GetName(counter), reader.GetFieldType(counter));
            }

            dataTable.BeginLoadData();

            object[] values = new object[fieldCount];
            while (reader.Read())
            {
                // 添加行
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }

            // 完成转换并返回
            dataTable.EndLoadData();
            return dataTable;
        }

        /// <summary>
        /// 单独字段更新
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="keyField">执行条件</param>
        /// <param name="sequenceField">更新字段名</param>
        /// <param name="key">条件值</param>
        /// <param name="replaceKey">条件值</param>
        /// <param name="sequence"></param>
        /// <param name="replaceSequence"></param>
        /// <returns></returns>
        public static bool SwapSequence(string table, string keyField, string sequenceField, int key, int replaceKey, int sequence, int replaceSequence)
        {
            string sqlString = string.Format("UPDATE {0} SET {1} = {2} WHERE {3} = {4}", table, sequenceField, replaceSequence, keyField, key);
            sqlString += string.Format(" UPDATE {0} SET {1} = {2} WHERE {3} = {4}", table, sequenceField, sequence, keyField, replaceKey);

            Database database = DatabaseFactory.CreateDatabase();
            DbCommand dbCmd = database.GetSqlStringCommand(sqlString);

            return database.ExecuteNonQuery(dbCmd) > 0;
        }

    }
   
}
