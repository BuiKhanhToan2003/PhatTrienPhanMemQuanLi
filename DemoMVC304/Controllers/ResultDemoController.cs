using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DemoMVC304.Controllers
{
    public class ResultDemoController : Controller
    {
        // 1️⃣ ViewResult
        public IActionResult ShowView()
        {
            ViewBag.Message = "Đây là ví dụ về ViewResult — trả về giao diện view.";
            return View();
        }

        // 2️⃣ RedirectResult
        public IActionResult RedirectExample()
        {
            return Redirect("https://dotnet.microsoft.com/");
        }

        // 3️⃣ RedirectToActionResult
        public IActionResult RedirectToHome()
        {
            // Chuyển hướng đến action Index trong HomeController
            return RedirectToAction("Index", "Home");
        }

        // 4️⃣ JsonResult
        public IActionResult GetJson()
        {
            var data = new
            {
                Name = "Toàn",
                Course = "Phát triển phần mềm quản lý",
                Framework = "ASP.NET Core MVC"
            };
            return Json(data);
        }

        // 5️⃣ FileResult
        public IActionResult DownloadFile()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "sample.txt");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/plain", "TaiVe.txt");
        }

        // 6️⃣ StatusCodeResult
        public IActionResult CustomStatus()
        {
            // Ví dụ: trả về mã 404
            return StatusCode(404, "Trang bạn yêu cầu không tồn tại!");
        }
    }
}
