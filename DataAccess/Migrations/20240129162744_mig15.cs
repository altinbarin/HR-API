using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig15 : Migration
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
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceRequests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AdvanceRequests",
                columns: new[] { "Id", "Currency", "Description", "EmployeeId", "Price", "RequestApprovalStatusId", "RequestDate", "ResponseDate", "Type" },
                values: new object[,]
                {
                    { 1, "TL", "Tatil", 2, 1000m, 1, new DateTime(2024, 1, 29, 19, 27, 44, 80, DateTimeKind.Local).AddTicks(2489), null, "Tatil" },
                    { 2, "TL", "2 maaş avans talebi", 2, 1000m, 2, new DateTime(2024, 1, 29, 19, 27, 44, 80, DateTimeKind.Local).AddTicks(2503), null, "Tatil" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 51, 140, 143, 57, 20, 1, 3, 26, 182, 222, 57, 227, 35, 164, 117, 144, 15, 237, 73, 2, 82, 70, 82, 14, 16, 21, 236, 146, 43, 58, 206, 50, 210, 156, 209, 212, 249, 173, 40, 66, 104, 119, 192, 224, 62, 232, 141, 124, 70, 187, 201, 99, 237, 93, 156, 8, 190, 236, 121, 192, 26, 196, 154 }, new byte[] { 53, 74, 167, 140, 181, 175, 238, 31, 87, 181, 207, 204, 231, 104, 38, 106, 142, 159, 183, 20, 240, 19, 46, 52, 120, 46, 255, 185, 225, 104, 224, 251, 121, 90, 199, 155, 152, 203, 213, 169, 234, 192, 140, 146, 10, 74, 58, 148, 69, 86, 197, 200, 193, 211, 12, 219, 43, 47, 72, 189, 195, 169, 250, 183, 198, 17, 136, 67, 15, 151, 213, 191, 35, 148, 185, 187, 86, 49, 133, 83, 96, 55, 226, 181, 149, 50, 179, 222, 49, 77, 187, 130, 6, 9, 163, 182, 239, 204, 95, 139, 196, 61, 190, 211, 10, 57, 52, 66, 223, 37, 94, 116, 11, 126, 129, 27, 21, 40, 31, 141, 93, 142, 117, 10, 137, 50, 34, 216 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 242, 14, 67, 235, 125, 233, 111, 235, 68, 174, 89, 167, 157, 193, 163, 141, 199, 206, 240, 89, 148, 58, 232, 75, 224, 147, 79, 223, 21, 76, 186, 240, 46, 124, 173, 0, 211, 24, 208, 35, 48, 46, 138, 248, 26, 31, 216, 227, 194, 16, 108, 147, 37, 115, 51, 175, 226, 151, 143, 131, 140, 114, 110 }, new byte[] { 56, 30, 173, 158, 158, 246, 9, 179, 47, 96, 229, 141, 165, 45, 56, 247, 205, 40, 76, 230, 65, 221, 145, 134, 94, 248, 11, 186, 190, 75, 88, 178, 162, 142, 51, 20, 148, 213, 207, 61, 224, 251, 115, 24, 238, 95, 38, 0, 193, 142, 201, 61, 238, 203, 40, 124, 251, 108, 38, 89, 20, 240, 145, 207, 164, 196, 207, 145, 159, 184, 224, 17, 93, 96, 33, 142, 184, 207, 176, 110, 238, 118, 77, 94, 251, 9, 227, 78, 98, 20, 160, 197, 145, 173, 207, 40, 183, 136, 138, 177, 152, 177, 117, 78, 148, 105, 183, 126, 214, 31, 195, 31, 80, 201, 73, 147, 1, 142, 161, 207, 160, 81, 238, 249, 17, 30, 233, 212 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(8744));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvanceRequests");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 31, 52, 205, 185, 143, 92, 159, 232, 81, 253, 213, 74, 233, 185, 122, 190, 199, 110, 163, 34, 111, 230, 163, 160, 58, 24, 84, 89, 97, 74, 143, 87, 101, 203, 168, 22, 19, 124, 121, 9, 212, 202, 179, 22, 54, 204, 148, 137, 172, 52, 146, 61, 250, 247, 224, 214, 138, 49, 153, 172, 131, 17, 162, 29 }, new byte[] { 181, 120, 175, 233, 19, 130, 178, 191, 165, 194, 36, 139, 153, 51, 223, 22, 46, 177, 58, 28, 155, 118, 42, 198, 253, 104, 138, 122, 110, 169, 111, 127, 0, 151, 119, 210, 135, 144, 239, 12, 8, 255, 115, 51, 98, 112, 147, 158, 244, 231, 191, 61, 133, 103, 56, 116, 112, 12, 157, 49, 94, 105, 29, 31, 13, 73, 211, 182, 245, 234, 190, 179, 92, 138, 198, 3, 222, 165, 214, 73, 175, 192, 48, 71, 214, 184, 45, 97, 217, 79, 164, 217, 102, 231, 218, 124, 205, 173, 84, 82, 69, 100, 243, 3, 236, 187, 229, 130, 102, 33, 40, 196, 104, 157, 85, 250, 212, 205, 14, 227, 77, 138, 85, 10, 16, 182, 17, 26 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 72, 254, 166, 121, 114, 157, 52, 110, 82, 204, 48, 46, 23, 174, 9, 175, 128, 55, 23, 127, 145, 205, 81, 21, 165, 176, 50, 230, 227, 150, 238, 116, 61, 93, 221, 90, 104, 84, 27, 127, 127, 98, 158, 110, 29, 241, 162, 51, 113, 80, 163, 249, 53, 250, 208, 29, 156, 35, 57, 146, 211, 131, 53 }, new byte[] { 209, 200, 17, 79, 244, 190, 68, 181, 165, 145, 144, 120, 216, 62, 235, 84, 240, 150, 225, 76, 80, 40, 172, 188, 87, 14, 45, 8, 29, 67, 107, 186, 97, 97, 213, 207, 193, 24, 105, 221, 154, 19, 215, 65, 27, 162, 13, 173, 212, 176, 248, 155, 91, 33, 207, 102, 146, 184, 29, 39, 230, 192, 177, 148, 0, 129, 131, 234, 10, 139, 41, 42, 49, 254, 111, 182, 136, 152, 97, 61, 89, 192, 233, 92, 8, 106, 149, 225, 22, 56, 89, 193, 12, 16, 147, 133, 124, 86, 151, 62, 115, 72, 127, 145, 90, 254, 126, 202, 76, 250, 80, 133, 37, 113, 219, 117, 159, 191, 188, 129, 250, 154, 44, 126, 197, 237, 81, 35 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 23, 0, 19, 217, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 23, 0, 19, 217, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 23, 0, 19, 218, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 23, 0, 19, 218, DateTimeKind.Local).AddTicks(962));
        }
    }
}
