using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetMainClassLibrary
{
    public class NuGetMainClass
    {
        /// <summary>
        /// Version [1.0.0, 2.0.0)
        /// </summary>
        /// <returns></returns>
        //public Version GetReferencedAssemblyVersion()
        //{
        //    return new NuGetDependencyClassLibrary.NuGetDependencyClass().GetAssemblyVersion();
        //}


        /// <summary>
        /// Version [2.0.0, 3.0.0)
        /// </summary>
        /// <returns></returns>
        public string GetFullReferencedAssemblyVersion()
        {
            return new NuGetDependencyClassLibrary.NuGetDependencyClass().GetFullAssemblyVersion();
        }
    }
}
