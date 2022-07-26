using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Alter_QUESTIONPAX_Table_QUESTIONPAXITEM_Table_UserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "QUESTIONPAXITEM",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "QUESTIONPAX",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "UserID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QUESTIONPAX");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo" });
        }
    }
}
