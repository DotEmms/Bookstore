using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    YearOfPublication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    FirstNameAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastNameAuthor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
