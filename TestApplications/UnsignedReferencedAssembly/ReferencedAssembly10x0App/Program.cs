using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencedAssembly10x0App
{
    class Program
    {
        static void Main(string[] args)
        {
            var child1 = new ChildClassLibrary1010.ChildClass1010();
            var child2 = new ChildClassLibrary1000.ChildClass1000();

            Console.WriteLine(child1.GetReferencedAssemblyVersion());
            Console.WriteLine(child2.GetReferencedAssemblyVersion());
            Console.ReadLine();
        }
    }
}
