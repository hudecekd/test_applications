using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildClassLibrary1000
{
    public class ChildClass1000
    {
        public Version GetReferencedAssemblyVersion()
        {
            return new BaseClassLibrary.BaseClass().GetAssemblyVersion();
        }
    }
}
