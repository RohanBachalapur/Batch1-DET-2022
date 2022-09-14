﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batch1_DET_2022.Migrations
{
    public partial class initialcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyBook",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bkprice = table.Column<int>(type: "int", nullable: false, defaultValue: 200)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBook", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) //This is going to drop the table 
        {
            migrationBuilder.DropTable(
                name: "MyBook");
        }
    }
}
