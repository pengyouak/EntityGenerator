// ================================================================================
// File: code.cs
// Desc: ��[code]��ʵ����
//  ��ʵ����ͨ���������ɹ��ߣ�EntityGenerator���Զ����ɡ�
// Called by:  EntityGenerator 
//               
// Auth: �Ƿ�
// Date: 2018��04��23��
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
    /// ��[code]��ʵ����
    /// </summary>
    public class code
    {
        #region ��Ա���������캯��
        private System.String _strTableName;
        private System.String _code;
        private System.Int32 _id;

        /// <summary>
        /// ��ʼ���� code ����ʵ����
        /// </summary>
        public code()
        {
            _strTableName="code";
        }
        #endregion

        #region �ֶ�����
        /// <summary>
        /// ��ȡʵ�����Ӧ�����ݿ������
        /// </summary>
        public System.String TableName
        {
            get
            {
                return _strTableName;
            }
        }

        /// <summary>
        /// ����code
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
