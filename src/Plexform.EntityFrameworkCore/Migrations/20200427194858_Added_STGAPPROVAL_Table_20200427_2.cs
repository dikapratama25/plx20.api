using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_STGAPPROVAL_Table_20200427_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "StatusApproval",
                table: "STGAPPROVAL",
                nullable: true,
                defaultValueSql: "(0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusApproval",
                table: "STGAPPROVAL");
        }
    }
}
