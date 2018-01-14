using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryC
{
    public class ClassC
    {
        public Version GetReferencedAssemblyVersion()
        {
            return new NuGetSignedMainClassLibraryB.NuGetSignedMainClassB().GetReferencedAssemblyVersion();
        }
    }
}
