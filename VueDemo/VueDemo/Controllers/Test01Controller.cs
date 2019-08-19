using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VueDemo.Controllers
{
    public class Test01Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult T1()
        {
            return View();
        }

        public IActionResult T2()
        {
            return View();
        }
    }
}