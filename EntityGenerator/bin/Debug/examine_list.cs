// ================================================================================
// File: examine_list.cs
// Desc: 表[examine_list]的实体类
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

namespace TEST
{
    [Serializable]
    /// <summary>
    /// 表[examine_list]的实体类
    /// </summary>
    public class examine_list
    {
        #region 成员变量、构造函数
        private System.String _strTableName;
        private System.String _CITY_CODE;
        private System.String _CITY_NAME;
        private System.String _COMMUNITY_CODE;
        private System.String _COMMUNITY_NAME;
        private System.DateTime _CREATE_DATE;
        private System.String _DISTRICT_CODE;
        private System.String _DISTRICT_NAME;
        private System.DateTime _END_DATE;
        private System.String _EXAMINE_LIST_CODE;
        private System.String _EXAMINE_LIST_ID;
        private System.String _EXAMINE_LIST_RULE_ID;
        private System.String _HIN_FACILITY_IDENT;
        private System.String _HOSPITAL_CODE;
        private System.String _HOSPITAL_NAME;
        private System.String _INSTRUCTION_CONTENT;
        private System.String _PHYSICIAN_IDENT;
        private System.String _PHYSICIAN_NAME;
        private System.String _PROVINCE_CODE;
        private System.String _PROVINCE_NAME;
        private System.DateTime _PUBLISH_DATE;
        private System.String _REPORT_SCOPE;
        private System.String _RULE_CATEGORY;
        private System.String _RULE_NAME;
        private System.String _RULE_TYPE;
        private System.Int32 _RX_COUNT;
        private System.DateTime _START_DATE;

        /// <summary>
        /// 初始化类 examine_list 的新实例。
        /// </summary>
        public examine_list()
        {
            _strTableName="examine_list";
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
        /// 
        /// </summary>
        public System.String CITY_CODE
        {
            get
            {
                return _CITY_CODE;
            }
            set
            {
                 _CITY_CODE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String CITY_NAME
        {
            get
            {
                return _CITY_NAME;
            }
            set
            {
                 _CITY_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String COMMUNITY_CODE
        {
            get
            {
                return _COMMUNITY_CODE;
            }
            set
            {
                 _COMMUNITY_CODE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String COMMUNITY_NAME
        {
            get
            {
                return _COMMUNITY_NAME;
            }
            set
            {
                 _COMMUNITY_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CREATE_DATE
        {
            get
            {
                return _CREATE_DATE;
            }
            set
            {
                 _CREATE_DATE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String DISTRICT_CODE
        {
            get
            {
                return _DISTRICT_CODE;
            }
            set
            {
                 _DISTRICT_CODE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String DISTRICT_NAME
        {
            get
            {
                return _DISTRICT_NAME;
            }
            set
            {
                 _DISTRICT_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime END_DATE
        {
            get
            {
                return _END_DATE;
            }
            set
            {
                 _END_DATE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String EXAMINE_LIST_CODE
        {
            get
            {
                return _EXAMINE_LIST_CODE;
            }
            set
            {
                 _EXAMINE_LIST_CODE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String EXAMINE_LIST_ID
        {
            get
            {
                return _EXAMINE_LIST_ID;
            }
            set
            {
                 _EXAMINE_LIST_ID=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String EXAMINE_LIST_RULE_ID
        {
            get
            {
                return _EXAMINE_LIST_RULE_ID;
            }
            set
            {
                 _EXAMINE_LIST_RULE_ID=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String HIN_FACILITY_IDENT
        {
            get
            {
                return _HIN_FACILITY_IDENT;
            }
            set
            {
                 _HIN_FACILITY_IDENT=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String HOSPITAL_CODE
        {
            get
            {
                return _HOSPITAL_CODE;
            }
            set
            {
                 _HOSPITAL_CODE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String HOSPITAL_NAME
        {
            get
            {
                return _HOSPITAL_NAME;
            }
            set
            {
                 _HOSPITAL_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String INSTRUCTION_CONTENT
        {
            get
            {
                return _INSTRUCTION_CONTENT;
            }
            set
            {
                 _INSTRUCTION_CONTENT=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String PHYSICIAN_IDENT
        {
            get
            {
                return _PHYSICIAN_IDENT;
            }
            set
            {
                 _PHYSICIAN_IDENT=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String PHYSICIAN_NAME
        {
            get
            {
                return _PHYSICIAN_NAME;
            }
            set
            {
                 _PHYSICIAN_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String PROVINCE_CODE
        {
            get
            {
                return _PROVINCE_CODE;
            }
            set
            {
                 _PROVINCE_CODE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String PROVINCE_NAME
        {
            get
            {
                return _PROVINCE_NAME;
            }
            set
            {
                 _PROVINCE_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime PUBLISH_DATE
        {
            get
            {
                return _PUBLISH_DATE;
            }
            set
            {
                 _PUBLISH_DATE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String REPORT_SCOPE
        {
            get
            {
                return _REPORT_SCOPE;
            }
            set
            {
                 _REPORT_SCOPE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String RULE_CATEGORY
        {
            get
            {
                return _RULE_CATEGORY;
            }
            set
            {
                 _RULE_CATEGORY=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String RULE_NAME
        {
            get
            {
                return _RULE_NAME;
            }
            set
            {
                 _RULE_NAME=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.String RULE_TYPE
        {
            get
            {
                return _RULE_TYPE;
            }
            set
            {
                 _RULE_TYPE=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 RX_COUNT
        {
            get
            {
                return _RX_COUNT;
            }
            set
            {
                 _RX_COUNT=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime START_DATE
        {
            get
            {
                return _START_DATE;
            }
            set
            {
                 _START_DATE=value;
            }
        }
        #endregion
    }
}
