using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class invoicecwms_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMPPOLICY");

            migrationBuilder.CreateTable(
                name: "INVOICEHDR_CWMS",
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
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
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
                    table.PrimaryKey("PK_INVOICEHDR_CWMS", x => new { x.MonthCode, x.PBTCode, x.BatchCode });
                });

            migrationBuilder.CreateTable(
                name: "PROMOPOLICY",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PromoID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PolicyNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    EffectiveDay = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EntAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ExpiryDay = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    GST = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    GroupCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    IsGST = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsMix = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    MaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MinAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MixDesc = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OptPolicy = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PeriodDay = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PeriodMonth = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PeriodType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PeriodWeek = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PolicyCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PolicyType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark4 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark5 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark6 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark7 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TradeupAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MaxQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    MinQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ExpiryType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    QtyType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROMOPOLICY", x => new { x.BizRegID, x.BizLocID, x.PromoID, x.PolicyNo, x.ItemCode, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INVOICEHDR_CWMS");

            migrationBuilder.DropTable(
                name: "PROMOPOLICY");

            migrationBuilder.CreateTable(
                name: "CAMPPOLICY",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PromoID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PolicyNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ApprovedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    EffectiveDay = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EntAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ExpiryDay = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ExpiryType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    GST = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    GroupCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsGST = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsMix = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MaxAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    MaxQty = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    MinAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    MinQty = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    MixDesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OptPolicy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PeriodDay = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PeriodMonth = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PeriodType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PeriodWeek = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PolicyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PolicyType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    QtyType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    Remark4 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    Remark5 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    Remark6 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "''"),
                    Remark7 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TradeupAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPPOLICY", x => new { x.BizRegID, x.BizLocID, x.PromoID, x.PolicyNo, x.ItemCode, x.SeqNo });
                });
        }
    }
}
