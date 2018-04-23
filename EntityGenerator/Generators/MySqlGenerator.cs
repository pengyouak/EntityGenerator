using EntityGenerator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EntityGenerator.Generators
{
    class MySqlGenerator : DBGenerator
    {
        MySql.Data.MySqlClient.MySqlConnection _conn;
        public MySql.Data.MySqlClient.MySqlConnection Connection
        {
            get { return _conn; }
        }

        /// <summary>
        /// ConnectiongStrings中的数据库链接节点
        /// </summary>
        /// <param name="conName"></param>
        public MySqlGenerator(string conName) : base(conName)
        {
            InitDB();
        }

        protected override void InitDB()
        {
            try
            {
                _conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                _conn.Open();
                DBType = DBType.MySQL;
            }
            catch { DBType = DBType.UnKnown; }
        }

        protected override DataSet GetDataSet(string sql, object[] param = null)
        {
            var com = new MySql.Data.MySqlClient.MySqlCommand(sql, _conn)
            {
                CommandType = CommandType.Text,
            };
            if (param != null && param is MySql.Data.MySqlClient.MySqlParameter[])
                com.Parameters.AddRange((MySql.Data.MySqlClient.MySqlParameter[])param);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataSet ds = new DataSet();
            using (var da = new MySql.Data.MySqlClient.MySqlDataAdapter(com))
            {
                da.Fill(ds);
            }
            return ds;
        }

        protected override DataTable GetDataTable(string sql, object[] param = null)
        {
            var ds = GetDataSet(sql, param);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return default(DataTable);
        }

        /// <summary>
        /// 获取表列表。
        /// </summary>
        /// <returns></returns>
        public override List<string> GetDatabaseNames()
        {
            string sql = $@"
show databases;";
            var result = GetDataTable( sql);
            if (result != null)
                return result.AsEnumerable().OrderBy(x => x["database"].ToString()).Select(x => x["database"].ToString()).ToList();
            return default(List<string>);
        }

        /// <summary>
        /// 获取表列表。
        /// </summary>
        /// <returns></returns>
        public override List<TableInfo> GetTableNames()
        {
            string sql = $@"
select table_catalog, table_schema,table_name,table_type
from information_schema.tables 
where table_schema='{DBName}' and table_type='base table'
order by table_name;
";
            var result = GetDataTable(sql);
            if (result != null)
                return result.AsEnumerable().OrderBy(x => x["table_name"].ToString()).Select(x => new TableInfo {
                    TableCatalog=x["table_catalog"].ToString(),
                    TableSchema=x["table_schema"].ToString(),
                    TableName=x["table_name"].ToString(),
                    TableType=x["table_type"].ToString()
                }).ToList();
            return default(List<TableInfo>);
        }

        public override List<FieldInfo> GetColumnInfo(string tableName)
        {
            string sql = $@"
select column_name, character_maximum_length,table_name,data_type,ordinal_position,is_nullable,column_comment
from information_schema.columns 
where table_schema='{DBName}' and table_name='{tableName}'
order by column_name;
";
            var result = GetDataTable(sql);
            if (result != null)
                return result.AsEnumerable().Select(x => new FieldInfo {
                    Name = x["column_name"].ToString(),
                    CharactorMaximum = long.Parse(x["character_maximum_length"].ToString() == "" ? "0" : x["character_maximum_length"].ToString()),
                    DataType = GetCSharpTypeString(x["data_type"].ToString()),
                    Position = int.Parse(x["ordinal_position"].ToString()),
                    Desc = x["column_comment"].ToString(),
                    NullAble = x["is_nullable"].ToString() == "YES" ? true : false,
                }).ToList();
            return default(List<FieldInfo>);
        }

        /// <summary>
        /// 构造实体类（的字符串）。
        /// </summary>
        /// <param name="strNameSpace">命名空间名称</param>
        /// <param name="strClassName">类名称</param>
        /// <param name="strFilePath">生成类的地址</param>
        /// <returns>返回类的字符串</returns>
        public override string CreateEntity(string tableName, string strNameSpace, string strClassName, string strFilePath) 
        {
            var fields = GetColumnInfo(tableName);
            string result = EntityParse(tableName, strNameSpace, strClassName, fields);
            if (!string.IsNullOrEmpty(strFilePath))
                SaveStrToFile(result, strFilePath);
            return result;
        }
    }
}
