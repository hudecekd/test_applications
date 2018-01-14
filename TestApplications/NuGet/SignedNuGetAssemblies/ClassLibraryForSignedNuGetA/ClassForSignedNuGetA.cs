using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForSignedNuGetA
{
    public class ClassForSignedNuGetA
    {
        public void Test()
        {
            var obj = new NuGetSignedMainClassLibrary.NuGetSignedMainClass();
            var v = obj.GetReferencedAssemblyVersion();
        }
    }
}
