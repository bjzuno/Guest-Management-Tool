using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Guest_Management_Tool.Migrations
{
    /// <inheritdoc />
    public partial class I_added_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuestInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fName = table.Column<string>(type: "text", nullable: false),
                    lName = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    contactNo = table.Column<string>(type: "text", nullable: false),
                    emailAdd = table.Column<string>(type: "text", nullable: false),
                    birthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    resDate = table.Column<DateOnly>(type: "date", nullable: false),
                    medReq = table.Column<string>(type: "text", nullable: false),
                    wellnessPref = table.Column<string>(type: "text", nullable: false),
                    accessReq = table.Column<string>(type: "text", nullable: false),
                    dietPref = table.Column<string>(type: "text", nullable: false),
                    foodAllerg = table.Column<string>(type: "text", nullable: false),
                    dietRequest = table.Column<string>(type: "text", nullable: false),
                    favoriteFandB = table.Column<string>(type: "text", nullable: false),
                    prevEvents = table.Column<string>(type: "text", nullable: false),
                    feedback = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestInformations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GuestInformations",
                columns: new[] { "Id", "accessReq", "address", "birthDate", "contactNo", "dietPref", "dietRequest", "emailAdd", "fName", "favoriteFandB", "feedback", "foodAllerg", "lName", "medReq", "prevEvents", "resDate", "wellnessPref" },
                values: new object[] { 1, "Wheelchair", "123 Asawa Ni Marie Street", new DateOnly(2024, 11, 23), "87000", "Seafood", "No", "kahitano@gmail.com", "Ferree", "Fries and Coke", "5 stars", "Shrimp", "Dela Cruz", "Wheelchair", "Christmas", new DateOnly(2024, 11, 23), "Gym Boi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestInformations");
        }
    }
}
