using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAX_Table_20200716 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "ParentID",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "QUESTIONPAX");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONPAX",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONPAX",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONPAX",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "SecNo" });
        }
    }
}
