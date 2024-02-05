using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class son : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Currency", "RequestDate" },
                values: new object[] { "₺", new DateTime(2024, 2, 4, 20, 49, 32, 456, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Currency", "RequestDate" },
                values: new object[] { "₺", new DateTime(2024, 2, 4, 20, 49, 32, 456, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 163, 114, 163, 145, 124, 228, 57, 198, 96, 129, 198, 205, 17, 185, 100, 176, 116, 162, 221, 237, 74, 15, 56, 241, 161, 153, 41, 115, 60, 184, 115, 17, 250, 67, 187, 92, 47, 63, 235, 120, 218, 247, 189, 36, 240, 28, 185, 88, 226, 117, 237, 36, 8, 94, 90, 234, 84, 65, 129, 21, 18, 89, 37 }, new byte[] { 127, 24, 93, 59, 68, 181, 208, 141, 197, 71, 77, 102, 20, 192, 206, 198, 174, 105, 128, 218, 8, 201, 118, 45, 37, 73, 130, 190, 184, 211, 102, 41, 225, 154, 223, 200, 37, 165, 201, 210, 23, 174, 42, 249, 247, 122, 21, 252, 82, 194, 236, 173, 192, 77, 208, 91, 116, 46, 161, 7, 61, 22, 198, 255, 31, 70, 243, 37, 91, 148, 185, 212, 204, 34, 199, 115, 110, 134, 224, 211, 207, 87, 173, 98, 89, 95, 2, 91, 41, 242, 159, 1, 247, 89, 39, 180, 124, 73, 2, 201, 86, 22, 138, 16, 229, 4, 206, 190, 222, 117, 64, 101, 202, 205, 6, 28, 125, 211, 12, 231, 232, 52, 153, 182, 194, 187, 94, 76 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 241, 146, 212, 211, 49, 58, 85, 42, 102, 105, 93, 196, 30, 231, 116, 34, 181, 189, 99, 46, 150, 19, 123, 152, 18, 55, 203, 158, 201, 125, 69, 170, 154, 238, 183, 84, 128, 41, 225, 117, 239, 59, 173, 193, 192, 173, 47, 5, 9, 150, 221, 82, 163, 194, 159, 137, 189, 3, 92, 37, 148, 170, 33, 96 }, new byte[] { 146, 136, 136, 204, 146, 65, 215, 69, 100, 230, 85, 187, 46, 225, 168, 79, 68, 143, 173, 116, 51, 145, 190, 235, 134, 22, 174, 77, 27, 118, 81, 157, 139, 101, 80, 223, 177, 225, 57, 8, 136, 40, 115, 190, 252, 114, 155, 206, 243, 99, 39, 78, 64, 12, 134, 23, 4, 120, 225, 77, 132, 103, 42, 45, 248, 19, 194, 214, 50, 104, 9, 39, 8, 88, 248, 92, 206, 238, 24, 228, 37, 56, 13, 140, 175, 189, 249, 80, 89, 219, 238, 129, 237, 22, 94, 240, 26, 136, 88, 179, 113, 240, 101, 39, 150, 191, 252, 215, 164, 213, 223, 251, 138, 39, 163, 52, 164, 203, 99, 244, 96, 101, 171, 0, 165, 31, 155, 25 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 219, 207, 101, 251, 62, 118, 39, 119, 39, 9, 255, 238, 107, 12, 36, 207, 45, 244, 79, 50, 96, 234, 231, 185, 14, 84, 235, 140, 15, 153, 67, 69, 146, 52, 74, 66, 23, 252, 137, 177, 99, 94, 103, 56, 34, 252, 8, 187, 234, 254, 48, 45, 153, 119, 15, 232, 123, 63, 220, 208, 105, 52, 238 }, new byte[] { 108, 174, 19, 143, 47, 159, 147, 204, 61, 176, 43, 21, 61, 249, 47, 182, 192, 41, 150, 14, 161, 205, 114, 65, 103, 71, 115, 192, 24, 70, 135, 4, 32, 253, 108, 184, 81, 76, 111, 220, 191, 196, 102, 254, 145, 174, 245, 117, 165, 29, 126, 160, 128, 136, 188, 153, 160, 7, 82, 147, 38, 81, 240, 195, 198, 194, 34, 54, 153, 166, 29, 31, 66, 62, 9, 49, 149, 95, 29, 135, 233, 228, 175, 72, 86, 4, 235, 35, 28, 252, 4, 251, 246, 182, 214, 214, 21, 58, 231, 250, 69, 30, 69, 67, 109, 44, 219, 201, 90, 198, 95, 142, 202, 185, 65, 230, 50, 236, 101, 246, 196, 194, 191, 7, 158, 237, 40, 106 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 4, 20, 49, 32, 457, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 4, 20, 49, 32, 457, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 4, 20, 49, 32, 458, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 4, 20, 49, 32, 458, DateTimeKind.Local).AddTicks(2628));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Currency", "RequestDate" },
                values: new object[] { "TL", new DateTime(2024, 2, 1, 20, 12, 25, 272, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Currency", "RequestDate" },
                values: new object[] { "TL", new DateTime(2024, 2, 1, 20, 12, 25, 272, DateTimeKind.Local).AddTicks(8397) });

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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 9, 123, 238, 77, 77, 66, 149, 25, 202, 206, 97, 177, 89, 25, 246, 55, 125, 55, 210, 176, 93, 166, 220, 200, 160, 227, 147, 81, 25, 126, 160, 1, 231, 106, 122, 174, 92, 59, 199, 14, 126, 47, 54, 110, 117, 79, 145, 102, 202, 155, 53, 231, 177, 44, 229, 207, 121, 124, 220, 70, 88, 240, 176 }, new byte[] { 212, 34, 101, 80, 46, 174, 210, 170, 136, 158, 73, 164, 189, 10, 180, 249, 116, 197, 137, 108, 114, 127, 183, 198, 100, 92, 38, 25, 206, 168, 253, 229, 12, 131, 216, 105, 120, 251, 197, 252, 136, 53, 139, 110, 242, 186, 2, 251, 122, 166, 130, 252, 180, 159, 156, 168, 209, 204, 251, 29, 123, 89, 228, 34, 84, 22, 145, 197, 18, 46, 246, 21, 27, 113, 19, 71, 183, 121, 195, 214, 44, 4, 28, 16, 186, 120, 53, 126, 249, 198, 132, 194, 209, 220, 127, 208, 125, 74, 106, 66, 28, 33, 23, 84, 92, 73, 7, 5, 175, 64, 49, 55, 214, 222, 22, 99, 97, 200, 55, 41, 77, 232, 189, 33, 25, 120, 80, 249 } });

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
    }
}
