using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Data.Migrations
{
    public partial class addedApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteBook",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FavoriteGenre",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoggedInSince",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteBook",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FavoriteGenre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LoggedInSince",
                table: "AspNetUsers");
        }
    }
}
