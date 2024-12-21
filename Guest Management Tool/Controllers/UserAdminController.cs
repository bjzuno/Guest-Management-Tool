using Guest_Management_Tool.Data;
using Guest_Management_Tool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Guest_Management_Tool.Controllers
{
    public class UserAdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserAdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

        public IActionResult DataEntry()
        {
            return View();
        }

        public IActionResult ManageProfession()
        {
            return View(_context.Professions.ToList());
        }

        [HttpPost]
        public IActionResult AddProfession(string name)
        {
            _context.Professions.Add(new Profession { Name = name });
            _context.SaveChanges();
            return RedirectToAction("ManageProfession");
        }

        [HttpPost]
        public IActionResult RemoveProfession(int id)
        {
            var profession = _context.Professions.Find(id);
            if (profession != null)
            {
                _context.Professions.Remove(profession);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageProfession");
        }

        public IActionResult ManageDietaryPreferences()
        {
            return View(_context.DietaryPreferences.ToList());
        }

        [HttpPost]
        public IActionResult AddDietaryPreference(string name)
        {
            _context.DietaryPreferences.Add(new DietaryPreference { Name = name });
            _context.SaveChanges();
            return RedirectToAction("ManageDietaryPreferences");
        }

        [HttpPost]
        public IActionResult RemoveDietaryPreference(int id)
        {
            var preference = _context.DietaryPreferences.Find(id);
            if (preference != null)
            {
                _context.DietaryPreferences.Remove(preference);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageDietaryPreferences");
        }

        public IActionResult ManageHealthWellnesses()
        {
            return View(_context.HealthWellnesses.ToList());
        }

        [HttpPost]
        public IActionResult AddHealthWellness(string name)
        {
            _context.HealthWellnesses.Add(new HealthWellness { Name = name });
            _context.SaveChanges();
            return RedirectToAction("ManageHealthWellnesses");
        }

        [HttpPost]
        public IActionResult RemoveHealthWellness(int id)
        {
            var hwellness = _context.HealthWellnesses.Find(id);
            if (hwellness != null)
            {
                _context.HealthWellnesses.Remove(hwellness);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageHealthWellnesses");
        }

        public IActionResult ManageFoodAllergies()
        {
            return View(_context.FoodAllergies.ToList());
        }

        [HttpPost]
        public IActionResult AddFoodAllergy(string name)
        {
            _context.FoodAllergies.Add(new FoodAllergy { Name = name });
            _context.SaveChanges();
            return RedirectToAction("ManageFoodAllergies");
        }

        [HttpPost]
        public IActionResult RemoveFoodAllergy(int id)
        {
            var allergy = _context.FoodAllergies.Find(id);
            if (allergy != null)
            {
                _context.FoodAllergies.Remove(allergy);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageFoodAllergies");
        }

        public IActionResult ManageMedicalRequirements()
        {
            return View(_context.MedicalRequirements.ToList());
        }

        [HttpPost]
        public IActionResult AddMedicalRequirement(string name)
        {
            _context.MedicalRequirements.Add(new MedicalRequirement { Name = name });
            _context.SaveChanges();
            return RedirectToAction("ManageMedicalRequirements");
        }

        [HttpPost]
        public IActionResult RemoveMedicalRequirement(int id)
        {
            var requirement = _context.MedicalRequirements.Find(id);
            if (requirement != null)
            {
                _context.MedicalRequirements.Remove(requirement);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageMedicalRequirements");
        }

        public IActionResult ManageAccessibilityRequirements()
        {
            return View(_context.AccessibilityRequirements.ToList());
        }

        [HttpPost]
        public IActionResult AddAccessibilityRequirement(string name)
        {
            _context.AccessibilityRequirements.Add(new AccessibilityRequirement { Name = name });
            _context.SaveChanges();
            return RedirectToAction("ManageAccessibilityRequirements");
        }

        [HttpPost]
        public IActionResult RemoveAccessibilityRequirement(int id)
        {
            var requirement = _context.AccessibilityRequirements.Find(id);
            if (requirement != null)
            {
                _context.AccessibilityRequirements.Remove(requirement);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageAccessibilityRequirements");
        }

        public IActionResult ManageEvents()
        {
            return View(_context.GuestEvents.ToList());
        }

        [HttpPost]
        public IActionResult AddGuestEvent(string name, string label)
        {
            _context.GuestEvents.Add(new GuestEvent { Name = name, Label = label });
            _context.SaveChanges();
            return RedirectToAction("ManageEvents");
        }

        [HttpPost]
        public IActionResult RemoveGuestEvent(int id)
        {
            var guestEvent = _context.GuestEvents.Find(id);
            if (guestEvent != null)
            {
                _context.GuestEvents.Remove(guestEvent);
                _context.SaveChanges();
            }
            return RedirectToAction("ManageEvents");
        }
        public IActionResult ManageFields()
        {
            return View();
        }
    }
}
