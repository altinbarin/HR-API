using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpendingRequest",
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
                    Folder = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpendingRequest", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 125, 60, 154, 49, 67, 5, 121, 72, 123, 204, 224, 153, 118, 45, 105, 1, 172, 89, 96, 91, 195, 232, 138, 33, 47, 219, 135, 122, 14, 78, 251, 94, 231, 223, 37, 234, 175, 178, 214, 172, 249, 214, 155, 124, 219, 152, 87, 55, 183, 25, 170, 23, 190, 61, 30, 151, 110, 163, 220, 241, 133, 190, 114 }, new byte[] { 11, 20, 233, 128, 43, 71, 5, 117, 25, 76, 237, 17, 160, 200, 188, 226, 30, 50, 9, 30, 2, 91, 191, 97, 190, 184, 213, 142, 100, 245, 52, 217, 221, 197, 75, 95, 25, 50, 251, 58, 52, 145, 13, 49, 169, 188, 156, 181, 20, 196, 83, 18, 111, 214, 115, 206, 63, 85, 67, 84, 188, 193, 114, 100, 51, 254, 5, 119, 39, 127, 175, 104, 177, 34, 19, 203, 46, 66, 33, 75, 1, 70, 230, 188, 138, 102, 93, 239, 146, 122, 251, 17, 144, 46, 70, 16, 209, 197, 123, 193, 206, 107, 14, 88, 42, 122, 142, 183, 195, 250, 125, 82, 198, 228, 51, 226, 244, 231, 61, 71, 154, 235, 184, 153, 162, 93, 181, 215 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 246, 242, 7, 220, 252, 20, 42, 202, 85, 193, 44, 239, 220, 146, 184, 206, 232, 74, 236, 146, 118, 115, 246, 169, 165, 223, 169, 197, 248, 89, 160, 243, 130, 68, 228, 123, 210, 2, 235, 119, 154, 149, 28, 62, 201, 145, 87, 34, 34, 164, 78, 135, 178, 212, 140, 148, 255, 125, 88, 72, 201, 97, 194, 95 }, new byte[] { 133, 153, 33, 159, 189, 6, 125, 206, 205, 108, 206, 221, 41, 208, 124, 250, 88, 213, 199, 254, 69, 4, 198, 43, 191, 114, 175, 57, 35, 218, 218, 240, 119, 70, 72, 107, 171, 142, 47, 92, 189, 208, 252, 20, 10, 83, 193, 44, 97, 129, 54, 1, 5, 25, 50, 30, 202, 200, 211, 130, 63, 12, 40, 14, 42, 142, 92, 168, 191, 2, 215, 61, 252, 9, 169, 147, 236, 204, 249, 5, 58, 8, 187, 9, 99, 3, 101, 25, 170, 240, 147, 81, 61, 111, 112, 183, 107, 212, 213, 188, 242, 239, 220, 14, 64, 64, 186, 59, 142, 152, 234, 142, 76, 252, 6, 96, 5, 133, 74, 58, 78, 214, 155, 216, 145, 107, 212, 16 } });

            migrationBuilder.InsertData(
                table: "SpendingRequest",
                columns: new[] { "Id", "Currency", "EmployeeId", "Folder", "Name", "Price", "RequestApprovalStatusId", "RequestDate", "ResponseDate" },
                values: new object[,]
                {
                    { 1, "₺", 2, null, "Yakıt Gideri", 500m, 1, new DateTime(2024, 1, 28, 22, 24, 4, 422, DateTimeKind.Local).AddTicks(5378), null },
                    { 2, "₺", 1, null, "Yemek Gideri", 200m, 2, new DateTime(2024, 1, 28, 22, 24, 4, 422, DateTimeKind.Local).AddTicks(5390), null }
                });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 24, 4, 423, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 24, 4, 423, DateTimeKind.Local).AddTicks(3222));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpendingRequest");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 157, 244, 148, 106, 101, 176, 27, 88, 192, 138, 209, 38, 115, 91, 18, 161, 177, 248, 92, 77, 17, 97, 136, 82, 233, 141, 234, 65, 230, 68, 56, 50, 48, 128, 226, 88, 179, 67, 175, 2, 97, 222, 246, 236, 66, 195, 0, 56, 209, 132, 245, 212, 197, 168, 163, 45, 189, 182, 99, 127, 187, 220, 69 }, new byte[] { 230, 59, 152, 58, 153, 101, 90, 3, 2, 65, 247, 18, 224, 164, 141, 192, 230, 136, 21, 221, 148, 112, 5, 98, 87, 210, 43, 166, 236, 52, 136, 215, 178, 120, 102, 54, 24, 104, 138, 80, 59, 202, 87, 207, 5, 179, 94, 156, 196, 87, 193, 5, 240, 4, 173, 227, 5, 51, 235, 215, 219, 118, 155, 162, 14, 244, 169, 93, 184, 223, 102, 253, 210, 124, 49, 40, 89, 18, 58, 252, 146, 150, 184, 77, 61, 79, 88, 54, 145, 186, 175, 38, 231, 68, 69, 156, 27, 75, 107, 98, 70, 23, 174, 72, 4, 192, 63, 243, 63, 129, 254, 139, 33, 56, 188, 92, 37, 187, 152, 224, 32, 249, 206, 229, 110, 210, 38, 29 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 24, 21, 125, 45, 162, 77, 106, 128, 41, 84, 131, 234, 178, 13, 197, 99, 158, 57, 102, 150, 43, 244, 171, 78, 61, 82, 16, 119, 177, 4, 233, 104, 60, 71, 175, 204, 131, 184, 116, 80, 172, 113, 5, 36, 159, 121, 114, 16, 220, 60, 44, 96, 239, 168, 121, 128, 28, 247, 188, 200, 92, 236, 158, 124 }, new byte[] { 56, 213, 222, 183, 5, 183, 211, 131, 104, 53, 19, 32, 237, 11, 135, 143, 49, 9, 144, 236, 54, 247, 173, 9, 35, 111, 246, 142, 103, 51, 139, 63, 137, 207, 85, 81, 215, 153, 83, 22, 220, 228, 14, 64, 130, 228, 18, 119, 231, 108, 184, 219, 235, 32, 159, 180, 221, 76, 173, 15, 67, 142, 190, 227, 213, 55, 27, 151, 23, 32, 56, 44, 114, 226, 99, 183, 185, 99, 199, 159, 74, 7, 187, 54, 156, 194, 65, 13, 164, 164, 45, 56, 38, 63, 55, 22, 20, 73, 242, 218, 205, 33, 181, 121, 215, 177, 131, 27, 74, 131, 49, 100, 148, 29, 48, 209, 38, 203, 90, 68, 58, 247, 0, 85, 39, 181, 65, 157 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 27, 3, 6, 51, 751, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 27, 3, 6, 51, 751, DateTimeKind.Local).AddTicks(7503));
        }
    }
}
