using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainABConsoleApp
{
    /// <summary>
    /// Shows that when A project uses old nugets (1.0.x) and B uses new nugets (2.0.x) with breaking changes then exception occurs during runtime
    /// because VS just copies the highest version of assemblies to the output. A project then cannot work because nuget assemblies do not contain
    /// expected logic it was build against.
    /// => When using unsigned nuget packages through projects in solution it is always the best approach to use the same version in all projects!!!
    /// </summary>
    class Program
    {
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
            var a = new ClassLibraryA.ClassA();
            a.Test();

            var b = new ClassLibraryB.ClassB();
            b.Test();
        }
    }
}
