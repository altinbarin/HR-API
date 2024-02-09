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
                column: "RequestDate",
                value: new DateTime(2024, 2, 9, 3, 29, 49, 132, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 9, 3, 29, 49, 132, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 229, 14, 247, 137, 85, 127, 18, 244, 222, 171, 136, 77, 128, 235, 185, 151, 99, 124, 214, 41, 107, 31, 65, 154, 154, 205, 181, 182, 134, 181, 247, 147, 128, 172, 30, 86, 157, 241, 55, 152, 167, 181, 120, 249, 236, 18, 243, 15, 66, 238, 226, 79, 142, 4, 104, 94, 153, 129, 117, 190, 48, 35, 235, 185 }, new byte[] { 220, 205, 12, 14, 118, 36, 252, 220, 134, 183, 165, 192, 61, 45, 115, 220, 148, 133, 56, 217, 142, 3, 220, 254, 7, 93, 196, 249, 58, 243, 12, 91, 138, 34, 42, 216, 24, 83, 1, 178, 229, 107, 77, 97, 151, 120, 198, 44, 155, 80, 155, 126, 79, 251, 88, 95, 48, 124, 45, 107, 51, 72, 121, 247, 28, 226, 182, 148, 117, 36, 184, 1, 190, 21, 19, 107, 137, 191, 115, 74, 185, 30, 252, 1, 6, 14, 135, 136, 240, 179, 104, 186, 140, 59, 120, 84, 115, 18, 161, 144, 205, 42, 163, 193, 61, 145, 3, 113, 24, 180, 150, 42, 14, 254, 39, 159, 49, 52, 20, 44, 204, 141, 254, 132, 254, 134, 28, 98 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 200, 141, 41, 74, 54, 165, 159, 7, 117, 88, 224, 13, 72, 39, 108, 16, 110, 214, 41, 222, 254, 107, 229, 178, 48, 170, 174, 127, 46, 102, 211, 161, 28, 140, 199, 163, 133, 123, 58, 156, 20, 136, 133, 90, 17, 92, 37, 96, 188, 149, 209, 247, 147, 73, 56, 148, 130, 40, 203, 54, 240, 49, 202, 181 }, new byte[] { 107, 230, 120, 242, 134, 244, 102, 28, 150, 173, 183, 204, 78, 26, 252, 130, 166, 39, 105, 105, 153, 104, 30, 175, 144, 81, 107, 242, 116, 59, 48, 0, 36, 70, 134, 201, 128, 172, 130, 181, 54, 188, 30, 51, 92, 216, 77, 122, 34, 49, 150, 146, 188, 9, 115, 72, 158, 66, 236, 64, 117, 120, 183, 34, 59, 224, 194, 197, 231, 180, 205, 94, 11, 90, 254, 35, 21, 48, 242, 164, 175, 50, 32, 100, 136, 252, 151, 50, 242, 177, 252, 99, 23, 109, 106, 7, 13, 185, 211, 42, 208, 178, 187, 133, 144, 90, 153, 249, 223, 118, 36, 124, 162, 251, 148, 60, 15, 50, 232, 133, 41, 212, 49, 63, 23, 72, 99, 121 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 11, 176, 35, 207, 178, 101, 153, 39, 152, 87, 119, 199, 9, 32, 91, 76, 242, 189, 227, 168, 75, 140, 147, 101, 223, 236, 42, 77, 248, 1, 81, 21, 160, 143, 78, 92, 72, 225, 2, 147, 130, 88, 86, 89, 94, 231, 115, 35, 19, 123, 1, 178, 222, 22, 238, 69, 249, 69, 38, 8, 5, 164, 254, 36 }, new byte[] { 195, 135, 129, 79, 206, 27, 100, 72, 80, 52, 238, 111, 145, 75, 185, 49, 188, 213, 194, 185, 244, 161, 200, 233, 79, 119, 155, 137, 179, 138, 59, 67, 178, 235, 173, 149, 241, 121, 20, 55, 11, 1, 241, 60, 101, 21, 202, 73, 152, 223, 162, 64, 4, 144, 161, 123, 19, 108, 220, 205, 132, 208, 44, 12, 126, 41, 19, 126, 9, 229, 146, 11, 7, 119, 58, 145, 202, 170, 246, 212, 224, 84, 187, 198, 223, 197, 83, 163, 22, 30, 182, 136, 24, 183, 143, 203, 7, 121, 52, 76, 64, 246, 91, 54, 5, 243, 27, 15, 134, 234, 9, 154, 66, 119, 30, 48, 21, 105, 178, 178, 127, 40, 125, 139, 22, 235, 18, 30 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 9, 3, 29, 49, 133, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 9, 3, 29, 49, 133, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 9, 3, 29, 49, 134, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 9, 3, 29, 49, 134, DateTimeKind.Local).AddTicks(867));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 102, 50, 168, 129, 127, 56, 47, 221, 159, 10, 252, 5, 253, 232, 102, 218, 88, 82, 252, 167, 165, 58, 6, 244, 94, 231, 79, 6, 191, 64, 93, 5, 184, 84, 162, 62, 42, 156, 90, 1, 44, 26, 224, 2, 165, 130, 139, 11, 20, 223, 56, 139, 199, 95, 22, 11, 155, 247, 6, 45, 251, 10, 60 }, new byte[] { 216, 135, 95, 69, 15, 73, 184, 68, 182, 199, 117, 149, 215, 110, 21, 188, 239, 22, 41, 222, 24, 125, 78, 250, 169, 70, 123, 17, 17, 138, 206, 95, 86, 213, 80, 123, 64, 91, 224, 101, 126, 164, 82, 195, 146, 240, 88, 168, 214, 128, 115, 226, 173, 8, 57, 120, 8, 15, 224, 242, 96, 207, 167, 98, 6, 47, 124, 39, 108, 144, 205, 63, 127, 92, 199, 29, 232, 73, 55, 74, 234, 151, 134, 150, 217, 85, 111, 123, 153, 129, 181, 204, 130, 148, 93, 200, 54, 11, 238, 82, 111, 105, 248, 79, 28, 57, 122, 245, 121, 92, 136, 207, 166, 187, 209, 50, 118, 129, 145, 59, 48, 148, 42, 153, 173, 254, 39, 192 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 147, 130, 44, 80, 250, 119, 15, 34, 32, 198, 82, 44, 155, 87, 240, 41, 203, 213, 29, 54, 66, 28, 37, 67, 210, 104, 164, 214, 20, 174, 176, 253, 33, 206, 124, 13, 83, 240, 131, 210, 207, 35, 82, 171, 215, 101, 62, 72, 83, 23, 9, 117, 137, 162, 103, 175, 28, 247, 98, 163, 64, 227, 152, 179 }, new byte[] { 9, 173, 204, 253, 224, 85, 64, 254, 39, 20, 100, 66, 44, 172, 127, 154, 230, 2, 137, 89, 26, 93, 180, 188, 121, 212, 218, 25, 195, 79, 167, 110, 27, 205, 81, 113, 33, 222, 72, 108, 169, 236, 213, 230, 107, 178, 38, 119, 175, 180, 170, 170, 50, 28, 151, 146, 220, 84, 80, 196, 27, 146, 159, 0, 152, 162, 74, 74, 21, 221, 18, 73, 53, 0, 132, 6, 218, 77, 59, 25, 82, 4, 53, 151, 125, 7, 66, 112, 70, 89, 108, 25, 127, 122, 5, 244, 91, 116, 33, 84, 27, 170, 138, 132, 148, 86, 114, 70, 73, 103, 94, 89, 57, 195, 253, 68, 122, 187, 180, 87, 196, 177, 161, 135, 133, 145, 228, 21 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 19, 157, 255, 253, 193, 89, 243, 103, 237, 102, 71, 128, 15, 92, 201, 229, 63, 151, 189, 11, 91, 210, 198, 147, 122, 224, 154, 10, 186, 223, 64, 65, 73, 136, 106, 123, 234, 35, 136, 118, 160, 189, 175, 242, 110, 240, 225, 95, 20, 190, 21, 23, 186, 175, 97, 80, 61, 234, 219, 90, 176, 215, 191 }, new byte[] { 136, 53, 86, 203, 40, 167, 190, 37, 219, 165, 10, 152, 171, 93, 61, 220, 120, 144, 200, 126, 241, 141, 213, 149, 152, 136, 128, 62, 85, 84, 169, 176, 17, 91, 69, 119, 218, 220, 221, 168, 249, 236, 192, 153, 167, 95, 80, 82, 135, 168, 172, 83, 167, 169, 166, 222, 65, 129, 53, 255, 156, 30, 97, 228, 103, 155, 118, 162, 37, 172, 167, 120, 134, 194, 87, 85, 157, 170, 0, 92, 239, 136, 189, 196, 157, 230, 140, 88, 204, 140, 252, 112, 198, 193, 65, 103, 228, 25, 254, 201, 142, 137, 73, 3, 181, 157, 59, 76, 152, 197, 253, 39, 251, 49, 135, 235, 144, 143, 160, 105, 33, 223, 111, 189, 46, 53, 234, 197 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 8, 21, 20, 36, 478, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 8, 21, 20, 36, 479, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 8, 21, 20, 36, 479, DateTimeKind.Local).AddTicks(7443));
        }
    }
}
