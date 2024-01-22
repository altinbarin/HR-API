using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurkishIdentificationNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailForRegister = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(500)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(500)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SecondLastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDismissal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "BirthLocation", "City", "Company", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "Department", "Email", "EmailForRegister", "FirstName", "ImageData", "LastName", "MiddleName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Position", "Profession", "Salary", "SecondLastname", "Status", "TitleId", "TurkishIdentificationNumber" },
                values: new object[,]
                {
                    { 1, "Kadıköy", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "furkan.altınbarın@bilgeadamboost.com", "furkanaltinbarin@gmail.com", "Furkan", null, "Altınbarın", null, new byte[] { 49, 50, 51 }, new byte[] { 49, 50, 51 }, "05321234567", "Head of Department", "Software Developer", 10000m, null, true, 1, "12345678910" },
                    { 2, "Kartal", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "hakan.toraman@bilgeadamboost.com", "hakantoraman@gmail.com", "Hakan", null, "Toraman", null, new byte[] { 49, 50, 51 }, new byte[] { 49, 50, 51 }, "05321234567", "Junior Developer", "Software Developer", 10000m, null, true, 2, "12345678910" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "user" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Software Developer" }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "EmployeeId", "OperationClaimId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");
        }
    }
}
