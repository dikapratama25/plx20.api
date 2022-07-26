using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_WORKORDERHDR_Table_20201007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TransDate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncCreate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CODCreateDate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<string>(
                name: "CODFilePath",
                table: "WORKORDERHDR",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.CreateTable(
                name: "QUESTIONPAXSCORE",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false),
                    SecNo = table.Column<int>(nullable: false),
                    GrpNo = table.Column<int>(nullable: false),
                    SeqNo = table.Column<int>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    ReviewedBy = table.Column<string>(maxLength: 20, nullable: false),
                    Score = table.Column<int>(nullable: false),
                    ScoreDefault = table.Column<int>(nullable: false),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false),
                    UOM = table.Column<string>(maxLength: 3, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false),
                    Note = table.Column<string>(maxLength: 4000, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Posted = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAXSCORE", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.PaxRegID, x.PaxLocID, x.ParentID, x.SecNo, x.GrpNo, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QUESTIONPAXSCORE");

            migrationBuilder.DropColumn(
                name: "CODCreateDate",
                table: "WORKORDERHDR");

            migrationBuilder.DropColumn(
                name: "CODFilePath",
                table: "WORKORDERHDR");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TransDate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncCreate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "WORKORDERHDR",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");
        }
    }
}
