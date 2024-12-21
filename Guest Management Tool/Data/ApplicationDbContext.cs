using Guest_Management_Tool.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guest_Management_Tool.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<DietaryPreference> DietaryPreferences { get; set; }
        public DbSet<HealthWellness> HealthWellnesses { get; set; }
        public DbSet<FoodAllergy> FoodAllergies { get; set; }
        public DbSet<MedicalRequirement> MedicalRequirements { get; set; }
        public DbSet<AccessibilityRequirement> AccessibilityRequirements { get; set; }
        public DbSet<GuestEvent> GuestEvents { get; set; }
    }
}
