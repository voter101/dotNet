using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace _3._1._10
{
    class Reader
    {
        public string read(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = String.Format("_3._1._10.Resources.{0}.txt", name);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
