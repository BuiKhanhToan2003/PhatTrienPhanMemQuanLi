using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoMVC304.Controllers
{
    public class DemoController : Controller
    {
        // GET: /Demo/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Demo/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
