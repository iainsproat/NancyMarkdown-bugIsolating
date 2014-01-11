using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy;

namespace BugIsolation
{
    public class MyModule : NancyModule
    {
        public MyModule()
        {
            Get["/"] = parameters =>
                {
                    return View["test"];
                };
        }
    }
}
