using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migcanli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 674, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 674, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 139, 105, 189, 53, 88, 41, 153, 187, 35, 191, 68, 235, 250, 29, 175, 50, 180, 194, 80, 62, 221, 190, 82, 220, 77, 79, 252, 137, 154, 130, 27, 229, 37, 43, 137, 221, 204, 177, 77, 31, 160, 234, 134, 237, 238, 192, 75, 156, 97, 33, 183, 135, 209, 105, 232, 85, 230, 210, 124, 140, 133, 144, 94, 234 }, new byte[] { 248, 35, 18, 59, 104, 145, 36, 238, 148, 136, 131, 195, 22, 184, 248, 111, 105, 240, 100, 216, 3, 149, 103, 61, 26, 77, 33, 227, 96, 185, 173, 175, 28, 192, 72, 46, 225, 27, 183, 223, 57, 252, 45, 222, 171, 71, 136, 51, 47, 134, 110, 181, 80, 54, 217, 23, 194, 78, 42, 209, 190, 76, 50, 47, 202, 10, 237, 87, 194, 226, 214, 236, 30, 159, 19, 44, 149, 233, 199, 98, 235, 54, 33, 95, 123, 141, 59, 90, 31, 185, 122, 115, 11, 16, 222, 59, 242, 133, 113, 56, 227, 11, 9, 62, 5, 239, 72, 95, 244, 80, 140, 57, 213, 74, 139, 165, 75, 61, 69, 51, 112, 227, 198, 183, 138, 132, 118, 171 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 247, 99, 213, 186, 187, 201, 228, 183, 221, 225, 11, 115, 93, 82, 213, 91, 62, 10, 43, 81, 194, 197, 16, 36, 137, 26, 22, 236, 112, 132, 136, 78, 227, 253, 153, 101, 55, 35, 4, 152, 97, 210, 36, 35, 235, 115, 70, 200, 137, 126, 151, 99, 62, 11, 116, 76, 12, 122, 222, 217, 210, 78, 74, 10 }, new byte[] { 55, 111, 98, 158, 56, 95, 138, 234, 28, 241, 29, 129, 108, 169, 98, 171, 17, 107, 121, 160, 119, 238, 56, 124, 185, 140, 199, 182, 225, 61, 42, 242, 49, 238, 246, 210, 149, 78, 128, 240, 124, 228, 231, 128, 123, 194, 116, 167, 10, 36, 103, 216, 176, 24, 75, 77, 138, 184, 148, 217, 186, 132, 219, 198, 5, 254, 71, 102, 31, 61, 159, 109, 6, 224, 79, 31, 129, 185, 139, 34, 169, 186, 80, 247, 171, 234, 205, 20, 240, 75, 157, 182, 233, 3, 142, 131, 218, 252, 223, 244, 8, 225, 125, 228, 37, 99, 156, 152, 253, 173, 60, 235, 71, 112, 132, 104, 74, 125, 167, 73, 208, 217, 181, 9, 193, 221, 167, 24 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(9386));
        }
    }
}
