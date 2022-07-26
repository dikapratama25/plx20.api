using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class EditAppTenantEditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTenantEditions",
                table: "AppTenantEditions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTenantEditions",
                table: "AppTenantEditions",
                columns: new[] { "TenantId", "AppId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppTenantEditions",
                table: "AppTenantEditions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppTenantEditions",
                table: "AppTenantEditions",
                columns: new[] { "TenantId", "EditionId", "AppId", "UserId" });
        }
    }
}
