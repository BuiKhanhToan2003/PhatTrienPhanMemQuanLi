using Microsoft.AspNetCore.Mvc;

namespace DemoMVC304.Controllers
{
    public class DataController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "Hãy nhập tên của bạn vào ô bên dưới:";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string fullName)
        {
            ViewBag.Message = "Xin chào, " + fullName + "! Rất vui được gặp bạn.";
            return View();
        }
    }
}
