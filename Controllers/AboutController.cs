using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
public class About : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult history()
        {
            return View();
        }

        public IActionResult location()
        {
            return View();
        }
    }

}