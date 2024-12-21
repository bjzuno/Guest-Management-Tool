using Guest_Management_Tool.Data;
using Guest_Management_Tool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Guest_Management_Tool.Controllers
{
    public class GuestDietary : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuestDietary(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dietAndAllergy = new
            {
                Diet = _context.DietaryPreferences.ToList(),
                Allergy = _context.FoodAllergies.ToList()
            };
            return View(dietAndAllergy);
        }
    }
}
