using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 105, 129, 244, 219, 143, 137, 15, 224, 167, 237, 168, 137, 186, 132, 62, 192, 160, 191, 255, 62, 110, 147, 147, 191, 218, 18, 121, 198, 46, 159, 65, 124, 232, 204, 208, 30, 51, 219, 147, 212, 51, 30, 241, 224, 193, 23, 169, 13, 12, 158, 140, 135, 101, 67, 174, 249, 76, 67, 140, 108, 32, 31, 105 }, new byte[] { 252, 208, 55, 111, 228, 121, 248, 23, 49, 182, 209, 170, 88, 13, 45, 229, 227, 143, 93, 128, 149, 227, 150, 148, 187, 188, 220, 126, 71, 105, 214, 153, 33, 48, 113, 180, 20, 182, 240, 190, 149, 180, 170, 57, 105, 31, 234, 182, 168, 74, 37, 233, 192, 133, 185, 6, 97, 106, 176, 47, 248, 91, 85, 9, 83, 32, 66, 17, 144, 183, 146, 128, 38, 173, 178, 13, 167, 115, 58, 171, 61, 128, 211, 254, 52, 148, 43, 242, 170, 3, 52, 196, 210, 250, 12, 38, 215, 18, 189, 96, 166, 196, 79, 49, 249, 185, 131, 50, 31, 54, 10, 41, 42, 109, 186, 217, 81, 234, 68, 76, 70, 109, 150, 163, 89, 210, 139, 108 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 146, 251, 11, 161, 123, 128, 110, 45, 227, 96, 196, 103, 183, 68, 194, 249, 119, 99, 236, 208, 102, 109, 202, 252, 14, 138, 62, 212, 218, 98, 77, 166, 20, 32, 36, 32, 138, 1, 160, 7, 252, 22, 234, 117, 215, 194, 49, 16, 179, 172, 42, 218, 45, 101, 181, 133, 88, 149, 106, 188, 170, 225, 194, 7 }, new byte[] { 249, 155, 191, 191, 112, 143, 236, 78, 198, 145, 105, 120, 86, 46, 130, 114, 107, 31, 250, 166, 141, 166, 45, 91, 141, 188, 153, 99, 141, 100, 75, 163, 194, 224, 162, 108, 93, 110, 140, 215, 0, 30, 226, 85, 109, 175, 206, 114, 15, 94, 27, 205, 224, 8, 14, 236, 90, 32, 49, 203, 228, 5, 89, 222, 20, 45, 107, 109, 15, 195, 140, 202, 163, 97, 159, 175, 106, 104, 153, 79, 161, 80, 159, 7, 174, 217, 12, 77, 51, 44, 229, 173, 249, 57, 121, 40, 76, 195, 192, 53, 165, 217, 221, 108, 31, 75, 27, 12, 103, 1, 51, 92, 78, 113, 238, 126, 96, 232, 186, 112, 77, 57, 57, 54, 78, 66, 186, 208 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 49, 50, 51 }, new byte[] { 49, 50, 51 } });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 49, 50, 51 }, new byte[] { 49, 50, 51 } });
        }
    }
}
