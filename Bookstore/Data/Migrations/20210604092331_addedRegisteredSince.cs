using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Data.Migrations
{
    public partial class addedRegisteredSince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoggedInSince",
                table: "AspNetUsers",
                newName: "RegisteredSince");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegisteredSince",
                table: "AspNetUsers",
                newName: "LoggedInSince");
        }
    }
}
