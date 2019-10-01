using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_ASSIGNMENT6._2_lyleReicks.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}