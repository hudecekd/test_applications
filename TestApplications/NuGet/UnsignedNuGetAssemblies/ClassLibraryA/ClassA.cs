using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryA
{
    public class ClassA
    {
        public void Test()
        {
            var obj = new NuGetMainClassLibrary.NuGetMainClass();
            var v = obj.GetReferencedAssemblyVersion();
        }
    }
}
