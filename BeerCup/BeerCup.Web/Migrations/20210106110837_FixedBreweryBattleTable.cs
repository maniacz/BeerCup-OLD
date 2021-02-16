using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerCup.Web.Migrations
{
    public partial class FixedBreweryBattleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattlesResults_Battles_BattleId",
                table: "BattlesResults");

            migrationBuilder.DropForeignKey(
                name: "FK_BattlesResults_Breweries_BreweryId",
                table: "BattlesResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BattlesResults",
                table: "BattlesResults");

            migrationBuilder.DropColumn(
                name: "FinalRank",
                table: "BattlesResults");

            migrationBuilder.DropColumn(
                name: "VotesReceived",
                table: "BattlesResults");

            migrationBuilder.RenameTable(
                name: "BattlesResults",
                newName: "BreweryBattle");

            migrationBuilder.RenameIndex(
                name: "IX_BattlesResults_BattleId",
                table: "BreweryBattle",
                newName: "IX_BreweryBattle_BattleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BreweryBattle",
                table: "BreweryBattle",
                columns: new[] { "BreweryId", "BattleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BreweryBattle_Battles_BattleId",
                table: "BreweryBattle",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BreweryBattle_Breweries_BreweryId",
                table: "BreweryBattle",
                column: "BreweryId",
                principalTable: "Breweries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BreweryBattle_Battles_BattleId",
                table: "BreweryBattle");

            migrationBuilder.DropForeignKey(
                name: "FK_BreweryBattle_Breweries_BreweryId",
                table: "BreweryBattle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BreweryBattle",
                table: "BreweryBattle");

            migrationBuilder.RenameTable(
                name: "BreweryBattle",
                newName: "BattlesResults");

            migrationBuilder.RenameIndex(
                name: "IX_BreweryBattle_BattleId",
                table: "BattlesResults",
                newName: "IX_BattlesResults_BattleId");

            migrationBuilder.AddColumn<int>(
                name: "FinalRank",
                table: "BattlesResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VotesReceived",
                table: "BattlesResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BattlesResults",
                table: "BattlesResults",
                columns: new[] { "BreweryId", "BattleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BattlesResults_Battles_BattleId",
                table: "BattlesResults",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BattlesResults_Breweries_BreweryId",
                table: "BattlesResults",
                column: "BreweryId",
                principalTable: "Breweries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
