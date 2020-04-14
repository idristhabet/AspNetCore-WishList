using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var obj = new List<string> { "testA", "test" };
            var objTWO = new List<string> { "testA", "test" };

            return View("Index");
           
        }

        public IActionResult Error()
        {
           // return View("Error");
            return View();
        }
    }
}
