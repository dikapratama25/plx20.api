using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_Address5_BizEntity_Bizlocate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address5",
                table: "BIZLOCATE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Address5",
                table: "BIZENTITY",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "AbpUserProfile",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address5",
                table: "BIZLOCATE");

            migrationBuilder.DropColumn(
                name: "Address5",
                table: "BIZENTITY");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "AbpUserProfile",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");
        }
    }
}
