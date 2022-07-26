using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class ADDED_PURCHASEORDER_TABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PURCHASEORDERDTL",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    EntryTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    StkCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    StkDesc = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    StkType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Qty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitCost = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    OrgPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    NettPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    TolAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    DiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    NettAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    SubPoints = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    Points = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    PriceOverrided = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Discounted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Taxable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ReturnCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    PriceAuthID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CustPkgID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PrcDisplayType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PromoCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ExCode1 = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ExCode2 = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BaseRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CoRate1H = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CoRate1G = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate2H = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate2G = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate3H = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate3G = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate4H = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate4G = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate5H = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    CoRate5G = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    WarSerialNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCHASEORDERDTL", x => new { x.BizLocID, x.BizRegID, x.OrderNo, x.OrderSeq, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "PURCHASEORDERHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "(0)"),
                    OrderType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    CustPkgID = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CashierID = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    EmpType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderStartTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    OrderEndTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    OrderAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderSubTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderAmtRnd = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderAmtSave = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderAmtOrg = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderChgAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderDiscCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    OrderDiscType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OrderDiscValue = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderDiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderDiscAuth = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderDiscReasonCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OrderDiscRemark = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OrderAmtSpDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrderValueSpDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AuthSpDisc = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SpDiscReasonCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SpDiscRemark = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CustPrivilege = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    AcctNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TotalPoints = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderReasonCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OrderRemark = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    OrderStatus = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Training = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Profiled = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OrderVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OrderPoints = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCHASEORDERHDR", x => new { x.BizRegID, x.BizLocID, x.OrderNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PURCHASEORDERDTL");

            migrationBuilder.DropTable(
                name: "PURCHASEORDERHDR");
        }
    }
}
