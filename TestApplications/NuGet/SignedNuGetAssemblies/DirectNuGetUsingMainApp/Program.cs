using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectNuGetUsingMainApp
{
    class Program
    {
        /// <summary>
        /// When signed assemblies are used in nuget we can see that when:
        /// 1. we install <see cref="NuGetSignedMainClassLibrary" /> of version 1.0.0 which has dependency to <see cref="NuGetSignedDependencyClassLibrary"/> version 1.0.x
        /// 2. and we update that depenency nuget to version 1.0.1 (patch) then
        /// 3. VS generates binding redirect directly into source App.Config.
        /// In another example which used only signed projects and referenced them binding redirects were generated to OUPUT App.Config instead!!!
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
            var obj = new NuGetSignedMainClassLibrary.NuGetSignedMainClass();
            var v = obj.GetReferencedAssemblyVersion();
            Console.WriteLine(v);
        }
    }
}
