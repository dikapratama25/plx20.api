using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CBXBIDDING_Table20200714 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CBXBIDDING",
                columns: table => new
                {
                    BidID = table.Column<string>(maxLength: 20, nullable: false),
                    LotID = table.Column<string>(maxLength: 20, nullable: false),
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BidSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BidTotAmtP = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    BidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BidCurr = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    BidRank = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsPrebid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBXBIDDING", x => new { x.BidID, x.LotID, x.CampID, x.PaxRegID, x.PaxLocID, x.BidSeq });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CBXBIDDING");
        }
    }
}
