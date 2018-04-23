// ================================================================================
// File: code.cs
// Desc: 表[code]的实体类
//  此实体类通过代码生成工具（EntityGenerator）自动生成。
// Called by:  EntityGenerator 
//               
// Auth: 星风
// Date: 2018年04月23日
// ================================================================================
// Change History
// ================================================================================
// 		Date:		Author:				Description:
// 		--------	--------			-------------------
//    
// ================================================================================
// Copyright (C) 2010-2020 
// ================================================================================
using System;
using System.Data;

namespace te
{
    [Serializable]
    /// <summary>
    /// 表[code]的实体类
    /// </summary>
    public class code
    {
        #region 成员变量、构造函数
        private System.String _strTableName;
        private System.String _code;
        private System.Int32 _id;

        /// <summary>
        /// 初始化类 code 的新实例。
        /// </summary>
        public code()
        {
            _strTableName="code";
        }
        #endregion

        #region 字段属性
        /// <summary>
        /// 获取实体类对应的数据库表名。
        /// </summary>
        public System.String TableName
        {
            get
            {
                return _strTableName;
            }
        }

        /// <summary>
        /// 区县code
        /// </summary>
        public System.String code
        {
            get
            {
                return _code;
            }
            set
            {
                 _code=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                 _id=value;
            }
        }
        #endregion
    }
}
