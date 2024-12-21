namespace Guest_Management_Tool.Models
{
    public class GuestInformation
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public required string IsMale { get; set; }
        public required string IsFemale { get; set; }

        public string address { get; set; }
        public string contactNo { get; set; }
        public string emailAdd { get; set; }
        public DateOnly birthDate { get; set; }
        public DateOnly resDate { get; set; }
        public string medReq { get; set; }
        public string wellnessPref { get; set; }
        public string accessReq { get; set; }
        public string dietPref { get; set; }
        public string foodAllerg { get; set; }
        public string dietRequest { get; set; }
        public string favoriteFandB {  get; set; }
        public string prevEvents { get; set; }
        public string feedback { get; set; }
    }
}
