using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19.Migrations
{
    public partial class createfirsttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSurname = table.Column<string>(maxLength: 250, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    City = table.Column<string>(maxLength: 150, nullable: true),
                    FirstSymptoms = table.Column<string>(maxLength: 250, nullable: true),
                    Condition = table.Column<string>(maxLength: 250, nullable: true),
                    FirstSyptoms = table.Column<DateTime>(nullable: false),
                    FirstTest = table.Column<DateTime>(nullable: false),
                    Recover = table.Column<DateTime>(nullable: false),
                    Death = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");
        }
    }
}
