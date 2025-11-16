using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DemoMVC304.Controllers
{
    public class ResultDemoController : Controller
    {
        public IActionResult ShowView()
        {
            ViewBag.Message = "Đây là ví dụ về ViewResult — trả về giao diện view.";
            return View();
        }

        public IActionResult RedirectExample()
        {
            return Redirect("https://dotnet.microsoft.com/");
        }

        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }

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

        public IActionResult DownloadFile()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "sample.txt");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/plain", "TaiVe.txt");
        }

        public IActionResult CustomStatus()
        {
            return StatusCode(404, "Trang bạn yêu cầu không tồn tại!");
        }
    }
}
