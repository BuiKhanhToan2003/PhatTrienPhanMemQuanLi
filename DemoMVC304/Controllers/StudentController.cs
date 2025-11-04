using Microsoft.AspNetCore.Mvc;
using DemoMVC304.Models;

namespace DemoMVC304.Controllers
{
    public class StudentController : Controller
    {
        // [GET] Hiển thị form nhập
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // [POST] Nhận dữ liệu từ form gửi lên
        [HttpPost]
        public IActionResult Create(Student student)
        {
    
            return View("Detail", student);
        }
    }
}
