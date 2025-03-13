using Microsoft.AspNetCore.Mvc;

namespace LumeaJucariilor.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
   
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

    }
}