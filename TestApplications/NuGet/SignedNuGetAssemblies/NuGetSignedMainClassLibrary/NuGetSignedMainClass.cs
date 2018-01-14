#define VERSION_2_0_0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetSignedMainClassLibrary
{
    public class NuGetSignedMainClass
    {
#if !VERSION_2_0_0
        /// <summary>
        /// Version [1.0.0, 2.0.0)
        /// </summary>
        /// <returns></returns>
        public Version GetReferencedAssemblyVersion()
        {
           return new NuGetSignedDependencyClassLibrary.NuGetSignedDependencyClass().GetAssemblyVersion();
        }
#else

        /// <summary>
        /// Version [2.0.0, 3.0.0)
        /// </summary>
        /// <returns></returns>
        public string GetFullReferencedAssemblyVersion()
        {
            return new NuGetSignedDependencyClassLibrary.NuGetSignedDependencyClass().GetFullAssemblyVersion();
        }
#endif
    }
}
