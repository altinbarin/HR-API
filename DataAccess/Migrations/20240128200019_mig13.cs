using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Folder",
                table: "SpendingRequests",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 31, 52, 205, 185, 143, 92, 159, 232, 81, 253, 213, 74, 233, 185, 122, 190, 199, 110, 163, 34, 111, 230, 163, 160, 58, 24, 84, 89, 97, 74, 143, 87, 101, 203, 168, 22, 19, 124, 121, 9, 212, 202, 179, 22, 54, 204, 148, 137, 172, 52, 146, 61, 250, 247, 224, 214, 138, 49, 153, 172, 131, 17, 162, 29 }, new byte[] { 181, 120, 175, 233, 19, 130, 178, 191, 165, 194, 36, 139, 153, 51, 223, 22, 46, 177, 58, 28, 155, 118, 42, 198, 253, 104, 138, 122, 110, 169, 111, 127, 0, 151, 119, 210, 135, 144, 239, 12, 8, 255, 115, 51, 98, 112, 147, 158, 244, 231, 191, 61, 133, 103, 56, 116, 112, 12, 157, 49, 94, 105, 29, 31, 13, 73, 211, 182, 245, 234, 190, 179, 92, 138, 198, 3, 222, 165, 214, 73, 175, 192, 48, 71, 214, 184, 45, 97, 217, 79, 164, 217, 102, 231, 218, 124, 205, 173, 84, 82, 69, 100, 243, 3, 236, 187, 229, 130, 102, 33, 40, 196, 104, 157, 85, 250, 212, 205, 14, 227, 77, 138, 85, 10, 16, 182, 17, 26 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 136, 72, 254, 166, 121, 114, 157, 52, 110, 82, 204, 48, 46, 23, 174, 9, 175, 128, 55, 23, 127, 145, 205, 81, 21, 165, 176, 50, 230, 227, 150, 238, 116, 61, 93, 221, 90, 104, 84, 27, 127, 127, 98, 158, 110, 29, 241, 162, 51, 113, 80, 163, 249, 53, 250, 208, 29, 156, 35, 57, 146, 211, 131, 53 }, new byte[] { 209, 200, 17, 79, 244, 190, 68, 181, 165, 145, 144, 120, 216, 62, 235, 84, 240, 150, 225, 76, 80, 40, 172, 188, 87, 14, 45, 8, 29, 67, 107, 186, 97, 97, 213, 207, 193, 24, 105, 221, 154, 19, 215, 65, 27, 162, 13, 173, 212, 176, 248, 155, 91, 33, 207, 102, 146, 184, 29, 39, 230, 192, 177, 148, 0, 129, 131, 234, 10, 139, 41, 42, 49, 254, 111, 182, 136, 152, 97, 61, 89, 192, 233, 92, 8, 106, 149, 225, 22, 56, 89, 193, 12, 16, 147, 133, 124, 86, 151, 62, 115, 72, 127, 145, 90, 254, 126, 202, 76, 250, 80, 133, 37, 113, 219, 117, 159, 191, 188, 129, 250, 154, 44, 126, 197, 237, 81, 35 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Folder", "RequestDate" },
                values: new object[] { null, new DateTime(2024, 1, 28, 23, 0, 19, 217, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Folder", "RequestDate" },
                values: new object[] { null, new DateTime(2024, 1, 28, 23, 0, 19, 217, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 23, 0, 19, 218, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 23, 0, 19, 218, DateTimeKind.Local).AddTicks(962));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Folder",
                table: "SpendingRequests",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 131, 103, 124, 168, 238, 244, 10, 203, 237, 156, 84, 65, 162, 6, 121, 206, 137, 87, 243, 38, 165, 95, 133, 129, 81, 39, 91, 2, 60, 143, 92, 148, 177, 138, 86, 145, 153, 137, 239, 113, 64, 61, 45, 43, 10, 229, 226, 129, 234, 224, 135, 1, 223, 114, 95, 146, 21, 119, 223, 213, 2, 62, 240, 253 }, new byte[] { 236, 51, 198, 224, 182, 220, 84, 71, 237, 193, 142, 132, 50, 90, 38, 208, 136, 44, 241, 14, 144, 11, 47, 40, 125, 254, 163, 221, 214, 203, 155, 98, 194, 5, 35, 6, 60, 109, 71, 149, 95, 80, 102, 249, 72, 56, 67, 213, 240, 168, 73, 68, 24, 119, 195, 208, 50, 88, 108, 198, 199, 79, 119, 95, 248, 60, 85, 29, 163, 227, 2, 141, 212, 68, 224, 74, 127, 124, 242, 244, 243, 12, 177, 75, 120, 8, 48, 104, 168, 213, 47, 190, 24, 91, 253, 8, 18, 27, 63, 160, 187, 251, 121, 147, 201, 68, 26, 66, 246, 177, 34, 144, 24, 232, 200, 59, 111, 42, 190, 107, 4, 42, 88, 62, 9, 69, 28, 230 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 153, 28, 86, 161, 214, 26, 197, 194, 177, 231, 164, 56, 44, 239, 121, 254, 212, 194, 135, 6, 200, 102, 199, 113, 0, 206, 14, 128, 106, 117, 28, 58, 213, 143, 194, 240, 134, 76, 253, 158, 210, 225, 40, 146, 104, 186, 89, 108, 90, 58, 12, 138, 124, 236, 22, 29, 148, 83, 170, 96, 76, 154, 140 }, new byte[] { 70, 185, 231, 206, 13, 53, 30, 127, 235, 69, 23, 43, 78, 83, 43, 247, 181, 49, 254, 211, 248, 187, 107, 205, 141, 106, 31, 170, 28, 202, 36, 99, 118, 92, 215, 104, 167, 125, 133, 196, 201, 192, 206, 160, 109, 128, 187, 217, 213, 218, 228, 107, 236, 76, 30, 50, 38, 79, 35, 155, 38, 24, 141, 200, 116, 213, 136, 79, 4, 7, 62, 167, 34, 24, 113, 111, 145, 119, 59, 233, 128, 253, 117, 212, 244, 50, 113, 156, 114, 96, 5, 193, 19, 25, 203, 40, 190, 111, 79, 41, 12, 3, 147, 67, 204, 222, 233, 237, 210, 136, 243, 143, 82, 223, 90, 36, 140, 25, 186, 166, 137, 132, 250, 172, 130, 241, 253, 247 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Folder", "RequestDate" },
                values: new object[] { null, new DateTime(2024, 1, 28, 22, 26, 23, 773, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Folder", "RequestDate" },
                values: new object[] { null, new DateTime(2024, 1, 28, 22, 26, 23, 773, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 26, 23, 774, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 26, 23, 774, DateTimeKind.Local).AddTicks(6604));
        }
    }
}
