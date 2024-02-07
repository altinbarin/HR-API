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
                name: "AdvanceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestApprovalStatusId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceRequests", x => x.Id);
                });

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
                name: "Firms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MersisNo = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false),
                    DateOfFoundation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConctractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConctractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.Id);
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
                name: "SpendingRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    RequestApprovalStatusId = table.Column<int>(type: "int", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Folder = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpendingRequests", x => x.Id);
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
                    RequestApprovalStatusId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
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
                table: "AdvanceRequests",
                columns: new[] { "Id", "Currency", "Description", "EmployeeId", "Price", "RequestApprovalStatusId", "RequestDate", "ResponseDate", "Status", "Type" },
                values: new object[,]
                {
                    { 1, "₺", "Tatil", 2, 1000m, 1, new DateTime(2024, 2, 7, 2, 13, 5, 284, DateTimeKind.Local).AddTicks(4501), null, true, "Tatil" },
                    { 2, "₺", "2 maaş avans talebi", 2, 1000m, 2, new DateTime(2024, 2, 7, 2, 13, 5, 284, DateTimeKind.Local).AddTicks(4515), null, true, "Tatil" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "BirthLocation", "City", "Company", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "Department", "Email", "EmailForRegister", "FirstName", "ImageData", "LastName", "MiddleName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Position", "Profession", "Salary", "SecondLastname", "Status", "TitleId", "TurkishIdentificationNumber" },
                values: new object[,]
                {
                    { 1, "Kadıköy", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "furkan.altinbarin@bilgeadamboost.com", "furkanaltinbarin@gmail.com", "Furkan", null, "Altınbarın", null, new byte[] { 35, 120, 255, 13, 227, 233, 118, 236, 200, 19, 57, 254, 38, 51, 43, 69, 71, 179, 243, 175, 162, 32, 159, 252, 132, 32, 241, 217, 149, 201, 21, 95, 202, 67, 113, 55, 84, 155, 250, 115, 19, 182, 169, 157, 204, 72, 141, 226, 149, 80, 14, 34, 78, 135, 92, 156, 211, 126, 150, 86, 1, 66, 90, 250 }, new byte[] { 109, 131, 29, 105, 235, 143, 78, 77, 101, 136, 238, 149, 240, 40, 41, 23, 231, 7, 81, 172, 90, 208, 219, 27, 93, 221, 183, 38, 129, 107, 77, 87, 9, 124, 172, 172, 160, 233, 155, 152, 199, 166, 161, 49, 22, 111, 16, 219, 194, 10, 159, 20, 49, 134, 230, 167, 99, 18, 107, 70, 165, 190, 1, 75, 75, 102, 162, 95, 150, 162, 126, 134, 99, 250, 128, 67, 112, 149, 150, 245, 89, 205, 52, 44, 90, 158, 160, 190, 174, 201, 63, 163, 111, 192, 109, 84, 55, 65, 220, 137, 111, 135, 170, 157, 131, 223, 31, 21, 161, 19, 148, 185, 66, 19, 131, 119, 93, 165, 1, 243, 98, 217, 239, 133, 64, 245, 211, 170 }, "05321234567", "Head of Department", "Software Developer", 10000m, null, true, 1, "12345678910" },
                    { 2, "Kartal", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "hakan.toraman@bilgeadamboost.com", "hakantoraman@gmail.com", "Hakan", null, "Toraman", null, new byte[] { 29, 79, 175, 138, 48, 159, 72, 210, 209, 126, 16, 18, 194, 147, 32, 50, 62, 124, 49, 209, 236, 250, 162, 138, 94, 168, 184, 93, 196, 195, 212, 190, 194, 76, 195, 255, 109, 94, 13, 12, 160, 238, 158, 119, 179, 172, 239, 75, 0, 130, 56, 83, 104, 21, 191, 210, 235, 209, 157, 80, 222, 145, 82, 181 }, new byte[] { 156, 174, 8, 100, 39, 183, 61, 192, 79, 173, 140, 140, 67, 202, 24, 5, 239, 168, 86, 31, 112, 193, 168, 52, 8, 104, 186, 236, 134, 114, 133, 51, 107, 169, 159, 140, 56, 23, 217, 235, 70, 117, 21, 63, 226, 249, 254, 222, 75, 147, 213, 43, 204, 107, 24, 71, 59, 94, 59, 118, 16, 164, 135, 65, 120, 221, 173, 196, 48, 13, 44, 106, 102, 223, 115, 18, 27, 46, 239, 82, 141, 45, 76, 126, 143, 157, 129, 56, 4, 245, 17, 37, 123, 199, 249, 75, 115, 101, 26, 225, 40, 166, 99, 63, 58, 41, 10, 70, 198, 196, 162, 157, 31, 3, 45, 164, 16, 106, 160, 116, 122, 38, 31, 95, 62, 158, 208, 140 }, "05321234567", "Junior Developer", "Software Developer", 10000m, null, true, 2, "12345678910" },
                    { 3, "Cevizlibağ", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "mehmet.catmakasli@bilgeadamboost.com", "mehmetcatmakasli@gmail.com", "Mehmet", null, "Çatmakaşlı", null, new byte[] { 131, 228, 134, 185, 20, 79, 33, 109, 119, 96, 70, 137, 250, 112, 21, 102, 17, 127, 117, 234, 44, 211, 251, 174, 165, 51, 78, 108, 127, 236, 197, 154, 82, 98, 53, 111, 213, 101, 89, 13, 8, 247, 219, 141, 163, 248, 91, 242, 102, 124, 15, 190, 42, 48, 32, 175, 14, 250, 161, 204, 237, 192, 38, 136 }, new byte[] { 180, 245, 55, 132, 51, 147, 130, 46, 3, 19, 68, 45, 236, 17, 196, 36, 202, 171, 233, 203, 166, 8, 215, 185, 186, 215, 127, 190, 229, 4, 179, 94, 76, 38, 91, 84, 163, 37, 79, 44, 252, 164, 82, 222, 83, 149, 13, 49, 197, 237, 171, 123, 128, 50, 47, 110, 14, 219, 200, 234, 224, 9, 214, 32, 140, 79, 61, 200, 102, 181, 231, 90, 46, 149, 53, 220, 27, 68, 169, 132, 126, 20, 201, 249, 203, 227, 162, 50, 58, 67, 251, 152, 58, 129, 85, 153, 65, 247, 65, 87, 117, 153, 209, 39, 208, 68, 142, 120, 192, 180, 214, 199, 251, 54, 153, 119, 244, 76, 214, 29, 231, 227, 17, 213, 176, 207, 98, 133 }, "05321234567", "Junior Developer", "Software Developer", 15000m, null, true, 2, "14846942042" }
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "Id", "Address", "ConctractEndDate", "ConctractStartDate", "DateOfFoundation", "Email", "EmployeeCount", "IsActive", "Logo", "MersisNo", "Name", "PhoneNumber", "Title", "VergiDairesi", "VergiNo" },
                values: new object[,]
                {
                    { 1, "Kadıköy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bilgeadam@mail.com", 100, true, null, "1234567890123456", "Bilge Adam", "05321234567", "Bilge Adam Bilişim Grubu", "Kadıköy", "1234567890" },
                    { 2, "Etiler", new DateTime(2032, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kocholding@mail.com", 50000, true, null, "1234567890123456", "Koç Holding", "05321234597", "Koç Holding", "Etiler", "1234567891" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "admin" },
                    { 2, "user" },
                    { 3, "manager" }
                });

            migrationBuilder.InsertData(
                table: "RequestApprovalStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bekliyor" },
                    { 2, "Onay" },
                    { 3, "Ret" },
                    { 4, "İptal" }
                });

            migrationBuilder.InsertData(
                table: "SpendingRequests",
                columns: new[] { "Id", "Currency", "EmployeeId", "Folder", "FolderName", "Name", "Price", "RequestApprovalStatusId", "RequestDate", "ResponseDate", "Status" },
                values: new object[,]
                {
                    { 1, "₺", 2, null, null, "Yakıt Gideri", 500m, 1, new DateTime(2024, 2, 7, 2, 13, 5, 285, DateTimeKind.Local).AddTicks(3452), null, true },
                    { 2, "₺", 1, null, null, "Yemek Gideri", 200m, 2, new DateTime(2024, 2, 7, 2, 13, 5, 285, DateTimeKind.Local).AddTicks(3458), null, true }
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
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "VocationLeaveRequests",
                columns: new[] { "Id", "EmployeeId", "EndingDate", "RequestApprovalStatusId", "RequestDate", "ResponseDate", "StartingDate", "Status", "VocationLeaveTypeId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 2, 7, 2, 13, 5, 286, DateTimeKind.Local).AddTicks(924), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 2, 2, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 2, 7, 2, 13, 5, 286, DateTimeKind.Local).AddTicks(929), null, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2 }
                });

            migrationBuilder.InsertData(
                table: "VocationLeaveTypes",
                columns: new[] { "Id", "Day", "Name" },
                values: new object[,]
                {
                    { 1, 14, "Yıllık İzin" },
                    { 2, 5, "Hastalık İzni" },
                    { 3, 3, "Evlilik İzni" },
                    { 4, 120, "Doğum İzni" },
                    { 5, 5, "Babalık İzni" },
                    { 6, 3, "Ölüm İzni" },
                    { 7, 1, "Ücretsiz İzin" },
                    { 8, 1, "Diğer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvanceRequests");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "RequestApprovalStatuses");

            migrationBuilder.DropTable(
                name: "SpendingRequests");

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
