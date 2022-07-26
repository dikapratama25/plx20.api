using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_BIZENTITY_Table_20200312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefNo3",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefNo3",
                table: "BIZENTITY");
        }
    }
}
