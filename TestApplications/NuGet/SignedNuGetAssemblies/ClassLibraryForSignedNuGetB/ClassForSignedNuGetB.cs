using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForSignedNuGetB
{
    public class ClassForSignedNuGetB
    {
        public void Test()
        {
            var obj = new NuGetSignedMainClassLibrary.NuGetSignedMainClass();
            //var v = obj.GetFullReferencedAssemblyVersion();
            var v = obj.GetReferencedAssemblyVersion();
            Console.WriteLine(v);
        }
    }
}
