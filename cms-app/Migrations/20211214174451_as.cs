using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cms_app.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "teachers");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "classes_set",
                newName: "day");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateofbirth",
                table: "teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "classfree",
                table: "classes_set",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "duration",
                table: "classes_set",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateofbirth",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "classfree",
                table: "classes_set");

            migrationBuilder.DropColumn(
                name: "duration",
                table: "classes_set");

            migrationBuilder.RenameColumn(
                name: "day",
                table: "classes_set",
                newName: "date");

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
