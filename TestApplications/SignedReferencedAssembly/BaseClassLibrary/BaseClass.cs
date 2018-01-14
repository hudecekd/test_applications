using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassLibrary
{
    public class BaseClass
    {
        /// <summary>
        /// Method existing only in version 1.0.x.0
        /// </summary>
        /// <returns></returns>
        //public Version GetAssemblyVersion()
        //{
        //    var name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
        //    return name.Version;
        //}

        /// <summary>
        /// Method existing only in version 2.0.x.0
        /// </summary>
        /// <returns></returns>
        public string GetFullAssemblyVersion()
        {
            var name = System.Reflection.Assembly.GetExecutingAssembly().GetName();
            return string.Format($"------ {name.Version} ------");
        }
    }
}
