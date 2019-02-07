using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
public class Authors : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult featured()
        {
            return View();
        }

    }
}