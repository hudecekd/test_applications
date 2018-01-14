using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetSignedMainClassLibraryB
{
    public class NuGetSignedMainClassB
    {
        /// <summary>
        /// Version [1.0.0, 2.0.0)
        /// </summary>
        /// <returns></returns>
        public Version GetReferencedAssemblyVersion()
        {
            return new NuGetSignedDependencyClassLibrary.NuGetSignedDependencyClass().GetAssemblyVersion();
        }
    }
}
