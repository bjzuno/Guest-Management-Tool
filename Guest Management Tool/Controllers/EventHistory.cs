using Guest_Management_Tool.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guest_Management_Tool.Controllers
{
    public class EventHistory : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventHistory(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.GuestEvents.ToList());
        }
    }
}
