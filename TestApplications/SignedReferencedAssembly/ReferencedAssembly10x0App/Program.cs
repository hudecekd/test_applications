using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencedAssembly10x0App
{
    class Program
    {
         /// <summary>
         /// Works. Generates binding redirect thanks to AutoGenerateBindingRedirects set to "true". Output App.config contains that redirect.
         /// When AutoGenerateBindingRedirects is set to "false" then it compiles but fails durin runtime because <see cref="ChildClassLibrary1000.ChildClass1000"/>
         /// requires version of BaseClassLibrary 1.0.0 and since binding redirect is not generated exception is thrown.
         /// </summary>
         /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }

        static void Test()
        { 
            var child1 = new ChildClassLibrary1010.ChildClass1010();
            var child2 = new ChildClassLibrary1000.ChildClass1000();

            Console.WriteLine(child1.GetReferencedAssemblyVersion());
            Console.WriteLine(child2.GetReferencedAssemblyVersion());
         
        }
    }
}
