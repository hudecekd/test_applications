using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryB
{
    public class ClassB
    {
        public Version GetReferencedAssemblyVersion()
        {
            return new NuGetSignedMainClassLibrary.NuGetSignedMainClass().GetReferencedAssemblyVersion();
        }
    }
}
