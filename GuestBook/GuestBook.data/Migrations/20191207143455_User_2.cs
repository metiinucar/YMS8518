using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBook.data.Migrations
{
    public partial class User_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "Password", "Username" },
                values: new object[] { 1, "12345678", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
