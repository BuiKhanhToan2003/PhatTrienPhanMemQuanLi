using Microsoft.AspNetCore.Mvc;

namespace DemoMVC304.Controllers
{
    public class MessageController : Controller
    {
    
        public IActionResult Index()
        {
            ViewBag.Greeting = "Xin chào bạn! Đây là dữ liệu từ ViewBag.";
            ViewData["Note"] = "Đây là dữ liệu từ ViewData.";

            return View();
        }

        
        public IActionResult SendTempData()
        {
            TempData["Message"] = "Dữ liệu này được lưu bằng TempData và vẫn tồn tại sau Redirect!";
            return RedirectToAction("ShowTempData");
        }

        
        public IActionResult ShowTempData()
        {
            ViewBag.TempMessage = TempData["Message"];
            return View();
        }
    }
}
