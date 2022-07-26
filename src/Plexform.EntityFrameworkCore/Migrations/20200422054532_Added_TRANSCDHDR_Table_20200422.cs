using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_TRANSCDHDR_Table_20200422 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TRANSCDHDR",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "(1)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    TotalRec1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec4 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec5 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt4 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt5 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSCDHDR", x => new { x.MonthCode, x.PBTCode, x.BatchCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRANSCDHDR");
        }
    }
}
