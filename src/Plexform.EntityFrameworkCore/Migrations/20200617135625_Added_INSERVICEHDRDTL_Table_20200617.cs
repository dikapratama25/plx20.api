using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_INSERVICEHDRDTL_Table_20200617 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INSERVICEDTL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MSTRID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    DeliveryDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Qty = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    UnitCost = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrgPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    NettPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SubTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    NettAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    SubPoints = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Points = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PriceOverrided = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Discounted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Taxable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ReturnCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PriceAuthID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CustPkgID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PrcDisplayType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PromoCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    QGroupID = table.Column<int>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSERVICEDTL", x => new { x.BizRegID, x.BizLocID, x.InSvcID, x.MSTRID, x.SeqNo, x.DeliveryDate });
                });

            migrationBuilder.CreateTable(
                name: "INSERVICEHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcDate = table.Column<DateTime>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    CustRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CustAddress = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    CustPIC = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CustTelNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    CustEmail = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    RefStatus = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    InSvcTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    OutSvcTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    ServerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmpType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransSubTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransAmtRnd = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransAmtSave = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransAmtOrg = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransChgAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TransDiscType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscValue = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscAuth = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransDiscReasonCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransDiscRemark = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransAmtSpDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransValueSpDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ExchgRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CurrencyPaid = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CollectedAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPaidID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastPaidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastPaidAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AuthSpDisc = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsSent = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SentAttempt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    SpDiscReasonCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SpDiscRemark = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    Reason = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    PrintedRpt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    IsCompleted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AnalysisSts = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ChkOutTermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Signature = table.Column<byte>(nullable: true),
                    FilePath = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSERVICEHDR", x => new { x.BizRegID, x.BizLocID, x.InSvcID, x.CustLocID, x.InSvcDate });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INSERVICEDTL");

            migrationBuilder.DropTable(
                name: "INSERVICEHDR");
        }
    }
}
