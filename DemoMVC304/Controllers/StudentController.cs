using Microsoft.AspNetCore.Mvc;
using DemoMVC304.Models;

namespace DemoMVC304.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
    
            return View("Detail", student);
        }
    }
}
