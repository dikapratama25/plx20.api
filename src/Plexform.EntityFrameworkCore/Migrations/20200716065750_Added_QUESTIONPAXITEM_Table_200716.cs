using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAXITEM_Table_200716 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OptValue",
                table: "QUESTIONPAXITEM");

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "QUESTIONPAXITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "QUESTIONPAXITEM");

            migrationBuilder.AddColumn<byte>(
                name: "OptValue",
                table: "QUESTIONPAXITEM",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)");
        }
    }
}
