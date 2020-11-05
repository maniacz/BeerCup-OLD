using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerCup.Web.Migrations
{
    public partial class BattleBreweries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BattleBreweries",
                columns: table => new
                {
                    BattleId = table.Column<int>(nullable: false),
                    BreweryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleBreweries", x => new { x.BattleId, x.BreweryId });
                    table.ForeignKey(
                        name: "FK_BattleBreweries_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleBreweries");
        }
    }
}
