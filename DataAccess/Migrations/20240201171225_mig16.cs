using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 1, 20, 12, 25, 272, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 1, 20, 12, 25, 272, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 176, 3, 154, 253, 194, 15, 86, 211, 179, 133, 161, 234, 59, 215, 65, 242, 138, 240, 64, 194, 68, 187, 76, 196, 174, 214, 173, 211, 6, 154, 218, 180, 228, 246, 213, 147, 231, 55, 186, 41, 145, 64, 214, 9, 46, 224, 24, 53, 152, 17, 24, 190, 152, 102, 214, 132, 18, 78, 61, 104, 192, 167, 221 }, new byte[] { 233, 191, 61, 98, 122, 110, 16, 164, 202, 176, 106, 43, 172, 190, 91, 171, 222, 49, 206, 86, 56, 159, 30, 109, 219, 74, 253, 103, 93, 207, 20, 15, 188, 51, 230, 100, 234, 84, 34, 237, 214, 31, 158, 210, 25, 58, 3, 23, 247, 107, 97, 28, 216, 22, 41, 243, 62, 129, 22, 184, 253, 76, 209, 115, 136, 128, 179, 141, 182, 14, 48, 26, 211, 99, 182, 13, 131, 166, 32, 101, 246, 58, 6, 170, 99, 73, 145, 150, 13, 0, 20, 253, 38, 237, 219, 15, 199, 76, 232, 53, 214, 34, 88, 182, 187, 54, 53, 22, 71, 160, 85, 68, 7, 48, 223, 100, 29, 101, 105, 124, 24, 241, 75, 100, 48, 231, 168, 52 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 228, 242, 72, 13, 148, 216, 97, 44, 93, 85, 235, 164, 88, 195, 110, 128, 138, 189, 26, 96, 173, 34, 6, 225, 234, 19, 2, 0, 102, 81, 20, 230, 137, 90, 197, 10, 63, 85, 253, 91, 150, 118, 24, 137, 3, 219, 145, 88, 225, 21, 118, 146, 198, 56, 71, 247, 223, 245, 182, 246, 229, 118, 238, 141 }, new byte[] { 43, 248, 184, 64, 156, 238, 133, 237, 135, 27, 237, 134, 34, 133, 98, 198, 126, 72, 178, 28, 250, 40, 182, 31, 195, 228, 27, 30, 122, 90, 149, 181, 52, 147, 41, 164, 160, 129, 108, 68, 47, 159, 232, 134, 124, 5, 225, 82, 204, 247, 1, 209, 142, 176, 172, 207, 53, 120, 79, 254, 2, 238, 214, 18, 12, 117, 15, 93, 201, 146, 238, 185, 51, 73, 129, 96, 0, 115, 150, 18, 217, 192, 144, 188, 91, 28, 30, 113, 104, 5, 38, 9, 167, 133, 88, 6, 47, 186, 89, 227, 200, 138, 182, 27, 86, 140, 89, 35, 203, 115, 230, 107, 41, 16, 37, 73, 74, 254, 135, 217, 74, 103, 149, 211, 127, 219, 55, 209 } });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "BirthLocation", "City", "Company", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "Department", "Email", "EmailForRegister", "FirstName", "ImageData", "LastName", "MiddleName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Position", "Profession", "Salary", "SecondLastname", "Status", "TitleId", "TurkishIdentificationNumber" },
                values: new object[] { 3, "Cevizlibağ", "İstanbul", "İstanbul", "Bilge Adam", new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "mehmet.catmakasli@bilgeadamboost.com", "mehmetcatmakasli@gmail.com", "Mehmet", null, "Çatmakaşlı", null, new byte[] { 77, 9, 123, 238, 77, 77, 66, 149, 25, 202, 206, 97, 177, 89, 25, 246, 55, 125, 55, 210, 176, 93, 166, 220, 200, 160, 227, 147, 81, 25, 126, 160, 1, 231, 106, 122, 174, 92, 59, 199, 14, 126, 47, 54, 110, 117, 79, 145, 102, 202, 155, 53, 231, 177, 44, 229, 207, 121, 124, 220, 70, 88, 240, 176 }, new byte[] { 212, 34, 101, 80, 46, 174, 210, 170, 136, 158, 73, 164, 189, 10, 180, 249, 116, 197, 137, 108, 114, 127, 183, 198, 100, 92, 38, 25, 206, 168, 253, 229, 12, 131, 216, 105, 120, 251, 197, 252, 136, 53, 139, 110, 242, 186, 2, 251, 122, 166, 130, 252, 180, 159, 156, 168, 209, 204, 251, 29, 123, 89, 228, 34, 84, 22, 145, 197, 18, 46, 246, 21, 27, 113, 19, 71, 183, 121, 195, 214, 44, 4, 28, 16, 186, 120, 53, 126, 249, 198, 132, 194, 209, 220, 127, 208, 125, 74, 106, 66, 28, 33, 23, 84, 92, 73, 7, 5, 175, 64, 49, 55, 214, 222, 22, 99, 97, 200, 55, 41, 77, 232, 189, 33, 25, 120, 80, 249 }, "05321234567", "Junior Developer", "Software Developer", 15000m, null, true, 2, "14846942042" });

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
                values: new object[] { 3, "manager" });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 1, 20, 12, 25, 273, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 1, 20, 12, 25, 273, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "EmployeeId", "OperationClaimId" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 1, 20, 12, 25, 274, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 1, 20, 12, 25, 274, DateTimeKind.Local).AddTicks(7011));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 31, 9, 42, 5, 221, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 31, 9, 42, 5, 221, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 5, 176, 101, 246, 98, 86, 223, 124, 53, 120, 200, 7, 58, 223, 188, 50, 95, 152, 74, 240, 222, 111, 102, 26, 149, 42, 34, 120, 236, 230, 3, 200, 181, 29, 143, 7, 16, 31, 39, 218, 135, 253, 97, 115, 180, 241, 71, 185, 186, 77, 255, 25, 246, 178, 166, 54, 163, 133, 109, 80, 131, 146, 142, 73 }, new byte[] { 205, 108, 60, 180, 26, 31, 78, 32, 182, 70, 149, 72, 51, 117, 88, 133, 133, 228, 91, 84, 130, 162, 59, 128, 198, 94, 225, 11, 185, 63, 220, 109, 224, 90, 114, 163, 146, 30, 232, 207, 243, 181, 204, 212, 232, 38, 14, 92, 174, 31, 33, 122, 205, 115, 43, 195, 24, 212, 41, 183, 111, 174, 108, 188, 36, 76, 115, 67, 17, 157, 177, 192, 3, 170, 207, 49, 245, 219, 190, 31, 68, 133, 91, 118, 105, 86, 193, 196, 148, 165, 199, 80, 243, 170, 201, 42, 28, 114, 64, 123, 215, 223, 57, 205, 155, 171, 76, 193, 190, 114, 97, 160, 67, 106, 193, 146, 208, 171, 125, 28, 148, 207, 115, 108, 91, 111, 158, 245 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 213, 96, 188, 217, 160, 67, 67, 180, 3, 212, 91, 127, 137, 37, 28, 121, 73, 223, 48, 4, 21, 36, 102, 239, 55, 196, 240, 231, 97, 96, 114, 229, 254, 255, 145, 242, 0, 186, 121, 81, 98, 138, 163, 254, 174, 114, 135, 176, 6, 19, 32, 137, 226, 192, 20, 106, 100, 254, 138, 57, 244, 67, 146, 95 }, new byte[] { 141, 177, 118, 115, 17, 53, 108, 33, 69, 212, 237, 180, 6, 125, 37, 116, 180, 192, 52, 151, 115, 93, 40, 16, 1, 174, 235, 75, 44, 40, 18, 130, 50, 45, 213, 251, 144, 51, 151, 17, 32, 37, 154, 94, 63, 148, 30, 56, 213, 7, 112, 204, 236, 197, 213, 176, 197, 212, 44, 152, 12, 90, 136, 139, 52, 232, 194, 27, 30, 221, 58, 175, 30, 106, 12, 247, 143, 108, 0, 63, 168, 102, 113, 89, 210, 6, 159, 151, 192, 228, 153, 37, 48, 208, 112, 114, 152, 62, 37, 120, 224, 105, 160, 80, 145, 94, 115, 234, 223, 128, 178, 218, 187, 116, 2, 38, 64, 10, 6, 24, 100, 21, 28, 143, 245, 60, 80, 130 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 31, 9, 42, 5, 222, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 31, 9, 42, 5, 222, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 31, 9, 42, 5, 223, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 31, 9, 42, 5, 223, DateTimeKind.Local).AddTicks(3490));
        }
    }
}
