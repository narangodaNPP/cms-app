﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cms_app.Migrations
{
    public partial class sad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes_set",
                columns: table => new
                {
                    classID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    teacherID = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classfree = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes_set", x => x.classID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    paymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expireMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expireYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    securityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.paymentID);
                });

            migrationBuilder.CreateTable(
                name: "studentclasses",
                columns: table => new
                {
                    clID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentID = table.Column<int>(type: "int", nullable: false),
                    classID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentclasses", x => x.clID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    myclasses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentID);
                });

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    teacherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    myclasses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.teacherID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classes_set");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "studentclasses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "teachers");
        }
    }
}