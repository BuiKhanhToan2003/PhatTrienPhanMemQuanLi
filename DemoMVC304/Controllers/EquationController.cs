using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoMVC304.Controllers
{
    public class EquationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a, double b, double c)
        {
            string ketqua;
            double delta = b * b - 4 * a * c;

            if (a == 0)
                ketqua = "Đây không phải là phương trình bậc 2.";
            else if (delta < 0)
                ketqua = "Phương trình vô nghiệm.";
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                ketqua = $"Phương trình có nghiệm kép x = {x}";
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                ketqua = $"Phương trình có 2 nghiệm: x₁ = {x1}, x₂ = {x2}";
            }

            ViewBag.KetQua = ketqua;
            return View("Result");
        }
    }
}
