using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotoSaleSite.Models;

namespace MotoSaleSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //comment
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
