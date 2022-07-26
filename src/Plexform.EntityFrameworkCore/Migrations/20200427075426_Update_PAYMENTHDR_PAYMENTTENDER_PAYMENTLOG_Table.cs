using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Update_PAYMENTHDR_PAYMENTTENDER_PAYMENTLOG_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTTENDER",
                table: "PAYMENTTENDER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTLOG",
                table: "PAYMENTLOG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTHDR",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "CurrencyPaid",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "MerchantID",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TenderDue",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TransDate",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TransVoid",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "CurrencyPaid",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "ExchgRate",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "FeeAmt",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "FeeType",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "MerchantID",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "PayAmt",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "TenderAmt",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "TenderDue",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "TenderRef",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "TransVoid",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "TransAmt",
                table: "PAYMENTHDR");

            migrationBuilder.RenameColumn(
                name: "TransDate",
                table: "PAYMENTLOG",
                newName: "LogDate");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "TENDERTYPE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "TENDERTYPE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Status",
                table: "TENDERTYPE",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "SyncCreateBy",
                table: "TENDERTYPE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PAYMENTTENDER",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "PAYMENTTENDER",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PAYMENTTENDER",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentTransID",
                table: "PAYMENTTENDER",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "BaseCurrency",
                table: "PAYMENTTENDER",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "MerchantCode",
                table: "PAYMENTTENDER",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "SyncCreateBy",
                table: "PAYMENTTENDER",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "TenderCurrency",
                table: "PAYMENTTENDER",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<DateTime>(
                name: "TenderDate",
                table: "PAYMENTTENDER",
                type: "datetime",
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "TenderType",
                table: "PAYMENTTENDER",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<byte>(
                name: "TransStatus",
                table: "PAYMENTTENDER",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PAYMENTLOG",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "PAYMENTLOG",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorizationCode",
                table: "PAYMENTLOG",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PAYMENTLOG",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogID",
                table: "PAYMENTLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "PaymentTransID",
                table: "PAYMENTLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "CheckSum",
                table: "PAYMENTLOG",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "CheckSumString",
                table: "PAYMENTLOG",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "LogAmt",
                table: "PAYMENTLOG",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "LogRef",
                table: "PAYMENTLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "MerchantCode",
                table: "PAYMENTLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "SyncCreateBy",
                table: "PAYMENTLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "PAYMENTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ResponseURL",
                table: "PAYMENTHDR",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "PAYMENTHDR",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PAYMENTHDR",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalURL",
                table: "PAYMENTHDR",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PAYMENTHDR",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentTransID",
                table: "PAYMENTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "BaseCurrency",
                table: "PAYMENTHDR",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "PAYMENTHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "TransDueAmt",
                table: "PAYMENTHDR",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<decimal>(
                name: "TransPaidAmt",
                table: "PAYMENTHDR",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<byte>(
                name: "TransStatus",
                table: "PAYMENTHDR",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<decimal>(
                name: "TransTotalAmt",
                table: "PAYMENTHDR",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTTENDER",
                table: "PAYMENTTENDER",
                columns: new[] { "BizRegID", "BizLocID", "PaymentTransID", "TenderID", "TenderCode", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTLOG",
                table: "PAYMENTLOG",
                columns: new[] { "BizRegID", "BizLocID", "LogID", "PaymentTransID", "TenderID", "TenderCode", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTHDR",
                table: "PAYMENTHDR",
                columns: new[] { "BizRegID", "BizLocID", "PaymentTransID", "PaymentRef", "MerchantCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTTENDER",
                table: "PAYMENTTENDER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTLOG",
                table: "PAYMENTLOG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PAYMENTHDR",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "SyncCreateBy",
                table: "TENDERTYPE");

            migrationBuilder.DropColumn(
                name: "PaymentTransID",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "BaseCurrency",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "MerchantCode",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "SyncCreateBy",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TenderCurrency",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TenderDate",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TenderType",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "TransStatus",
                table: "PAYMENTTENDER");

            migrationBuilder.DropColumn(
                name: "LogID",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "PaymentTransID",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "CheckSum",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "CheckSumString",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "LogAmt",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "LogRef",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "MerchantCode",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "SyncCreateBy",
                table: "PAYMENTLOG");

            migrationBuilder.DropColumn(
                name: "PaymentTransID",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "BaseCurrency",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "TransDueAmt",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "TransPaidAmt",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "TransStatus",
                table: "PAYMENTHDR");

            migrationBuilder.DropColumn(
                name: "TransTotalAmt",
                table: "PAYMENTHDR");

            migrationBuilder.RenameColumn(
                name: "LogDate",
                table: "PAYMENTLOG",
                newName: "TransDate");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "TENDERTYPE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "TENDERTYPE",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffDate",
                table: "TENDERTYPE",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PAYMENTTENDER",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "PAYMENTTENDER",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PAYMENTTENDER",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AddColumn<string>(
                name: "PaymentID",
                table: "PAYMENTTENDER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "PAYMENTTENDER",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyPaid",
                table: "PAYMENTTENDER",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "MerchantID",
                table: "PAYMENTTENDER",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "TenderDue",
                table: "PAYMENTTENDER",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<DateTime>(
                name: "TransDate",
                table: "PAYMENTTENDER",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "TransVoid",
                table: "PAYMENTTENDER",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PAYMENTLOG",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "PAYMENTLOG",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorizationCode",
                table: "PAYMENTLOG",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PAYMENTLOG",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "PaymentID",
                table: "PAYMENTLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyPaid",
                table: "PAYMENTLOG",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "ExchgRate",
                table: "PAYMENTLOG",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<decimal>(
                name: "FeeAmt",
                table: "PAYMENTLOG",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(1)");

            migrationBuilder.AddColumn<string>(
                name: "FeeType",
                table: "PAYMENTLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "MerchantID",
                table: "PAYMENTLOG",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "PayAmt",
                table: "PAYMENTLOG",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(1)");

            migrationBuilder.AddColumn<decimal>(
                name: "TenderAmt",
                table: "PAYMENTLOG",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<decimal>(
                name: "TenderDue",
                table: "PAYMENTLOG",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "TenderRef",
                table: "PAYMENTLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "TransVoid",
                table: "PAYMENTLOG",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "PAYMENTHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ResponseURL",
                table: "PAYMENTHDR",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "PAYMENTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PAYMENTHDR",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalURL",
                table: "PAYMENTHDR",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PAYMENTHDR",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AddColumn<string>(
                name: "PaymentID",
                table: "PAYMENTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "TransAmt",
                table: "PAYMENTHDR",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTTENDER",
                table: "PAYMENTTENDER",
                columns: new[] { "BizRegID", "BizLocID", "PaymentID", "TenderID", "TenderCode", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTLOG",
                table: "PAYMENTLOG",
                columns: new[] { "BizRegID", "BizLocID", "PaymentID", "TenderID", "TenderCode", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PAYMENTHDR",
                table: "PAYMENTHDR",
                columns: new[] { "BizRegID", "BizLocID", "PaymentID", "PaymentRef", "MerchantCode" });
        }
    }
}
