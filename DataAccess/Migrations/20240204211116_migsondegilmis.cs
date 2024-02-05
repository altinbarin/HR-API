using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migsondegilmis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FolderName",
                table: "SpendingRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 5, 0, 11, 16, 190, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 5, 0, 11, 16, 190, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 84, 244, 112, 207, 247, 178, 129, 236, 44, 204, 204, 178, 0, 110, 211, 48, 87, 98, 208, 222, 254, 84, 13, 29, 21, 150, 234, 61, 11, 237, 212, 30, 98, 170, 121, 3, 132, 238, 120, 25, 237, 177, 89, 87, 88, 158, 43, 214, 72, 205, 208, 242, 51, 111, 30, 52, 98, 232, 94, 159, 101, 104, 249 }, new byte[] { 111, 7, 179, 124, 52, 58, 186, 80, 46, 6, 120, 160, 127, 52, 109, 98, 190, 192, 49, 64, 25, 130, 213, 99, 17, 111, 246, 116, 25, 204, 215, 40, 236, 162, 205, 150, 90, 103, 90, 185, 186, 121, 23, 55, 23, 65, 194, 32, 3, 177, 178, 40, 169, 214, 44, 129, 92, 125, 161, 166, 51, 20, 29, 10, 11, 47, 234, 129, 105, 159, 120, 68, 44, 174, 241, 181, 126, 69, 44, 96, 139, 228, 160, 4, 220, 132, 71, 110, 132, 56, 98, 20, 120, 254, 131, 230, 32, 98, 203, 187, 186, 22, 160, 140, 3, 240, 186, 123, 127, 173, 51, 165, 85, 22, 124, 127, 30, 105, 238, 233, 206, 65, 230, 196, 225, 190, 213, 38 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 41, 231, 237, 6, 240, 71, 252, 36, 32, 85, 128, 163, 81, 195, 96, 57, 202, 248, 177, 165, 106, 37, 23, 135, 171, 19, 82, 12, 13, 161, 179, 46, 110, 59, 171, 163, 9, 83, 250, 5, 32, 199, 227, 2, 171, 220, 36, 138, 90, 118, 101, 242, 63, 233, 109, 168, 219, 27, 152, 88, 35, 75, 131 }, new byte[] { 22, 134, 247, 213, 23, 95, 193, 162, 201, 82, 47, 24, 49, 106, 127, 92, 240, 34, 130, 111, 170, 74, 225, 213, 231, 199, 75, 1, 5, 132, 184, 135, 189, 44, 112, 29, 198, 155, 197, 166, 58, 189, 241, 53, 246, 241, 226, 151, 109, 25, 234, 132, 114, 83, 245, 197, 80, 63, 41, 66, 223, 16, 118, 151, 104, 206, 239, 182, 198, 132, 184, 131, 12, 43, 117, 228, 204, 7, 4, 156, 153, 251, 221, 114, 136, 132, 197, 240, 132, 194, 26, 50, 175, 76, 153, 126, 171, 226, 160, 83, 245, 124, 82, 224, 183, 60, 13, 139, 107, 147, 158, 177, 85, 87, 224, 151, 215, 205, 181, 115, 211, 244, 172, 68, 72, 190, 29, 139 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 184, 104, 204, 141, 152, 13, 201, 66, 230, 79, 244, 180, 22, 235, 136, 209, 115, 215, 212, 38, 198, 87, 43, 87, 132, 162, 167, 238, 191, 74, 68, 4, 16, 98, 135, 255, 221, 39, 234, 26, 244, 183, 70, 74, 193, 139, 250, 237, 189, 36, 177, 106, 37, 38, 122, 97, 68, 38, 210, 180, 45, 96, 9, 100 }, new byte[] { 217, 90, 220, 107, 178, 218, 76, 159, 32, 190, 47, 36, 223, 197, 94, 6, 116, 162, 76, 128, 39, 72, 58, 64, 255, 18, 80, 241, 28, 94, 68, 15, 30, 217, 237, 151, 222, 157, 31, 213, 54, 194, 20, 92, 239, 123, 234, 0, 35, 25, 194, 174, 216, 64, 220, 15, 206, 82, 171, 141, 45, 135, 85, 44, 49, 163, 245, 124, 111, 92, 137, 164, 162, 126, 234, 246, 63, 145, 200, 46, 24, 54, 117, 118, 8, 124, 197, 86, 51, 250, 127, 178, 150, 40, 218, 125, 67, 233, 102, 1, 95, 55, 8, 239, 198, 126, 108, 176, 178, 104, 249, 143, 168, 16, 235, 90, 171, 141, 181, 74, 193, 39, 42, 227, 32, 171, 21, 138 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FolderName", "RequestDate" },
                values: new object[] { null, new DateTime(2024, 2, 5, 0, 11, 16, 191, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FolderName", "RequestDate" },
                values: new object[] { null, new DateTime(2024, 2, 5, 0, 11, 16, 191, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 5, 0, 11, 16, 192, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 5, 0, 11, 16, 192, DateTimeKind.Local).AddTicks(2668));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FolderName",
                table: "SpendingRequests");

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 2, 4, 20, 49, 32, 456, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 2, 4, 20, 49, 32, 456, DateTimeKind.Local).AddTicks(4930));

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
    }
}
