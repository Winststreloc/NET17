using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
    internal class VersionAttribute: Attribute
    {
        public int Version { get; set; }
        public string Author { get; set; }

        public VersionAttribute(int version)
        {
            Version = version;
        }
    }
}
