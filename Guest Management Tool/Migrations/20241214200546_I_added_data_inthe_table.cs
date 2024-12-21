using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guest_Management_Tool.Migrations
{
    /// <inheritdoc />
    public partial class I_added_data_inthe_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GuestInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "accessReq", "address", "contactNo", "dietPref", "dietRequest", "emailAdd", "fName", "favoriteFandB", "feedback", "medReq", "prevEvents", "wellnessPref" },
                values: new object[] { "No preferences", "123 Share St., Vancouver BC V1V 2A3", "990 123456", "All vegetarian food", "None", "markdelacruz111@gmail.com", "Mark", "No pork and soda", "5 stars fro the good service", "Should need to have a near pharmacy", "Christmas with my relatives", "Enthusiast to go gym nearby" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GuestInformations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "accessReq", "address", "contactNo", "dietPref", "dietRequest", "emailAdd", "fName", "favoriteFandB", "feedback", "medReq", "prevEvents", "wellnessPref" },
                values: new object[] { "Wheelchair", "123 Asawa Ni Marie Street", "87000", "Seafood", "No", "kahitano@gmail.com", "Ferree", "Fries and Coke", "5 stars", "Wheelchair", "Christmas", "Gym Boi" });
        }
    }
}
