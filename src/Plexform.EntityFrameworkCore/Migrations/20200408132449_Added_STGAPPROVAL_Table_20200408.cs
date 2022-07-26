using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_STGAPPROVAL_Table_20200408 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_STATE",
                table: "STATE");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "STGAPPROVAL",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATE",
                table: "STATE",
                columns: new[] { "CountryCode", "StateCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_STATE",
                table: "STATE");

            migrationBuilder.DropColumn(
                name: "District",
                table: "STGAPPROVAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATE",
                table: "STATE",
                columns: new[] { "rowguid", "CountryCode", "StateCode" });
        }
    }
}
