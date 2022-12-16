using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //Console.WriteLine("Någon klickade på Privacy-länken!");
            //return View(Index);
            return View(nameof(Index));
        }

        public void
    }
}