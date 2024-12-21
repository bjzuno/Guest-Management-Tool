namespace Guest_Management_Tool.Models
{
    public class DietAndAllergy
    {
        public IEnumerable<FoodAllergy> FoodAllergy { get; set; }
        public IEnumerable<DietaryPreference> DietaryPreference { get; set; }
    }
}
