#define VERSION_2_0_0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetSignedDependencyClassLibrary
{
    public class NuGetSignedDependencyClass
    {
#if !VERSION_2_0_0
        /// <summary>
        /// Method existing only in version 1.0.x.0
        /// </summary>
        /// <returns></returns>
        public Version GetAssemblyVersion()
        {
            var name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
            return name.Version;
        }
#else

        /// <summary>
        /// Method existing only in version 2.0.x.0
        /// </summary>
        /// <returns></returns>
        public string GetFullAssemblyVersion()
        {
            var name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
            return string.Format($"------ {name.Version} ------");
        }
#endif
    }
}
