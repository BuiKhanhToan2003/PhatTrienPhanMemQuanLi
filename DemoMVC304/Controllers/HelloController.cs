using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoMVC304.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string ten, int namsinh)
        {
            int tuoi = DateTime.Now.Year - namsinh;
            ViewBag.Ten = ten;
            ViewBag.Tuoi = tuoi;
            return View("Result");
        }
    }
}
