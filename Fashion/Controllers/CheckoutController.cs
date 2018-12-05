using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace karl.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}