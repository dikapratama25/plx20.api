using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_table_quesitonitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OptGroupID",
                table: "QUESTIONITEM",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ScoreWeight",
                table: "QUESTIONITEM",
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "QUESTIONITEM",
                maxLength: 3,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptGroupID",
                table: "QUESTIONITEM");

            migrationBuilder.DropColumn(
                name: "ScoreWeight",
                table: "QUESTIONITEM");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "QUESTIONITEM");
        }
    }
}
