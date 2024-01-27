using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { "1997-11-11", null, "2021-01-01", new byte[] { 69, 87, 128, 37, 74, 86, 204, 223, 113, 135, 212, 210, 200, 10, 85, 70, 115, 31, 19, 121, 181, 127, 142, 219, 239, 114, 211, 12, 88, 228, 225, 140, 244, 102, 189, 123, 31, 252, 206, 140, 97, 190, 244, 126, 148, 17, 19, 98, 116, 105, 14, 230, 44, 119, 7, 44, 37, 246, 228, 99, 116, 131, 175, 181 }, new byte[] { 67, 69, 27, 95, 241, 39, 60, 227, 66, 240, 78, 141, 70, 227, 7, 76, 209, 189, 156, 162, 30, 150, 59, 230, 158, 47, 209, 217, 191, 0, 232, 11, 185, 244, 106, 159, 101, 44, 151, 189, 13, 103, 43, 221, 160, 150, 225, 124, 243, 237, 249, 209, 219, 24, 254, 76, 44, 23, 136, 147, 117, 255, 71, 93, 244, 150, 175, 172, 98, 179, 157, 108, 250, 94, 244, 83, 255, 127, 218, 40, 178, 233, 192, 86, 152, 128, 136, 45, 253, 82, 137, 83, 57, 149, 114, 130, 202, 235, 216, 229, 8, 18, 76, 216, 56, 103, 201, 201, 246, 54, 22, 198, 43, 243, 236, 132, 10, 252, 30, 79, 85, 136, 94, 107, 154, 58, 29, 129 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { "1995-11-11", null, "2021-01-01", new byte[] { 10, 20, 249, 171, 160, 244, 143, 110, 164, 251, 235, 142, 112, 185, 118, 61, 16, 44, 132, 208, 74, 201, 202, 70, 138, 3, 10, 9, 98, 136, 161, 132, 226, 192, 20, 236, 142, 168, 198, 31, 228, 86, 74, 163, 59, 185, 135, 126, 170, 129, 170, 139, 10, 49, 70, 1, 244, 63, 33, 169, 118, 29, 142, 8 }, new byte[] { 29, 50, 152, 5, 230, 200, 181, 33, 183, 194, 45, 171, 14, 93, 178, 124, 35, 74, 122, 126, 53, 74, 176, 185, 3, 11, 202, 15, 139, 162, 203, 229, 44, 73, 75, 137, 163, 55, 161, 25, 187, 56, 249, 19, 237, 106, 109, 155, 106, 39, 149, 24, 52, 51, 94, 161, 99, 50, 23, 194, 139, 46, 254, 11, 185, 33, 190, 8, 2, 103, 87, 49, 71, 252, 234, 193, 191, 55, 218, 235, 44, 235, 110, 141, 37, 222, 73, 132, 214, 184, 6, 105, 152, 166, 43, 86, 79, 140, 116, 157, 121, 235, 2, 65, 69, 4, 147, 136, 73, 252, 128, 227, 186, 73, 130, 47, 10, 48, 176, 116, 3, 129, 139, 183, 146, 231, 101, 145 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 3, 25, 594, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 3, 25, 594, DateTimeKind.Local).AddTicks(7309));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 190, 251, 175, 237, 158, 111, 220, 224, 152, 192, 190, 74, 0, 238, 9, 67, 200, 123, 172, 33, 203, 230, 137, 201, 180, 108, 39, 224, 189, 87, 8, 36, 94, 221, 13, 207, 104, 174, 143, 67, 240, 38, 198, 23, 240, 89, 239, 71, 251, 121, 127, 180, 151, 11, 221, 143, 212, 54, 16, 183, 205, 168, 141, 6 }, new byte[] { 159, 253, 52, 10, 136, 57, 159, 147, 44, 192, 134, 251, 247, 174, 153, 178, 235, 60, 97, 155, 216, 85, 134, 125, 93, 159, 164, 171, 43, 242, 93, 193, 40, 156, 161, 27, 77, 11, 147, 38, 193, 12, 23, 14, 253, 249, 250, 68, 144, 195, 26, 230, 246, 191, 229, 21, 19, 166, 66, 64, 118, 171, 46, 28, 69, 213, 226, 68, 183, 185, 47, 211, 123, 255, 252, 184, 37, 16, 101, 94, 233, 148, 177, 138, 109, 25, 213, 71, 249, 193, 18, 14, 3, 136, 199, 148, 158, 170, 135, 142, 82, 34, 161, 217, 210, 153, 120, 166, 188, 9, 175, 97, 78, 247, 43, 60, 167, 126, 94, 36, 186, 128, 67, 201, 159, 35, 246, 202 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 91, 11, 31, 152, 199, 34, 170, 192, 229, 255, 99, 4, 70, 35, 59, 63, 198, 166, 210, 226, 77, 66, 103, 40, 208, 126, 91, 92, 195, 227, 186, 53, 141, 228, 31, 95, 231, 0, 14, 57, 252, 173, 215, 22, 248, 128, 140, 163, 6, 219, 192, 173, 16, 53, 230, 32, 239, 91, 87, 46, 87, 16, 72, 210 }, new byte[] { 68, 231, 134, 157, 111, 192, 243, 5, 240, 205, 25, 229, 16, 55, 236, 113, 28, 245, 157, 143, 128, 51, 122, 210, 82, 155, 180, 215, 150, 29, 74, 213, 193, 190, 189, 83, 105, 199, 196, 223, 148, 167, 231, 207, 159, 81, 222, 72, 248, 216, 181, 164, 190, 38, 1, 173, 78, 38, 165, 163, 106, 235, 59, 231, 170, 198, 70, 40, 188, 16, 12, 25, 53, 166, 46, 212, 40, 73, 173, 145, 86, 93, 53, 74, 125, 134, 163, 154, 172, 239, 214, 85, 115, 172, 46, 167, 178, 30, 220, 189, 164, 14, 82, 58, 107, 82, 151, 30, 211, 83, 146, 99, 12, 228, 220, 47, 167, 232, 72, 244, 163, 214, 60, 249, 189, 49, 186, 72 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 21, 56, 47, 987, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 21, 56, 47, 987, DateTimeKind.Local).AddTicks(1709));
        }
    }
}
