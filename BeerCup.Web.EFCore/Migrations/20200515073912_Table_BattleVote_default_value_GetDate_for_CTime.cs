using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerCup.Web.EFCore.Migrations
{
    public partial class Table_BattleVote_default_value_GetDate_for_CTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CTime",
                table: "BattlesVotes",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CTime",
                table: "BattlesVotes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");
        }
    }
}
