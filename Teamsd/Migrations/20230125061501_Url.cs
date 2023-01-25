using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teamsd.Migrations
{
    public partial class Url : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "TeamDB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "TeamDB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Twiter",
                table: "TeamDB",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "TeamDB");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "TeamDB");

            migrationBuilder.DropColumn(
                name: "Twiter",
                table: "TeamDB");
        }
    }
}
