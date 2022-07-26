using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAXITEM_Table_20201001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "QUESTIONPAXITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "OptID",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OptType",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "QUESTIONPAXITEM",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "OptID",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "OptType",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONPAXITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONPAXITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONPAXITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "SecNo", "GrpNo", "SeqNo", "ParentID" });
        }
    }
}
