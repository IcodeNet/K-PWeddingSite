using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Wedding.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rsvp()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult TheDay()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Gifts()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Accommodation()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
