using Microsoft.AspNetCore.Mvc;

namespace Guest_Management_Tool.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
