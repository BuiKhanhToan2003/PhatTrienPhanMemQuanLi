using Microsoft.AspNetCore.Mvc;

namespace DemoMVC304.Controllers
{
    public class DataController : Controller
    {
        // Gửi dữ liệu sang View
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "Hãy nhập tên của bạn vào ô bên dưới:";
            return View();
        }

        // Nhận dữ liệu từ form gửi lên
        [HttpPost]
        public IActionResult Index(string fullName)
        {
            ViewBag.Message = "Xin chào, " + fullName + "! Rất vui được gặp bạn.";
            return View();
        }
    }
}
