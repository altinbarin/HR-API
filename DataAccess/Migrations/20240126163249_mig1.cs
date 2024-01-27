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
                name: "RequestApprovalStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestApprovalStatuses", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "VocationLeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    VocationLeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    RequestApprovalStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocationLeaveRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VocationLeaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocationLeaveTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "BirthLocation", "City", "Company", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "Department", "Email", "EmailForRegister", "FirstName", "ImageData", "LastName", "MiddleName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Position", "Profession", "Salary", "SecondLastname", "Status", "TitleId", "TurkishIdentificationNumber" },
                values: new object[,]
                {
                    { 1, "Kadıköy", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "furkan.altinbarin@bilgeadamboost.com", "furkanaltinbarin@gmail.com", "Furkan", null, "Altınbarın", null, new byte[] { 4, 80, 137, 65, 9, 233, 46, 191, 61, 218, 77, 170, 159, 30, 241, 52, 194, 220, 63, 202, 247, 7, 72, 182, 153, 58, 40, 253, 195, 75, 150, 131, 144, 62, 88, 8, 205, 63, 134, 163, 239, 228, 154, 40, 125, 213, 170, 170, 13, 104, 188, 75, 20, 43, 46, 234, 234, 77, 20, 107, 149, 185, 204, 198 }, new byte[] { 187, 54, 155, 240, 17, 109, 163, 216, 142, 251, 174, 138, 99, 21, 213, 168, 228, 26, 172, 253, 142, 213, 131, 193, 169, 239, 25, 138, 168, 124, 194, 105, 7, 224, 96, 188, 16, 149, 25, 255, 195, 35, 35, 203, 76, 144, 174, 31, 130, 53, 253, 158, 170, 189, 87, 189, 81, 78, 162, 235, 94, 181, 4, 158, 154, 181, 232, 8, 162, 186, 222, 215, 116, 138, 135, 217, 61, 28, 38, 14, 81, 130, 94, 100, 33, 87, 164, 136, 225, 186, 51, 164, 180, 219, 65, 85, 233, 42, 254, 66, 201, 23, 106, 204, 221, 102, 140, 219, 90, 111, 134, 131, 216, 248, 174, 255, 130, 104, 44, 202, 131, 251, 31, 210, 181, 52, 152, 53 }, "05321234567", "Head of Department", "Software Developer", 10000m, null, true, 1, "12345678910" },
                    { 2, "Kartal", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "hakan.toraman@bilgeadamboost.com", "hakantoraman@gmail.com", "Hakan", null, "Toraman", null, new byte[] { 157, 129, 44, 59, 203, 125, 227, 119, 187, 14, 63, 193, 168, 183, 168, 15, 174, 254, 8, 155, 29, 230, 156, 234, 113, 236, 56, 143, 248, 72, 211, 255, 13, 190, 187, 211, 95, 14, 8, 150, 139, 236, 120, 121, 223, 18, 3, 22, 66, 38, 225, 163, 59, 238, 128, 8, 220, 140, 230, 161, 205, 64, 18, 136 }, new byte[] { 78, 127, 157, 122, 72, 42, 231, 135, 37, 114, 225, 90, 206, 139, 0, 52, 100, 48, 189, 58, 22, 141, 4, 3, 50, 148, 88, 52, 236, 9, 18, 205, 59, 41, 83, 135, 213, 243, 38, 101, 152, 183, 187, 78, 22, 128, 203, 64, 232, 227, 64, 67, 7, 82, 105, 19, 184, 165, 225, 223, 121, 16, 67, 231, 130, 87, 105, 103, 63, 26, 205, 171, 36, 31, 107, 186, 95, 40, 105, 131, 177, 100, 67, 175, 174, 144, 159, 170, 175, 250, 33, 205, 222, 114, 43, 175, 62, 255, 233, 255, 252, 161, 47, 244, 166, 4, 176, 93, 116, 146, 73, 70, 133, 137, 240, 143, 194, 156, 37, 51, 213, 217, 224, 41, 61, 247, 249, 52 }, "05321234567", "Junior Developer", "Software Developer", 10000m, null, true, 2, "12345678910" }
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
                table: "RequestApprovalStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Approved" },
                    { 3, "Rejected" },
                    { 4, "Canceled" }
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

            migrationBuilder.InsertData(
                table: "VocationLeaveTypes",
                columns: new[] { "Id", "Day", "Name" },
                values: new object[,]
                {
                    { 1, 14, "Annual Leave" },
                    { 2, 5, "Sick Leave" },
                    { 3, 3, "Marriage Leave" },
                    { 4, 120, "Maternity Leave" },
                    { 5, 5, "Paternity Leave" },
                    { 6, 3, "Bereavement Leave" },
                    { 7, 1, "Unpaid Leave" },
                    { 8, 1, "Other" }
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
                name: "RequestApprovalStatuses");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "VocationLeaveRequests");

            migrationBuilder.DropTable(
                name: "VocationLeaveTypes");
        }
    }
}
