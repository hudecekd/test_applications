using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildClassLibrary1010
{
    public class ChildClass1010
    {
        public Version GetReferencedAssemblyVersion()
        {
            return new BaseClassLibrary.BaseClass().GetAssemblyVersion();
        }
    }
}
