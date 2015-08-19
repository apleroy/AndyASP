using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AndyASP.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello";
            return View(); 
        }
		
		public string Welcome(string name, int numTimes = 1) {
            return "Hello " + name + ", NumTimes is: " + numTimes;
        }
    }
}
