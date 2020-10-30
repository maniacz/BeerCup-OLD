using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerCup.Web.Migrations
{
    public partial class CurrentBattle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrentBattle",
                columns: table => new
                {
                    Lock = table.Column<string>(nullable: false, defaultValue: "X"),
                    CurrentBattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentBattle", x => x.Lock);
                    table.CheckConstraint("CK_T1_Locked", "[Lock]='X'");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentBattle");
        }
    }
}
