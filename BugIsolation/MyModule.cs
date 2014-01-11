using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Nancy;

namespace BugIsolation
{
    public class MyModule : NancyModule
    {
        public MyModule()
        {
            Get["/"] = parameters =>
                {
                    return View["index"];
                };
            Get["/{FileName}"] = parameters =>
                {
                    return View[parameters.FileName];
                };
        }
    }
}
