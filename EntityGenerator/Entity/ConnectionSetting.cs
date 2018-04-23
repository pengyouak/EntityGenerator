using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityGenerator.Entity
{
    class ConnectionSetting
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string Provider { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
