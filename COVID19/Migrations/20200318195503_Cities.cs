using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID19.Migrations
{
    public partial class Cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CitiesId",
                table: "Cases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Cases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ResultFirstTest",
                table: "Cases",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Cases",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    testCases = table.Column<int>(nullable: false),
                    confirmedCases = table.Column<int>(nullable: false),
                    recoveredCases = table.Column<int>(nullable: false),
                    fatalCases = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CitiesId",
                table: "Cases",
                column: "CitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Cities_CitiesId",
                table: "Cases",
                column: "CitiesId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Cities_CitiesId",
                table: "Cases");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cases_CitiesId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CitiesId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "ResultFirstTest",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Cases");
        }
    }
}
