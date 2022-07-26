using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAX_Table_200713 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "SeqNo",
                table: "QUESTIONPAX");

            migrationBuilder.AddColumn<int>(
                name: "SecNo",
                table: "QUESTIONPAX",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "SecNo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "SecNo",
                table: "QUESTIONPAX");

            migrationBuilder.AddColumn<int>(
                name: "SeqNo",
                table: "QUESTIONPAX",
                type: "int",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "SeqNo" });
        }
    }
}
