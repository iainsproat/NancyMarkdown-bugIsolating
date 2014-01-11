using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy.Hosting.Self;

namespace BugIsolation
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri(@"http://localhost:62259")))
            {
                host.Start();
                Console.ReadKey();
            }
        }
    }
}
