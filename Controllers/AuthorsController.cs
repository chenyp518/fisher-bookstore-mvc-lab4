using System;
using Fisher.Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
public class Authors : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Featured(){
            // we would normally get this from a database
            var featuredAuthor = new Author()
            {
                AuthorID = 1,Name = "J.K. Rowling" //or pick your favorite
                };
                return View(featuredAuthor);
                }

    }
}