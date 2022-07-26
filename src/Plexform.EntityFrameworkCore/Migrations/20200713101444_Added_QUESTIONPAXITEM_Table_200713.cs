using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAXITEM_Table_200713 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.AddColumn<string>(
                name: "PaxRegID",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "PaxLocID",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "OptValue",
                table: "QUESTIONPAXITEM",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "SecNo", "GrpNo", "SeqNo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "PaxRegID",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "PaxLocID",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "OptValue",
                table: "QUESTIONPAXITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "SecNo", "GrpNo", "SeqNo" });
        }
    }
}
