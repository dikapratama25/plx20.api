using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAXSUM_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QUESTIONPAXSUM",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true),
                    TotalAmt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AvgScore = table.Column<decimal>(nullable: true),
                    WeightedScore = table.Column<decimal>(nullable: true),
                    NormalisedScore = table.Column<decimal>(nullable: true),
                    WeightedScorePercent = table.Column<decimal>(nullable: true),
                    WeightedScoreDefault = table.Column<decimal>(nullable: true),
                    NormalisedScoreDefault = table.Column<decimal>(nullable: true),
                    WeightedScorePercentDefault = table.Column<decimal>(nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAXSUM", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.PaxRegID, x.PaxLocID, x.ParentID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QUESTIONPAXSUM");
        }
    }
}
