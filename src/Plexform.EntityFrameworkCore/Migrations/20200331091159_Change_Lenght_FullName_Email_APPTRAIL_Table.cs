using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Change_Lenght_FullName_Email_APPTRAIL_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "APPTRAIL",
                maxLength: 2000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "APPTRAIL",
                maxLength: 2000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true,
                oldDefaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "APPTRAIL",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "APPTRAIL",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true,
                oldDefaultValueSql: "''");
        }
    }
}
