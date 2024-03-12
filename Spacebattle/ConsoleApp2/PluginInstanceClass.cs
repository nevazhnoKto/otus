using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class PluginInstanceClass
    {
        public object Plugin { get; set; }

        public string FullName { get; set; }
        public bool IsLoad { get; set; }

        public int RetryCount { get; set; }

        public PluginInstanceClass(object plug, string fullName)
        {
            Plugin = plug;
            FullName = fullName;
        }

    }
}
