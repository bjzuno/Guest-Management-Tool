using Guest_Management_Tool.Data;
using Guest_Management_Tool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Guest_Management_Tool.Controllers
{
    public class GuestWellness : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuestWellness(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var information = new
            {
                Medical = _context.MedicalRequirements.ToList(),
                Wellness = _context.HealthWellnesses.ToList(),
                Access = _context.AccessibilityRequirements.ToList()
            };
            return View(information);
        }
    }
}
