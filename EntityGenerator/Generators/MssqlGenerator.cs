using EntityGenerator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace EntityGenerator.Generators
{
    class MssqlGenerator: DBGenerator
    {
        System.Data.SqlClient.SqlConnection _conn;
        public System.Data.SqlClient.SqlConnection Connection
        {
            get { return _conn; }
        }

        /// <summary>
        /// ConnectiongStrings中的数据库链接节点
        /// </summary>
        /// <param name="conName"></param>
        public MssqlGenerator(string conName) : base(conName)
        {
            InitDB();
        }

        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        protected override void InitDB()
        {
            try
            {
                _conn = new System.Data.SqlClient.SqlConnection(ConnectionString);
                _conn.Open();
                DBType = DBType.SQLServer;
            }
            catch { DBType = DBType.UnKnown; }
        }

        /// <summary>
        /// 获取dataset
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        protected override DataSet GetDataSet(string sql, object[] param = null)
        {
            var com = new System.Data.SqlClient.SqlCommand(sql, _conn)
            {
                CommandType = CommandType.Text,
            };
            if (param != null&&param is System.Data.SqlClient.SqlParameter[])
                com.Parameters.AddRange((System.Data.SqlClient.SqlParameter[])param);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            DataSet ds = new DataSet();
            using (var da = new System.Data.SqlClient.SqlDataAdapter(com))
            {
                da.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// 获取Datatable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        protected override DataTable GetDataTable(string sql, object[] param = null)
        {
            var ds = GetDataSet(sql, param);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return default(DataTable);
        }

        /// <summary>
        /// 获取数据库名列表。
        /// </summary>
        /// <returns></returns>
        public override List<string> GetDatabaseNames()
        {
            string sql = $@"
use master;
select name 
from sysdatabases;";
            var result = GetDataTable( sql);
            if (result != null)
                return result.AsEnumerable().OrderBy(x => x["name"].ToString()).Select(x => x["name"].ToString()).ToList();
            return default(List<string>);
        }

        /// <summary>
        /// 获取数据表信息列表。
        /// </summary>
        /// <returns></returns>
        public override List<TableInfo> GetTableNames()
        {
            string sql = $@"
-- 查看数据库中所有的表
select table_catalog,table_schema,table_name,table_type 
from {DBName}.information_schema.tables;";
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

        /// <summary>
        /// 获取字段信息
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public override List<FieldInfo> GetColumnInfo(string tableName)
        {
            string sql = $@"
-- 查看数据库中,表的相关字段的属性
select column_name,is_nullable,data_type,ordinal_position,character_maximum_length
from {DBName}.information_schema.columns
where table_name = '{tableName}'";
            var result = GetDataTable(sql);
            if (result != null)
                return result.AsEnumerable().Select(x => new FieldInfo {
                    Name = x["column_name"].ToString(),
                    CharactorMaximum = long.Parse(x["character_maximum_length"].ToString() == "" ? "0" : x["character_maximum_length"].ToString()),
                    DataType = GetCSharpTypeString(x["data_type"].ToString()),
                    Position = int.Parse(x["ordinal_position"].ToString()),
                    NullAble = x["is_nullable"].ToString() == "YES" ? true : false,
                }).ToList();
            return default(List<FieldInfo>);
        }
    }
}
