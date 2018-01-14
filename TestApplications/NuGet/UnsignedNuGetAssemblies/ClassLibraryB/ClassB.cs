using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryB
{
    public class ClassB
    {
        public void Test()
        {
            var obj = new NuGetMainClassLibrary.NuGetMainClass();
            var v = obj.GetFullReferencedAssemblyVersion();
        }
    }
}
