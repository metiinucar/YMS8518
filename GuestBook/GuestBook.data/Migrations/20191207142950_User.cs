using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBook.data.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GuestNote",
                table: "GuestNote");

            migrationBuilder.RenameTable(
                name: "GuestNote",
                newName: "GuestNotes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuestNotes",
                table: "GuestNotes",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GuestNotes",
                table: "GuestNotes");

            migrationBuilder.RenameTable(
                name: "GuestNotes",
                newName: "GuestNote");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuestNote",
                table: "GuestNote",
                column: "id");
        }
    }
}
