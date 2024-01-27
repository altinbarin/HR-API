using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "1997-11-11", null, "2021-01-01", new byte[] { 133, 91, 19, 70, 21, 11, 189, 97, 119, 203, 175, 52, 10, 0, 201, 90, 108, 17, 56, 41, 186, 29, 87, 117, 21, 219, 194, 229, 18, 182, 246, 70, 65, 65, 18, 31, 186, 214, 198, 103, 177, 19, 14, 143, 127, 96, 251, 232, 245, 90, 161, 45, 142, 166, 163, 217, 45, 98, 212, 187, 191, 15, 90, 20 }, new byte[] { 100, 151, 128, 135, 214, 24, 1, 43, 178, 73, 131, 157, 85, 86, 72, 98, 205, 247, 30, 134, 254, 26, 76, 70, 68, 23, 180, 62, 26, 145, 104, 193, 164, 185, 18, 77, 9, 37, 75, 69, 151, 23, 94, 0, 192, 216, 60, 33, 10, 57, 85, 149, 118, 57, 94, 104, 115, 152, 141, 9, 236, 64, 58, 244, 112, 14, 48, 66, 220, 113, 36, 148, 140, 57, 165, 249, 219, 138, 93, 133, 129, 51, 39, 81, 233, 242, 161, 172, 21, 3, 151, 166, 95, 87, 40, 40, 91, 42, 204, 247, 242, 217, 230, 56, 0, 32, 156, 120, 48, 96, 46, 149, 21, 167, 134, 233, 84, 114, 186, 55, 65, 31, 204, 73, 166, 13, 166, 66 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { "1995-11-11", null, "2021-01-01", new byte[] { 90, 0, 35, 180, 114, 12, 207, 28, 42, 8, 0, 77, 80, 103, 81, 127, 64, 226, 247, 13, 16, 20, 134, 196, 125, 207, 56, 227, 143, 141, 143, 187, 142, 98, 21, 193, 54, 28, 190, 83, 198, 124, 191, 23, 226, 57, 159, 228, 217, 236, 219, 189, 143, 200, 24, 115, 23, 66, 248, 227, 198, 240, 20, 220 }, new byte[] { 97, 70, 152, 172, 16, 99, 0, 210, 55, 224, 117, 187, 196, 89, 14, 132, 31, 227, 121, 90, 84, 144, 109, 161, 250, 223, 229, 160, 2, 182, 245, 214, 69, 197, 212, 250, 62, 154, 134, 60, 247, 255, 240, 225, 14, 113, 67, 41, 98, 0, 254, 67, 90, 11, 189, 196, 135, 12, 93, 246, 252, 175, 37, 52, 138, 220, 251, 67, 73, 220, 26, 227, 39, 98, 183, 191, 40, 205, 46, 232, 97, 143, 15, 152, 213, 244, 149, 134, 48, 128, 148, 67, 87, 139, 253, 98, 72, 197, 199, 193, 122, 151, 45, 214, 208, 47, 241, 60, 203, 150, 101, 221, 196, 45, 137, 216, 69, 98, 3, 36, 214, 173, 223, 85, 21, 163, 128, 186 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 21, 48, 56, 972, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 21, 48, 56, 972, DateTimeKind.Local).AddTicks(3323));
        }
    }
}
