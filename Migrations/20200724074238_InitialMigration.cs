using Microsoft.EntityFrameworkCore.Migrations;

namespace RestCountriesTest.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContinentId = table.Column<int>(nullable: false),
                    ContinentName = table.Column<string>(nullable: true),
                    CountryCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CountryDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<int>(nullable: false),
                    CountryName = table.Column<string>(nullable: true),
                    Capital = table.Column<string>(nullable: true),
                    ContinentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.DropTable(
                name: "CountryDetails");
        }
    }
}
