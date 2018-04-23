using EntityGenerator.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityGenerator.Generators
{
    abstract class DBGenerator
    {
        #region 属性
        public string ConnectionName { get; set; } = string.Empty;
        public string DBName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public DBType DBType = DBType.UnKnown;
        #endregion

        #region 数据库方法，需要在子类重写
        /// <summary>
        /// ConnectiongStrings中的数据库链接节点
        /// </summary>
        /// <param name="conStr"></param>
        protected DBGenerator(string conStr)
        {
            ConnectionString = conStr;
        }

        protected virtual void InitDB()
        {
           
        }

        protected virtual DataSet GetDataSet(string sql, object[] param=null)
        {
            return default(DataSet);
        }

        protected virtual DataTable GetDataTable(string sql, object[] param = null)
        {
            return default(DataTable);
        }

        /// <summary>
        /// 获取数据库列表。
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetDatabaseNames() { return default(List<string>); }

        /// <summary>
        /// 获取数据表列表。
        /// </summary>
        /// <returns></returns>
        public virtual List<TableInfo> GetTableNames() { return default(List<TableInfo>); }

        /// <summary>
        /// 获取表中的列信息
        /// </summary>
        /// <returns></returns>
        public virtual List<FieldInfo> GetColumnInfo(string tableName) { return default(List<FieldInfo>); }
        #endregion

        #region 功能方法
        /// <summary>
        /// 构造实体类（的字符串）。
        /// </summary>
        /// <param name="strNameSpace">命名空间名称</param>
        /// <param name="strClassName">类名称</param>
        /// <param name="strFilePath">生成类的地址</param>
        /// <returns>返回类的字符串</returns>
        public virtual string CreateEntity(string tableName, string strNameSpace, string strClassName, string strFilePath)
        {
            var fields = GetColumnInfo(tableName);
            string result = EntityParse(tableName, strNameSpace, strClassName, fields);
            if (!string.IsNullOrEmpty(strFilePath))
                SaveStrToFile(result, strFilePath);
            return result;
        }

        public virtual string GetCSharpTypeString(string type)
        {
            return  GetCSharpType(type).ToString();
        }

        public virtual Type GetCSharpType(string type)
        {
            switch (type.ToLower())
            {
                case "real":
                    return typeof(Single);
                case "float":
                    return typeof(double);
                case "smallint ":
                    return typeof(Int16);
                case "tinyint":
                    return typeof(byte);
                case "smallint":
                case "mediumint":
                case "int":
                    return typeof(int);
                case "bigint":
                    return typeof(long);
                case "numeric":
                case "decimal":
                case "money":
                    return typeof(decimal);
                case "uniqueidentifier":
                    return typeof(Guid);
                case "bit":
                    return typeof(bool);
                case "enum":
                case "set":
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "mediumtext":
                    return typeof(string);
                case "tinyblob":
                case "blob":
                case "mediumblob":
                case "longblob":
                case "binary":
                case "varbinary":
                case "image":
                    return typeof(byte[]);
                case "datetime":
                case "smalldatetime":
                    return typeof(DateTime);
                case "variant ":
                    return typeof(object);
                default:
                    return typeof(object);
            }
        }

        /// <summary>
        /// 生成实体类。
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strNameSpace">命名空间名称</param>
        /// <param name="strClassName">类名称</param>
        /// <param name="columNames">实体字段名列表</param>
        /// <param name="columDesc">实体字段描述列表</param>
        /// <param name="typeList">字段类型列表</param>
        /// <returns>实体类的代码</returns>
        public virtual string EntityParse(string strTableName,string strNameSpace, string strClassName,List<FieldInfo> fields)
        {
            StringBuilder sb = new StringBuilder();
            //文件头注释
            sb.AppendLine("// ================================================================================");
            sb.AppendLine("// File: "+strClassName+".cs");
            sb.AppendLine("// Desc: 表["+strTableName+"]的实体类");
            sb.AppendLine("//  此实体类通过代码生成工具（EntityGenerator）自动生成。");
            sb.AppendLine("// Called by:  EntityGenerator ");
            sb.AppendLine("//               ");
            sb.AppendLine("// Auth: 星风");
            sb.AppendLine("// Date: " +DateTime.Now.ToString("yyyy年MM月dd日"));
            sb.AppendLine("// ================================================================================");
            sb.AppendLine("// Change History");
            sb.AppendLine("// ================================================================================");
            sb.AppendLine("// 		Date:		Author:				Description:");
            sb.AppendLine("// 		--------	--------			-------------------");
            sb.AppendLine("//    ");
            sb.AppendLine("// ================================================================================");
            sb.AppendLine("// Copyright (C) 2010-2020 ");
            sb.AppendLine("// ================================================================================");

            //Using
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Data;");
            sb.AppendLine();

            //namespace
            sb.AppendLine("namespace " + strNameSpace);
            sb.AppendLine("{");

            //class desc
            sb.AppendLine("    [Serializable]");
            sb.AppendLine("    /// <summary>");
            sb.AppendLine("    /// 表[" + strTableName + "]的实体类");
            sb.AppendLine("    /// </summary>");

            //class
            sb.AppendLine("    public class " + strClassName);
            sb.AppendLine("    {");

            //私有成员、构造函数
            sb.AppendLine("        #region 成员变量、构造函数");
            sb.AppendLine("        private System.String _strTableName;");
            for (int i = 0; i < fields.Count; i++)
            {
                sb.AppendLine("        private " + fields[i].DataType + " _" + fields[i].Name + ";");
            }
            
            sb.AppendLine();
            sb.AppendLine("        /// <summary>");
            sb.AppendLine("        /// 初始化类 " + strClassName + " 的新实例。");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        public " + strClassName + "()");
            sb.AppendLine("        {");
            sb.AppendLine("            _strTableName=\"" + strTableName + "\";");
            sb.AppendLine("        }");
            sb.AppendLine("        #endregion");
            sb.AppendLine();

            //字段属性
            sb.AppendLine("        #region 字段属性");
            sb.AppendLine("        /// <summary>");
            sb.AppendLine("        /// 获取实体类对应的数据库表名。");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        public System.String TableName");
            sb.AppendLine("        {");
            sb.AppendLine("            get");
            sb.AppendLine("            {");
            sb.AppendLine("                return _strTableName;");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
            for (int i = 0; i < fields.Count; i++)
            {
                sb.AppendLine("        /// <summary>");
                sb.AppendLine("        /// " + fields[i].Desc);
                sb.AppendLine("        /// </summary>");
                sb.AppendLine("        public " + fields[i].DataType + " " + fields[i].Name);
                sb.AppendLine("        {");
                sb.AppendLine("            get");
                sb.AppendLine("            {");
                sb.AppendLine("                return" + " _" + fields[i].Name + ";");
                sb.AppendLine("            }");
                sb.AppendLine("            set");
                sb.AppendLine("            {");
                sb.AppendLine("                " + " _" + fields[i].Name + "=value;");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
            }
            sb.AppendLine("        #endregion");

            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        /// <summary>
        /// 保存字符串到文件
        /// </summary>
        /// <param name="str">要保存的字符串</param>
        /// <param name="filePath">文件路径</param>
        public virtual void SaveStrToFile(string str, string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            if (!info.Directory.Exists)
            {
                Directory.CreateDirectory(info.DirectoryName);
            }
            StreamWriter stream =null;
            //保存
            try
            {
                stream = new StreamWriter(filePath, false, Encoding.Default);
                stream.Write(str);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }
            }
        }
        #endregion
    }
}
