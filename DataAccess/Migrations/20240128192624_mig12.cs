using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpendingRequest",
                table: "SpendingRequest");

            migrationBuilder.RenameTable(
                name: "SpendingRequest",
                newName: "SpendingRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpendingRequests",
                table: "SpendingRequests",
                column: "Id");

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
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 26, 23, 773, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 26, 23, 773, DateTimeKind.Local).AddTicks(8571));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpendingRequests",
                table: "SpendingRequests");

            migrationBuilder.RenameTable(
                name: "SpendingRequests",
                newName: "SpendingRequest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpendingRequest",
                table: "SpendingRequest",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 38, 125, 60, 154, 49, 67, 5, 121, 72, 123, 204, 224, 153, 118, 45, 105, 1, 172, 89, 96, 91, 195, 232, 138, 33, 47, 219, 135, 122, 14, 78, 251, 94, 231, 223, 37, 234, 175, 178, 214, 172, 249, 214, 155, 124, 219, 152, 87, 55, 183, 25, 170, 23, 190, 61, 30, 151, 110, 163, 220, 241, 133, 190, 114 }, new byte[] { 11, 20, 233, 128, 43, 71, 5, 117, 25, 76, 237, 17, 160, 200, 188, 226, 30, 50, 9, 30, 2, 91, 191, 97, 190, 184, 213, 142, 100, 245, 52, 217, 221, 197, 75, 95, 25, 50, 251, 58, 52, 145, 13, 49, 169, 188, 156, 181, 20, 196, 83, 18, 111, 214, 115, 206, 63, 85, 67, 84, 188, 193, 114, 100, 51, 254, 5, 119, 39, 127, 175, 104, 177, 34, 19, 203, 46, 66, 33, 75, 1, 70, 230, 188, 138, 102, 93, 239, 146, 122, 251, 17, 144, 46, 70, 16, 209, 197, 123, 193, 206, 107, 14, 88, 42, 122, 142, 183, 195, 250, 125, 82, 198, 228, 51, 226, 244, 231, 61, 71, 154, 235, 184, 153, 162, 93, 181, 215 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 246, 242, 7, 220, 252, 20, 42, 202, 85, 193, 44, 239, 220, 146, 184, 206, 232, 74, 236, 146, 118, 115, 246, 169, 165, 223, 169, 197, 248, 89, 160, 243, 130, 68, 228, 123, 210, 2, 235, 119, 154, 149, 28, 62, 201, 145, 87, 34, 34, 164, 78, 135, 178, 212, 140, 148, 255, 125, 88, 72, 201, 97, 194, 95 }, new byte[] { 133, 153, 33, 159, 189, 6, 125, 206, 205, 108, 206, 221, 41, 208, 124, 250, 88, 213, 199, 254, 69, 4, 198, 43, 191, 114, 175, 57, 35, 218, 218, 240, 119, 70, 72, 107, 171, 142, 47, 92, 189, 208, 252, 20, 10, 83, 193, 44, 97, 129, 54, 1, 5, 25, 50, 30, 202, 200, 211, 130, 63, 12, 40, 14, 42, 142, 92, 168, 191, 2, 215, 61, 252, 9, 169, 147, 236, 204, 249, 5, 58, 8, 187, 9, 99, 3, 101, 25, 170, 240, 147, 81, 61, 111, 112, 183, 107, 212, 213, 188, 242, 239, 220, 14, 64, 64, 186, 59, 142, 152, 234, 142, 76, 252, 6, 96, 5, 133, 74, 58, 78, 214, 155, 216, 145, 107, 212, 16 } });

            migrationBuilder.UpdateData(
                table: "SpendingRequest",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 24, 4, 422, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "SpendingRequest",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 24, 4, 422, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 24, 4, 423, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 28, 22, 24, 4, 423, DateTimeKind.Local).AddTicks(3222));
        }
    }
}
