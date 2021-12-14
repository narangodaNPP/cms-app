using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cms_app.Migrations
{
    public partial class were : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Students");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateofbirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateofbirth",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
