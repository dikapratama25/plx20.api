using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_ActionLink_Removed_FullName_EmailAddress_APPTRAIL_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "APPTRAIL");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "APPTRAIL");

            migrationBuilder.AddColumn<string>(
                name: "ActionLink",
                table: "APPTRAIL",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionLink",
                table: "APPTRAIL");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "APPTRAIL",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "APPTRAIL",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                defaultValueSql: "''");
        }
    }
}
