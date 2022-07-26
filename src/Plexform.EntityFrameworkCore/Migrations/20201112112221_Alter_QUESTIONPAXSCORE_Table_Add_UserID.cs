using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Alter_QUESTIONPAXSCORE_Table_Add_UserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo", "UserID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo" });
        }
    }
}
