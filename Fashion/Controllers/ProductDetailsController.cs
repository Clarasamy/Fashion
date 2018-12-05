using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace karl.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult productdetails()
        {
            return View();
        }
        public IActionResult cart()
        {
            return View();
        }
    }
}