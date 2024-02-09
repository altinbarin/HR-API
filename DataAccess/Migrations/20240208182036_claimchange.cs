using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class claimchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "empty" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 7, 2, 13, 5, 284, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 7, 2, 13, 5, 284, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 35, 120, 255, 13, 227, 233, 118, 236, 200, 19, 57, 254, 38, 51, 43, 69, 71, 179, 243, 175, 162, 32, 159, 252, 132, 32, 241, 217, 149, 201, 21, 95, 202, 67, 113, 55, 84, 155, 250, 115, 19, 182, 169, 157, 204, 72, 141, 226, 149, 80, 14, 34, 78, 135, 92, 156, 211, 126, 150, 86, 1, 66, 90, 250 }, new byte[] { 109, 131, 29, 105, 235, 143, 78, 77, 101, 136, 238, 149, 240, 40, 41, 23, 231, 7, 81, 172, 90, 208, 219, 27, 93, 221, 183, 38, 129, 107, 77, 87, 9, 124, 172, 172, 160, 233, 155, 152, 199, 166, 161, 49, 22, 111, 16, 219, 194, 10, 159, 20, 49, 134, 230, 167, 99, 18, 107, 70, 165, 190, 1, 75, 75, 102, 162, 95, 150, 162, 126, 134, 99, 250, 128, 67, 112, 149, 150, 245, 89, 205, 52, 44, 90, 158, 160, 190, 174, 201, 63, 163, 111, 192, 109, 84, 55, 65, 220, 137, 111, 135, 170, 157, 131, 223, 31, 21, 161, 19, 148, 185, 66, 19, 131, 119, 93, 165, 1, 243, 98, 217, 239, 133, 64, 245, 211, 170 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 29, 79, 175, 138, 48, 159, 72, 210, 209, 126, 16, 18, 194, 147, 32, 50, 62, 124, 49, 209, 236, 250, 162, 138, 94, 168, 184, 93, 196, 195, 212, 190, 194, 76, 195, 255, 109, 94, 13, 12, 160, 238, 158, 119, 179, 172, 239, 75, 0, 130, 56, 83, 104, 21, 191, 210, 235, 209, 157, 80, 222, 145, 82, 181 }, new byte[] { 156, 174, 8, 100, 39, 183, 61, 192, 79, 173, 140, 140, 67, 202, 24, 5, 239, 168, 86, 31, 112, 193, 168, 52, 8, 104, 186, 236, 134, 114, 133, 51, 107, 169, 159, 140, 56, 23, 217, 235, 70, 117, 21, 63, 226, 249, 254, 222, 75, 147, 213, 43, 204, 107, 24, 71, 59, 94, 59, 118, 16, 164, 135, 65, 120, 221, 173, 196, 48, 13, 44, 106, 102, 223, 115, 18, 27, 46, 239, 82, 141, 45, 76, 126, 143, 157, 129, 56, 4, 245, 17, 37, 123, 199, 249, 75, 115, 101, 26, 225, 40, 166, 99, 63, 58, 41, 10, 70, 198, 196, 162, 157, 31, 3, 45, 164, 16, 106, 160, 116, 122, 38, 31, 95, 62, 158, 208, 140 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 228, 134, 185, 20, 79, 33, 109, 119, 96, 70, 137, 250, 112, 21, 102, 17, 127, 117, 234, 44, 211, 251, 174, 165, 51, 78, 108, 127, 236, 197, 154, 82, 98, 53, 111, 213, 101, 89, 13, 8, 247, 219, 141, 163, 248, 91, 242, 102, 124, 15, 190, 42, 48, 32, 175, 14, 250, 161, 204, 237, 192, 38, 136 }, new byte[] { 180, 245, 55, 132, 51, 147, 130, 46, 3, 19, 68, 45, 236, 17, 196, 36, 202, 171, 233, 203, 166, 8, 215, 185, 186, 215, 127, 190, 229, 4, 179, 94, 76, 38, 91, 84, 163, 37, 79, 44, 252, 164, 82, 222, 83, 149, 13, 49, 197, 237, 171, 123, 128, 50, 47, 110, 14, 219, 200, 234, 224, 9, 214, 32, 140, 79, 61, 200, 102, 181, 231, 90, 46, 149, 53, 220, 27, 68, 169, 132, 126, 20, 201, 249, 203, 227, 162, 50, 58, 67, 251, 152, 58, 129, 85, 153, 65, 247, 65, 87, 117, 153, 209, 39, 208, 68, 142, 120, 192, 180, 214, 199, 251, 54, 153, 119, 244, 76, 214, 29, 231, 227, 17, 213, 176, 207, 98, 133 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 7, 2, 13, 5, 285, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 7, 2, 13, 5, 285, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 7, 2, 13, 5, 286, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 7, 2, 13, 5, 286, DateTimeKind.Local).AddTicks(929));
        }
    }
}
