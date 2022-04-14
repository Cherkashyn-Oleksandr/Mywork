using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace FirstTask.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewData["Messages"] = "Hello " + name;
            ViewData["NumTimes"] = NumTimes;
            return View();
        }
    }
}
