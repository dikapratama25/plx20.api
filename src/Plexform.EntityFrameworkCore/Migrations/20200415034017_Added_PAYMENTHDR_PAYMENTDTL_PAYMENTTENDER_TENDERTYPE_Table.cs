using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_PAYMENTHDR_PAYMENTDTL_PAYMENTTENDER_TENDERTYPE_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TENDERTYPE",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "TenderTypeDesc",
                table: "TENDERTYPE");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "TENDERTYPE",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncCreate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "TENDERTYPE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "TENDERTYPE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "TenderType",
                table: "TENDERTYPE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<string>(
                name: "TenderCode",
                table: "TENDERTYPE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "TENDERTYPE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "EffDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Flag",
                table: "TENDERTYPE",
                nullable: true,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<byte>(
                name: "Inuse",
                table: "TENDERTYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastSyncBy",
                table: "TENDERTYPE",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TID",
                table: "TENDERTYPE",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenderDesc",
                table: "TENDERTYPE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "TENDERTYPE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransporterID",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "STGAPPROVAL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "STGAPPROVAL",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "STGAPPROVAL",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyBin",
                table: "STGAPPROVAL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "STGAPPROVAL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PackageType",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "STGAPPROVAL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "STGAPPROVAL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "STGAPPROVAL",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson2",
                table: "STGAPPROVAL",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "STGAPPROVAL",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "STGAPPROVAL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankCode1",
                table: "STGAPPROVAL",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AddressType",
                table: "STGAPPROVAL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AddressChange",
                table: "STGAPPROVAL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "STGAPPROVAL",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address3",
                table: "STGAPPROVAL",
                maxLength: 100,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "STGAPPROVAL",
                maxLength: 100,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "STGAPPROVAL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<int>(
                name: "TID",
                table: "STGAPPROVAL",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TENDERTYPE",
                table: "TENDERTYPE",
                column: "TenderCode");

            migrationBuilder.CreateTable(
                name: "PAYMENTDTL",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "(0)"),
                    TransRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    NextDueDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    NextDueAmount = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    RemindAttempt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsLatest = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AttemptCount = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RemindLog = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LineTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineTax = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineFee = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineCharge = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineVAT = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LinetOth = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineGST = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    IsOverride = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTDTL", x => new { x.BizLocID, x.BizRegID, x.PaymentID, x.TransRef, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MerchantCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "(0)"),
                    TransCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    TransAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ProductDesc = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    UserEmail = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    UserContact = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ResponseURL = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    AdditionalURL = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    SyncCreateBy = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTHDR", x => new { x.BizRegID, x.BizLocID, x.PaymentID, x.PaymentRef, x.MerchantCode });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTLOG",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrencyPaid = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    TenderRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ExchgRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TenderDue = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RefNo = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    AuthorizationCode = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    MerchantID = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    FeeType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    FeeAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    PayAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    BankCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTLOG", x => new { x.BizRegID, x.BizLocID, x.PaymentID, x.TenderID, x.TenderCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTTENDER",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TenderRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrencyPaid = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    TenderAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ExchgRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TenderDue = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RefNo = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    MerchantID = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    FeeType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    FeeAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    PayAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTTENDER", x => new { x.BizRegID, x.BizLocID, x.PaymentID, x.TenderID, x.TenderCode, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PAYMENTDTL");

            migrationBuilder.DropTable(
                name: "PAYMENTHDR");

            migrationBuilder.DropTable(
                name: "PAYMENTLOG");

            migrationBuilder.DropTable(
                name: "PAYMENTTENDER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TENDERTYPE",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "TenderCode",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "EffDate",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "Flag",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "Inuse",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "LastSyncBy",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "TID",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "TenderDesc",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "TID",
                table: "STGAPPROVAL");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "TENDERTYPE",
                type: "uniqueidentifier",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<byte>(
                name: "TenderType",
                table: "TENDERTYPE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncCreate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "TENDERTYPE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "TENDERTYPE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "TenderTypeDesc",
                table: "TENDERTYPE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TransporterID",
                table: "STGAPPROVAL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "STGAPPROVAL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "STGAPPROVAL",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "STGAPPROVAL",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "STGAPPROVAL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyBin",
                table: "STGAPPROVAL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "STGAPPROVAL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PackageType",
                table: "STGAPPROVAL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "STGAPPROVAL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "STGAPPROVAL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "STGAPPROVAL",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson2",
                table: "STGAPPROVAL",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "STGAPPROVAL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "STGAPPROVAL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "STGAPPROVAL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankCode1",
                table: "STGAPPROVAL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AddressType",
                table: "STGAPPROVAL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AddressChange",
                table: "STGAPPROVAL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "STGAPPROVAL",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address3",
                table: "STGAPPROVAL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "STGAPPROVAL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "STGAPPROVAL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TENDERTYPE",
                table: "TENDERTYPE",
                column: "TenderType");
        }
    }
}
