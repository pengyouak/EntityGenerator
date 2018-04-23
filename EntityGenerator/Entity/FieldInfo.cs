using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityGenerator.Entity
{
    [Serializable]
    class FieldInfo
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 是否可以为空
        /// </summary>
        public bool NullAble { get; set; }

        /// <summary>
        /// 字段顺序
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 最大长度
        /// </summary>
        public long CharactorMaximum { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// 字段数据库类型
        /// </summary>
        public System.Data.SqlDbType SqlDbType { get; set; }

        /// <summary>
        /// 字段C#类型
        /// </summary>
        public Type CSharpType { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        public object Tag { get; set; }
    }
}
