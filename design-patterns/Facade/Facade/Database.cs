using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;

namespace Facade
{
    internal class Database
    {
        private Database() { }

        public static NameValueCollection GetProperties(string dbname)
        {
            var filename = dbname + ".txt";
            var prop = new NameValueCollection();
            try
            {
                using (var sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var strs = line.Split('=');
                        prop.Add(strs[0], strs[1]);
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Warning: " + filename + " is not found.");
            }
            return prop;
        }
    }
}
