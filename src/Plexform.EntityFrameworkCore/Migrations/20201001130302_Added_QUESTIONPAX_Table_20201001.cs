using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAX_Table_20201001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CAMPLOTPAX",
                table: "CAMPLOTPAX");

            migrationBuilder.AddColumn<decimal>(
                name: "AvgScore",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NormalisedScore",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NormalisedScoreDefault",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuizType",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "QUESTIONPAX",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ResponseOptID",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResponseText",
                table: "QUESTIONPAX",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ScoreWeight",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "WeightedScore",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "WeightedScoreDefault",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "WeightedScorePercent",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "WeightedScorePercentDefault",
                table: "QUESTIONPAX",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAMPLOTPAX",
                table: "CAMPLOTPAX",
                columns: new[] { "LotID", "CampID", "BizRegID", "BizLocID", "SeqNo", "PaxRegID", "PaxLocID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CAMPLOTPAX",
                table: "CAMPLOTPAX");

            migrationBuilder.DropColumn(
                name: "AvgScore",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "NormalisedScore",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "NormalisedScoreDefault",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "QuizType",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "ResponseOptID",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "ResponseText",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "ScoreWeight",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "WeightedScore",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "WeightedScoreDefault",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "WeightedScorePercent",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "WeightedScorePercentDefault",
                table: "QUESTIONPAX");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAMPLOTPAX",
                table: "CAMPLOTPAX",
                columns: new[] { "LotID", "CampID", "BizRegID", "BizLocID", "SeqNo" });
        }
    }
}
