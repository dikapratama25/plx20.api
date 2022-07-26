using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_ACCVERIFY_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACCVERIFY",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 20, nullable: false),
                    VeriKey = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    UserType = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    KeyIndex = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    VeriCode = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    VeriType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Remark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    DeviceBrand = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(nullable: true),
                    RejectRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RequestDate1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestDate2 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCVERIFY", x => new { x.UserID, x.VeriKey });
                });

            migrationBuilder.CreateTable(
                name: "SAP_PO",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SupplierInvoice = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    OrderType = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true, defaultValueSql: "(2)"),
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
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OrderGroup = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    OrderCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ExchangeRate = table.Column<decimal>(nullable: true, defaultValueSql: "NULL"),
                    OrderAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ActionID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ActionDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PostDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    POstatus = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InvoiceStatus = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAP_PO", x => new { x.BizRegID, x.OrderNo, x.SupplierInvoice, x.OrderType });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACCVERIFY");

            migrationBuilder.DropTable(
                name: "SAP_PO");
        }
    }
}
