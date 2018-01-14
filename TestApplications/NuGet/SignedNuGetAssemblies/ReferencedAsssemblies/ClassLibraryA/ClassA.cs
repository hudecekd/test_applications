using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryA
{
    public class ClassA
    {
        public Version GetReferencedAssemblyVersion()
        {
            return new NuGetSignedMainClassLibrary.NuGetSignedMainClass().GetReferencedAssemblyVersion();
        }
    }
}
