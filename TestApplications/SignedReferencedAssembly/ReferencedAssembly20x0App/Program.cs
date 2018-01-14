using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencedAssembly20x0App
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Builds but failes during runtime because 1000 cannot found method because it needs BaseClassLibrary of version 1.0.x.0
             * Version 2.0.0. does not have that method anymore!
             * 
             * Binding redirect is generates the same way as for other project but here we can see that when there are breaking changes and binding redirect
             * is generated automatically for signed assembly than it can cause big problems!!!
             * 
             * Maybe AutoUnifyAssemblyReferences ("AutoUnify") should be set to false to show warning at least during build? "True" seems to hide the error until runtime.
             */
            var child1 = new ChildClassLibrary2000.ChildClass2000();
            var child2 = new ChildClassLibrary1000.ChildClass1000();

            Console.WriteLine(child1.GetReferencedAssemblyVersion());
            Console.WriteLine(child2.GetReferencedAssemblyVersion());
            Console.ReadLine();
        }
    }
}
