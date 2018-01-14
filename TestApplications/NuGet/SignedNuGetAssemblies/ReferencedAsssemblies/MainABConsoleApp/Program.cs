using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainABConsoleApp
{
    class Program
    {
        /// <summary>
        /// This shows weird problem. When L1 and L2 are signed libraries where L2 uses L1 and we have project:
        /// A which uses L2 and version 1.0.0 of L1 and
        /// B which uses L2 and version 1.0.1 of L2 and then
        /// main app which references A and B we can se that after build there is L2 and version 1.0.0 of L1 and no binding redirect is created.
        /// How B can work? It looks actually that we want to use 1.0.1 but msbuild decides that 1.0.0 is enough.
        /// 
        /// Maybe we need L3 which will require L1 of version 1.0.1. Then msbuild should show at least warning or something. Or user 1.0.1 and create binding!
        /// YES: After adding L3 which requires L1 of version 1.0.1 and using that in main app binding redirect is created and added to output app.config.
        /// 
        /// It should be the same for the problem in nuget test projects. If one uses higher patch version of dependent library it still does not have to be used
        /// after build sing msbuild chooses the one it requires instead one we added to class project and want to use by specifying binding redirect. So be carefull!!!
        /// 
        /// Binding redirect analysis:
        /// https://stackoverflow.com/questions/17681432/how-can-i-enable-assembly-binding-logging
        /// c:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\x64\FUSLOGVW.exe
        /// run as administrator.
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
            var a = new ClassLibraryA.ClassA();
            var va = a.GetReferencedAssemblyVersion();
            Console.WriteLine(va);

            var b = new ClassLibraryB.ClassB();
            var vb = b.GetReferencedAssemblyVersion();
            Console.WriteLine(vb);

            var c = new ClassLibraryC.ClassC();
            var vc = c.GetReferencedAssemblyVersion();
            Console.WriteLine(vc);
        }
    }
}
