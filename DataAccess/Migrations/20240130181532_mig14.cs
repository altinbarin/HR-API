using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 674, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 674, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 139, 105, 189, 53, 88, 41, 153, 187, 35, 191, 68, 235, 250, 29, 175, 50, 180, 194, 80, 62, 221, 190, 82, 220, 77, 79, 252, 137, 154, 130, 27, 229, 37, 43, 137, 221, 204, 177, 77, 31, 160, 234, 134, 237, 238, 192, 75, 156, 97, 33, 183, 135, 209, 105, 232, 85, 230, 210, 124, 140, 133, 144, 94, 234 }, new byte[] { 248, 35, 18, 59, 104, 145, 36, 238, 148, 136, 131, 195, 22, 184, 248, 111, 105, 240, 100, 216, 3, 149, 103, 61, 26, 77, 33, 227, 96, 185, 173, 175, 28, 192, 72, 46, 225, 27, 183, 223, 57, 252, 45, 222, 171, 71, 136, 51, 47, 134, 110, 181, 80, 54, 217, 23, 194, 78, 42, 209, 190, 76, 50, 47, 202, 10, 237, 87, 194, 226, 214, 236, 30, 159, 19, 44, 149, 233, 199, 98, 235, 54, 33, 95, 123, 141, 59, 90, 31, 185, 122, 115, 11, 16, 222, 59, 242, 133, 113, 56, 227, 11, 9, 62, 5, 239, 72, 95, 244, 80, 140, 57, 213, 74, 139, 165, 75, 61, 69, 51, 112, 227, 198, 183, 138, 132, 118, 171 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 247, 99, 213, 186, 187, 201, 228, 183, 221, 225, 11, 115, 93, 82, 213, 91, 62, 10, 43, 81, 194, 197, 16, 36, 137, 26, 22, 236, 112, 132, 136, 78, 227, 253, 153, 101, 55, 35, 4, 152, 97, 210, 36, 35, 235, 115, 70, 200, 137, 126, 151, 99, 62, 11, 116, 76, 12, 122, 222, 217, 210, 78, 74, 10 }, new byte[] { 55, 111, 98, 158, 56, 95, 138, 234, 28, 241, 29, 129, 108, 169, 98, 171, 17, 107, 121, 160, 119, 238, 56, 124, 185, 140, 199, 182, 225, 61, 42, 242, 49, 238, 246, 210, 149, 78, 128, 240, 124, 228, 231, 128, 123, 194, 116, 167, 10, 36, 103, 216, 176, 24, 75, 77, 138, 184, 148, 217, 186, 132, 219, 198, 5, 254, 71, 102, 31, 61, 159, 109, 6, 224, 79, 31, 129, 185, 139, 34, 169, 186, 80, 247, 171, 234, 205, 20, 240, 75, 157, 182, 233, 3, 142, 131, 218, 252, 223, 244, 8, 225, 125, 228, 37, 99, 156, 152, 253, 173, 60, 235, 71, 112, 132, 104, 74, 125, 167, 73, 208, 217, 181, 9, 193, 221, 167, 24 } });

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bekliyor");

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Onay");

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Ret");

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "İptal");

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 30, 21, 15, 31, 675, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Yıllık İzin");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Hastalık İzni");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Evlilik İzni");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Doğum İzni");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Babalık İzni");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Ölüm İzni");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Ücretsiz İzin");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Diğer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 80, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "AdvanceRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 80, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 90, 51, 140, 143, 57, 20, 1, 3, 26, 182, 222, 57, 227, 35, 164, 117, 144, 15, 237, 73, 2, 82, 70, 82, 14, 16, 21, 236, 146, 43, 58, 206, 50, 210, 156, 209, 212, 249, 173, 40, 66, 104, 119, 192, 224, 62, 232, 141, 124, 70, 187, 201, 99, 237, 93, 156, 8, 190, 236, 121, 192, 26, 196, 154 }, new byte[] { 53, 74, 167, 140, 181, 175, 238, 31, 87, 181, 207, 204, 231, 104, 38, 106, 142, 159, 183, 20, 240, 19, 46, 52, 120, 46, 255, 185, 225, 104, 224, 251, 121, 90, 199, 155, 152, 203, 213, 169, 234, 192, 140, 146, 10, 74, 58, 148, 69, 86, 197, 200, 193, 211, 12, 219, 43, 47, 72, 189, 195, 169, 250, 183, 198, 17, 136, 67, 15, 151, 213, 191, 35, 148, 185, 187, 86, 49, 133, 83, 96, 55, 226, 181, 149, 50, 179, 222, 49, 77, 187, 130, 6, 9, 163, 182, 239, 204, 95, 139, 196, 61, 190, 211, 10, 57, 52, 66, 223, 37, 94, 116, 11, 126, 129, 27, 21, 40, 31, 141, 93, 142, 117, 10, 137, 50, 34, 216 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 242, 14, 67, 235, 125, 233, 111, 235, 68, 174, 89, 167, 157, 193, 163, 141, 199, 206, 240, 89, 148, 58, 232, 75, 224, 147, 79, 223, 21, 76, 186, 240, 46, 124, 173, 0, 211, 24, 208, 35, 48, 46, 138, 248, 26, 31, 216, 227, 194, 16, 108, 147, 37, 115, 51, 175, 226, 151, 143, 131, 140, 114, 110 }, new byte[] { 56, 30, 173, 158, 158, 246, 9, 179, 47, 96, 229, 141, 165, 45, 56, 247, 205, 40, 76, 230, 65, 221, 145, 134, 94, 248, 11, 186, 190, 75, 88, 178, 162, 142, 51, 20, 148, 213, 207, 61, 224, 251, 115, 24, 238, 95, 38, 0, 193, 142, 201, 61, 238, 203, 40, 124, 251, 108, 38, 89, 20, 240, 145, 207, 164, 196, 207, 145, 159, 184, 224, 17, 93, 96, 33, 142, 184, 207, 176, 110, 238, 118, 77, 94, 251, 9, 227, 78, 98, 20, 160, 197, 145, 173, 207, 40, 183, 136, 138, 177, 152, 177, 117, 78, 148, 105, 183, 126, 214, 31, 195, 31, 80, 201, 73, 147, 1, 142, 161, 207, 160, 81, 238, 249, 17, 30, 233, 212 } });

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Approved");

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "RequestApprovalStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Canceled");

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "SpendingRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "VocationLeaveRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestDate",
                value: new DateTime(2024, 1, 29, 19, 27, 44, 81, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Annual Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sick Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Marriage Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Maternity Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Paternity Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Bereavement Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Unpaid Leave");

            migrationBuilder.UpdateData(
                table: "VocationLeaveTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Other");
        }
    }
}
