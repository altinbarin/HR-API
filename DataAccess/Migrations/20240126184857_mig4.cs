using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
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
                values: new object[] { new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 145, 10, 203, 247, 8, 60, 222, 179, 43, 122, 0, 83, 0, 215, 227, 178, 167, 229, 164, 125, 105, 185, 152, 90, 244, 52, 243, 213, 114, 41, 47, 121, 146, 115, 181, 27, 123, 217, 87, 33, 180, 1, 73, 37, 163, 67, 214, 141, 226, 60, 176, 151, 77, 204, 142, 30, 251, 21, 132, 133, 235, 106, 27, 88 }, new byte[] { 84, 156, 47, 24, 112, 200, 112, 244, 169, 51, 163, 120, 86, 182, 238, 191, 165, 168, 54, 106, 50, 92, 163, 42, 150, 179, 191, 104, 17, 106, 80, 182, 222, 106, 66, 28, 253, 199, 85, 79, 18, 212, 158, 118, 18, 17, 194, 240, 146, 50, 115, 208, 221, 180, 5, 105, 87, 120, 101, 221, 11, 62, 114, 178, 226, 51, 84, 190, 245, 152, 209, 40, 17, 138, 9, 53, 123, 246, 145, 96, 30, 180, 214, 210, 251, 29, 40, 193, 169, 203, 171, 92, 252, 255, 96, 123, 230, 93, 233, 137, 21, 116, 44, 230, 255, 202, 130, 137, 179, 103, 98, 178, 119, 138, 248, 195, 220, 46, 205, 39, 238, 80, 19, 109, 245, 162, 215, 50 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 84, 140, 126, 14, 28, 208, 13, 148, 229, 203, 234, 36, 146, 184, 85, 24, 227, 129, 143, 197, 37, 155, 179, 20, 2, 35, 42, 22, 69, 83, 141, 168, 173, 123, 133, 15, 190, 134, 31, 144, 193, 245, 230, 158, 32, 239, 63, 212, 7, 212, 174, 115, 141, 42, 25, 219, 118, 216, 27, 128, 6, 167, 106, 145 }, new byte[] { 242, 197, 95, 32, 183, 61, 198, 95, 185, 119, 241, 147, 248, 83, 221, 38, 10, 171, 85, 58, 167, 56, 133, 195, 139, 60, 235, 96, 239, 165, 60, 80, 212, 212, 238, 153, 114, 139, 225, 20, 146, 22, 99, 6, 195, 233, 105, 120, 244, 243, 249, 186, 117, 93, 190, 94, 140, 78, 147, 22, 83, 226, 5, 167, 175, 93, 217, 42, 12, 80, 236, 225, 247, 231, 246, 11, 252, 84, 18, 189, 120, 39, 72, 139, 121, 242, 69, 4, 64, 10, 38, 155, 18, 53, 251, 217, 160, 197, 3, 244, 26, 119, 226, 77, 242, 172, 226, 203, 237, 238, 104, 68, 48, 241, 190, 163, 205, 91, 191, 169, 122, 109, 70, 234, 190, 142, 48, 218 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 21, 11, 5, 773, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 21, 11, 5, 773, DateTimeKind.Local).AddTicks(3223));
        }
    }
}
