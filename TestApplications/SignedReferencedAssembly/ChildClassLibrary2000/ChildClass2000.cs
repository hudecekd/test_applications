using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildClassLibrary2000
{
    public class ChildClass2000
    {
        public string GetReferencedAssemblyVersion()
        {
            return new BaseClassLibrary.BaseClass().GetFullAssemblyVersion();
        }
    }
}
