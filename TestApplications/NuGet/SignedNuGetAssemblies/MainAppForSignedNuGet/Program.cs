using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppForSignedNuGet
{
    class Program
    {
        /// <summary>
        /// When A uses nugets and B does not then not binding is needed so nothing is generated to output App.Config.
        /// When dependency nuget is updated to 1.0.1 in B (after we install main nuget 1.0.0 with dependency 1.0.0) project then app.config is generated
        /// in that project and copied to output as AssemblyName.dll.config.
        /// In example where only referenced projects where used no app.config for class project was created. Instead App.Config of exe contained that binding redirect!!!
        /// IMPORTANT: Still if we delete that app.config redirect is still working. Why????? It is somehow ignored!!!
        /// When B is updated to Nuget packages of version 2.0.0. App.config still remains in that project but when main exe project is built
        /// then output App.Config of exe project contains new redirects.
        /// In that case app. fails because A project requires old version 1.x.x with old API!
        /// Still how binding redirecti s being handled in project B during update of nuget with minor changes? If it still works even when we delet that app.config in outuput?????
        /// 
        /// Also after build version 1.0.0 is used instead of version 1.0.1. It think that in case of referenced signed project the highest version was used!
        /// 
        /// Analysis of binding: c:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.1 Tools\x64\FUSLOGVW.exe
        /// Run as administrator!
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
            var a = new ClassLibraryForSignedNuGetA.ClassForSignedNuGetA();
            a.Test();

            var b = new ClassLibraryForSignedNuGetB.ClassForSignedNuGetB();
            b.Test();
        }
    }
}
