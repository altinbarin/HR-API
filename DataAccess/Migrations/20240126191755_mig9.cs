using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 173, 37, 128, 224, 190, 218, 24, 26, 9, 232, 230, 128, 191, 20, 223, 13, 83, 168, 80, 6, 75, 20, 144, 140, 3, 136, 228, 7, 249, 66, 197, 119, 207, 15, 85, 175, 215, 133, 212, 133, 70, 100, 158, 45, 145, 85, 155, 174, 144, 110, 215, 65, 35, 141, 158, 127, 248, 18, 117, 247, 105, 41, 188, 29 }, new byte[] { 117, 80, 84, 57, 180, 118, 130, 72, 250, 34, 60, 207, 42, 142, 249, 34, 101, 150, 118, 102, 204, 33, 189, 239, 156, 82, 153, 49, 190, 166, 133, 41, 117, 109, 28, 150, 250, 79, 15, 254, 103, 141, 102, 164, 249, 121, 24, 13, 94, 82, 159, 144, 227, 131, 239, 111, 46, 73, 182, 65, 45, 181, 63, 185, 120, 13, 170, 24, 40, 25, 67, 19, 154, 60, 182, 2, 131, 189, 158, 111, 13, 110, 148, 5, 111, 116, 101, 185, 190, 239, 52, 72, 212, 243, 173, 142, 49, 133, 135, 113, 70, 152, 89, 242, 194, 226, 46, 43, 178, 230, 222, 223, 63, 92, 153, 201, 81, 239, 116, 131, 255, 30, 200, 211, 69, 120, 235, 5 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 83, 182, 167, 177, 64, 5, 81, 49, 115, 145, 247, 51, 136, 27, 22, 233, 226, 53, 203, 129, 122, 137, 10, 130, 117, 194, 210, 38, 100, 116, 52, 100, 172, 220, 86, 233, 25, 111, 230, 218, 247, 226, 101, 49, 1, 58, 136, 71, 191, 131, 92, 188, 206, 189, 205, 199, 205, 74, 204, 86, 109, 210, 167, 53 }, new byte[] { 237, 246, 240, 36, 85, 96, 224, 130, 180, 235, 135, 59, 240, 244, 208, 10, 163, 227, 57, 204, 216, 1, 12, 187, 182, 220, 125, 177, 168, 21, 203, 5, 126, 97, 181, 240, 197, 250, 234, 102, 28, 221, 15, 253, 250, 161, 214, 158, 90, 224, 239, 19, 28, 174, 123, 151, 227, 132, 226, 40, 109, 136, 27, 81, 190, 73, 149, 42, 17, 38, 92, 147, 230, 28, 183, 81, 39, 61, 81, 98, 148, 212, 0, 147, 94, 29, 174, 159, 158, 151, 63, 126, 192, 65, 205, 236, 108, 155, 100, 116, 126, 114, 223, 81, 90, 73, 230, 97, 4, 159, 198, 168, 216, 89, 148, 240, 49, 142, 215, 36, 183, 14, 11, 165, 116, 216, 59, 151 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 17, 54, 744, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 17, 54, 744, DateTimeKind.Local).AddTicks(8210));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfEmployment",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfDismissal",
                table: "Employees",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateOfBirth",
                table: "Employees",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTimeOffset(new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new byte[] { 193, 105, 156, 9, 31, 194, 11, 28, 0, 36, 106, 161, 117, 63, 170, 44, 151, 18, 248, 75, 247, 151, 82, 9, 54, 168, 48, 242, 131, 92, 223, 149, 69, 207, 142, 191, 106, 39, 78, 80, 133, 47, 20, 137, 104, 216, 215, 175, 89, 35, 111, 89, 87, 76, 197, 73, 79, 110, 225, 193, 63, 151, 213, 64 }, new byte[] { 226, 210, 103, 102, 186, 123, 180, 2, 193, 128, 118, 161, 195, 19, 129, 101, 151, 254, 153, 144, 226, 76, 45, 89, 36, 30, 101, 78, 40, 14, 145, 84, 235, 15, 75, 19, 84, 230, 122, 95, 246, 218, 184, 34, 63, 77, 206, 115, 57, 235, 240, 239, 182, 254, 45, 76, 89, 102, 215, 238, 139, 14, 117, 21, 154, 94, 111, 89, 79, 187, 183, 7, 29, 147, 225, 255, 222, 188, 242, 117, 189, 69, 230, 152, 30, 189, 158, 193, 4, 10, 51, 38, 238, 232, 40, 253, 15, 114, 16, 16, 38, 118, 231, 37, 85, 52, 55, 142, 158, 81, 86, 109, 109, 59, 185, 209, 8, 255, 117, 13, 192, 80, 206, 232, 7, 193, 160, 35 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTimeOffset(new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), null, new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new byte[] { 228, 34, 228, 151, 241, 113, 74, 98, 90, 255, 171, 111, 116, 180, 40, 62, 202, 77, 159, 157, 237, 92, 126, 124, 66, 47, 185, 128, 204, 122, 27, 30, 204, 221, 73, 252, 9, 36, 119, 104, 34, 1, 233, 214, 150, 49, 204, 241, 175, 159, 83, 252, 186, 211, 122, 234, 45, 19, 173, 80, 209, 222, 33, 104 }, new byte[] { 40, 86, 215, 69, 78, 175, 21, 136, 100, 38, 223, 189, 107, 172, 12, 208, 228, 125, 105, 112, 39, 48, 186, 82, 184, 79, 21, 167, 120, 171, 13, 127, 119, 19, 59, 134, 81, 64, 99, 141, 41, 87, 87, 31, 207, 43, 180, 199, 205, 239, 250, 111, 110, 230, 106, 91, 30, 207, 221, 123, 151, 130, 239, 179, 67, 125, 220, 38, 23, 139, 214, 202, 137, 209, 76, 186, 96, 152, 121, 167, 46, 34, 41, 180, 227, 170, 241, 139, 233, 38, 107, 7, 156, 216, 83, 35, 47, 2, 22, 86, 215, 72, 72, 249, 29, 235, 248, 249, 135, 97, 47, 129, 165, 255, 40, 82, 91, 51, 179, 33, 39, 13, 235, 174, 208, 86, 135, 83 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 11, 24, 817, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 26, 22, 11, 24, 817, DateTimeKind.Local).AddTicks(5153));
        }
    }
}
