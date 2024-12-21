using Guest_Management_Tool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guest_Management_Tool.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(string email, string password)
        {
            if(email == "admin")
            {
                return RedirectToAction("DataEntry", "UserAdmin");
            }else
            {
                return RedirectToAction("Main", "Home");
            }
        }
    }
}
