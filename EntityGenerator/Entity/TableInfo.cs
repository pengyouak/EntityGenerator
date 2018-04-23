using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityGenerator.Entity
{
    class TableInfo
    {
        public string TableCatalog { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string TableType { get; set; }

        public override string ToString()
        {
            return TableName;
        }
    }
}
