using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World");
        }
    }

    public class About : Controller
    {

        public IActionResult Index()
        {
            return Content("This is the About controller’s Index action");
        }

        public IActionResult history()
        {
            return Content("This is the About controller’s history action");
        }

        public IActionResult location()
        {
            return Content("This is the About controller’s location action");
        }
    }

    public class Books : Controller
    {

        public IActionResult Index()
        {
            return Content("This is the Books controller’s Index action");
        }

        public IActionResult New()
        {
            return Content("This is the Books controller’s New action");
        }

        public IActionResult bestsellers()
        {
            return Content("This is the Books' Best sellers action");
        }
    }

    public class Authors : Controller
    {

        public IActionResult Index()
        {
            return Content("This is the Author controller’s Index action");
        }

        public IActionResult featured()
        {
            return Content("This is the Author controller’s features action");
        }

    }


}