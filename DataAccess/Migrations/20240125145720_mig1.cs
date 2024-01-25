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
                    { 1, "Kadıköy", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "furkan.altinbarin@bilgeadamboost.com", "furkanaltinbarin@gmail.com", "Furkan", null, "Altınbarın", null, new byte[] { 249, 107, 236, 230, 76, 17, 87, 39, 142, 212, 212, 242, 233, 20, 144, 6, 125, 218, 94, 16, 46, 47, 30, 204, 149, 126, 133, 106, 248, 133, 66, 8, 202, 186, 18, 189, 111, 16, 233, 14, 25, 237, 225, 24, 204, 43, 237, 206, 2, 200, 119, 82, 126, 147, 45, 55, 49, 71, 184, 246, 149, 36, 248, 231 }, new byte[] { 10, 199, 211, 205, 41, 85, 100, 147, 220, 109, 187, 67, 240, 246, 201, 92, 160, 206, 70, 36, 21, 200, 61, 220, 245, 200, 125, 30, 252, 15, 105, 190, 58, 223, 102, 253, 83, 66, 229, 109, 34, 67, 138, 28, 75, 228, 61, 129, 13, 26, 120, 92, 97, 248, 16, 52, 172, 204, 218, 218, 37, 65, 71, 78, 82, 108, 160, 32, 72, 191, 61, 122, 175, 163, 140, 38, 161, 224, 115, 56, 46, 82, 220, 7, 163, 128, 158, 218, 86, 144, 77, 64, 169, 218, 142, 86, 248, 79, 161, 41, 83, 51, 205, 20, 108, 53, 239, 159, 98, 108, 147, 30, 193, 197, 233, 111, 48, 132, 148, 112, 163, 189, 61, 103, 44, 19, 8, 89 }, "05321234567", "Head of Department", "Software Developer", 10000m, null, true, 1, "12345678910" },
                    { 2, "Kartal", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "hakan.toraman@bilgeadamboost.com", "hakantoraman@gmail.com", "Hakan", null, "Toraman", null, new byte[] { 11, 165, 99, 162, 103, 37, 108, 159, 68, 11, 102, 255, 7, 56, 56, 120, 89, 21, 40, 112, 248, 253, 184, 138, 123, 189, 120, 82, 123, 175, 186, 125, 208, 8, 39, 84, 136, 236, 197, 27, 172, 160, 61, 29, 54, 224, 156, 58, 50, 101, 164, 100, 8, 248, 197, 195, 79, 68, 115, 66, 118, 100, 62, 88 }, new byte[] { 199, 193, 14, 154, 121, 107, 210, 9, 244, 198, 202, 221, 219, 93, 235, 38, 63, 96, 220, 115, 3, 27, 208, 124, 247, 136, 181, 195, 156, 205, 181, 216, 134, 97, 5, 52, 22, 211, 211, 231, 64, 174, 164, 168, 142, 227, 130, 30, 23, 249, 1, 157, 77, 94, 48, 160, 47, 44, 139, 228, 180, 144, 247, 95, 239, 131, 89, 113, 20, 22, 142, 5, 134, 67, 239, 154, 154, 184, 34, 103, 75, 200, 211, 101, 189, 144, 170, 48, 180, 236, 149, 171, 177, 112, 40, 92, 144, 222, 0, 64, 46, 107, 163, 138, 246, 194, 152, 250, 3, 185, 199, 156, 80, 133, 191, 218, 61, 17, 101, 184, 115, 96, 10, 23, 166, 44, 94, 94 }, "05321234567", "Junior Developer", "Software Developer", 10000m, null, true, 2, "12345678910" }
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
