using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequestApprovalStatusId",
                table: "VocationLeaveRequests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 218, 157, 244, 148, 106, 101, 176, 27, 88, 192, 138, 209, 38, 115, 91, 18, 161, 177, 248, 92, 77, 17, 97, 136, 82, 233, 141, 234, 65, 230, 68, 56, 50, 48, 128, 226, 88, 179, 67, 175, 2, 97, 222, 246, 236, 66, 195, 0, 56, 209, 132, 245, 212, 197, 168, 163, 45, 189, 182, 99, 127, 187, 220, 69 }, new byte[] { 230, 59, 152, 58, 153, 101, 90, 3, 2, 65, 247, 18, 224, 164, 141, 192, 230, 136, 21, 221, 148, 112, 5, 98, 87, 210, 43, 166, 236, 52, 136, 215, 178, 120, 102, 54, 24, 104, 138, 80, 59, 202, 87, 207, 5, 179, 94, 156, 196, 87, 193, 5, 240, 4, 173, 227, 5, 51, 235, 215, 219, 118, 155, 162, 14, 244, 169, 93, 184, 223, 102, 253, 210, 124, 49, 40, 89, 18, 58, 252, 146, 150, 184, 77, 61, 79, 88, 54, 145, 186, 175, 38, 231, 68, 69, 156, 27, 75, 107, 98, 70, 23, 174, 72, 4, 192, 63, 243, 63, 129, 254, 139, 33, 56, 188, 92, 37, 187, 152, 224, 32, 249, 206, 229, 110, 210, 38, 29 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 24, 21, 125, 45, 162, 77, 106, 128, 41, 84, 131, 234, 178, 13, 197, 99, 158, 57, 102, 150, 43, 244, 171, 78, 61, 82, 16, 119, 177, 4, 233, 104, 60, 71, 175, 204, 131, 184, 116, 80, 172, 113, 5, 36, 159, 121, 114, 16, 220, 60, 44, 96, 239, 168, 121, 128, 28, 247, 188, 200, 92, 236, 158, 124 }, new byte[] { 56, 213, 222, 183, 5, 183, 211, 131, 104, 53, 19, 32, 237, 11, 135, 143, 49, 9, 144, 236, 54, 247, 173, 9, 35, 111, 246, 142, 103, 51, 139, 63, 137, 207, 85, 81, 215, 153, 83, 22, 220, 228, 14, 64, 130, 228, 18, 119, 231, 108, 184, 219, 235, 32, 159, 180, 221, 76, 173, 15, 67, 142, 190, 227, 213, 55, 27, 151, 23, 32, 56, 44, 114, 226, 99, 183, 185, 99, 199, 159, 74, 7, 187, 54, 156, 194, 65, 13, 164, 164, 45, 56, 38, 63, 55, 22, 20, 73, 242, 218, 205, 33, 181, 121, 215, 177, 131, 27, 74, 131, 49, 100, 148, 29, 48, 209, 38, 203, 90, 68, 58, 247, 0, 85, 39, 181, 65, 157 } });

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 27, 3, 6, 51, 751, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 27, 3, 6, 51, 751, DateTimeKind.Local).AddTicks(7503));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequestApprovalStatusId",
                table: "VocationLeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 173, 37, 128, 224, 190, 218, 24, 26, 9, 232, 230, 128, 191, 20, 223, 13, 83, 168, 80, 6, 75, 20, 144, 140, 3, 136, 228, 7, 249, 66, 197, 119, 207, 15, 85, 175, 215, 133, 212, 133, 70, 100, 158, 45, 145, 85, 155, 174, 144, 110, 215, 65, 35, 141, 158, 127, 248, 18, 117, 247, 105, 41, 188, 29 }, new byte[] { 117, 80, 84, 57, 180, 118, 130, 72, 250, 34, 60, 207, 42, 142, 249, 34, 101, 150, 118, 102, 204, 33, 189, 239, 156, 82, 153, 49, 190, 166, 133, 41, 117, 109, 28, 150, 250, 79, 15, 254, 103, 141, 102, 164, 249, 121, 24, 13, 94, 82, 159, 144, 227, 131, 239, 111, 46, 73, 182, 65, 45, 181, 63, 185, 120, 13, 170, 24, 40, 25, 67, 19, 154, 60, 182, 2, 131, 189, 158, 111, 13, 110, 148, 5, 111, 116, 101, 185, 190, 239, 52, 72, 212, 243, 173, 142, 49, 133, 135, 113, 70, 152, 89, 242, 194, 226, 46, 43, 178, 230, 222, 223, 63, 92, 153, 201, 81, 239, 116, 131, 255, 30, 200, 211, 69, 120, 235, 5 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 83, 182, 167, 177, 64, 5, 81, 49, 115, 145, 247, 51, 136, 27, 22, 233, 226, 53, 203, 129, 122, 137, 10, 130, 117, 194, 210, 38, 100, 116, 52, 100, 172, 220, 86, 233, 25, 111, 230, 218, 247, 226, 101, 49, 1, 58, 136, 71, 191, 131, 92, 188, 206, 189, 205, 199, 205, 74, 204, 86, 109, 210, 167, 53 }, new byte[] { 237, 246, 240, 36, 85, 96, 224, 130, 180, 235, 135, 59, 240, 244, 208, 10, 163, 227, 57, 204, 216, 1, 12, 187, 182, 220, 125, 177, 168, 21, 203, 5, 126, 97, 181, 240, 197, 250, 234, 102, 28, 221, 15, 253, 250, 161, 214, 158, 90, 224, 239, 19, 28, 174, 123, 151, 227, 132, 226, 40, 109, 136, 27, 81, 190, 73, 149, 42, 17, 38, 92, 147, 230, 28, 183, 81, 39, 61, 81, 98, 148, 212, 0, 147, 94, 29, 174, 159, 158, 151, 63, 126, 192, 65, 205, 236, 108, 155, 100, 116, 126, 114, 223, 81, 90, 73, 230, 97, 4, 159, 198, 168, 216, 89, 148, 240, 49, 142, 215, 36, 183, 14, 11, 165, 116, 216, 59, 151 } });

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
    }
}
