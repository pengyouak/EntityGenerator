using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityGenerator.Entity
{
    class KeyCodeInfo
    {
        public string Key { get; set; }
        public string ColorStr { get; set; }
        public bool UseRegex { get; set; }

        public override string ToString()
        {
            return Key;
        }
    }
}
