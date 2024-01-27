using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTimeOffset(new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new byte[] { 9, 75, 227, 109, 174, 144, 126, 221, 28, 191, 20, 133, 54, 204, 52, 38, 228, 198, 97, 168, 19, 1, 220, 79, 241, 175, 0, 51, 30, 4, 223, 148, 170, 172, 252, 102, 185, 255, 195, 198, 245, 138, 145, 216, 98, 17, 140, 218, 109, 188, 139, 179, 53, 61, 255, 164, 127, 34, 201, 30, 134, 47, 44, 223 }, new byte[] { 249, 216, 126, 45, 170, 187, 202, 218, 110, 162, 165, 110, 133, 139, 62, 96, 24, 159, 131, 164, 59, 74, 116, 50, 7, 54, 82, 242, 13, 30, 74, 77, 198, 182, 109, 155, 105, 248, 125, 173, 76, 197, 95, 193, 91, 76, 238, 155, 60, 206, 223, 174, 131, 80, 193, 250, 94, 164, 134, 96, 172, 47, 169, 167, 246, 53, 3, 101, 87, 14, 182, 89, 151, 174, 156, 39, 22, 90, 76, 47, 48, 221, 30, 9, 78, 226, 27, 240, 121, 17, 114, 133, 78, 86, 168, 149, 61, 230, 44, 35, 98, 106, 91, 179, 181, 250, 86, 16, 65, 208, 126, 130, 139, 252, 150, 88, 232, 118, 248, 178, 128, 66, 63, 56, 177, 141, 12, 160 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTimeOffset(new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new byte[] { 249, 164, 8, 45, 193, 174, 25, 55, 254, 241, 0, 220, 138, 232, 130, 214, 194, 252, 91, 144, 188, 171, 179, 120, 46, 69, 228, 12, 35, 97, 60, 218, 144, 130, 164, 171, 24, 73, 254, 154, 243, 146, 175, 236, 121, 114, 168, 114, 244, 80, 202, 61, 154, 198, 202, 64, 60, 122, 68, 80, 158, 216, 36, 117 }, new byte[] { 210, 77, 139, 104, 128, 96, 35, 112, 13, 231, 88, 112, 46, 248, 59, 181, 2, 38, 0, 39, 203, 146, 234, 235, 205, 132, 38, 157, 222, 7, 79, 78, 250, 86, 188, 60, 0, 167, 52, 31, 211, 180, 121, 99, 26, 19, 202, 202, 6, 105, 239, 222, 59, 153, 102, 174, 195, 95, 220, 53, 213, 145, 106, 227, 23, 108, 56, 143, 198, 240, 0, 8, 204, 180, 6, 70, 152, 61, 185, 188, 196, 244, 170, 180, 181, 206, 112, 54, 156, 151, 45, 124, 125, 104, 64, 35, 72, 141, 65, 1, 207, 7, 119, 188, 85, 47, 186, 118, 69, 207, 251, 158, 56, 146, 131, 62, 58, 18, 17, 175, 212, 107, 13, 25, 196, 230, 111, 249 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 7, 34, 765, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 7, 34, 765, DateTimeKind.Local).AddTicks(5822));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

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
    }
}
