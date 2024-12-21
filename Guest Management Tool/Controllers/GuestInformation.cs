using Guest_Management_Tool.Data;
using Guest_Management_Tool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Guest_Management_Tool.Controllers
{
    public class GuestInformation : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuestInformation(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Professions.ToList());
        }
    }
}
