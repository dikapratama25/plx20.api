using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class UPDATE_INVOICEHDR_INVOICEDTL_BIZDOCUMENT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_INVOICEHDR",
                table: "INVOICEHDR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_INVOICEDTL",
                table: "INVOICEDTL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BIZDOCUMENT",
                table: "BIZDOCUMENT");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransValueSpDisc",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransType",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransSubTotal",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransStatus",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransStartTime",
                table: "INVOICEHDR",
                maxLength: 6,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransRemark",
                table: "INVOICEHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransReasonCode",
                table: "INVOICEHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransPointsStatus",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransPoints",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransPayTime",
                table: "INVOICEHDR",
                maxLength: 6,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransEndTime",
                table: "INVOICEHDR",
                maxLength: 6,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransDiscValue",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransDiscType",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscRemark",
                table: "INVOICEHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscReasonCode",
                table: "INVOICEHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscCode",
                table: "INVOICEHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscAuth",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransDiscAmt",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransChgAmt",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtSpDisc",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtSave",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtRnd",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtOrg",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmt",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Training",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalServer",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPoints",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TillID",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TermID",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TblPax",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TblNo",
                table: "INVOICEHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "INVOICEHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SpDiscRemark",
                table: "INVOICEHDR",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SpDiscReasonCode",
                table: "INVOICEHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ShiftCode",
                table: "INVOICEHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ServerID",
                table: "INVOICEHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Profiled",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "InSvcID",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "EmpType",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "CustType",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CustPrivilege",
                table: "INVOICEHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustPkgID",
                table: "INVOICEHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CashierID",
                table: "INVOICEHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BillNo",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AuthSpDisc",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AcctNo",
                table: "INVOICEHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "OrderNo",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedBy",
                table: "INVOICEHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedDate",
                table: "INVOICEHDR",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "IsApproved",
                table: "INVOICEHDR",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "WarSerialNo",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitCost",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TolAmt",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<int>(
                name: "TermID",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Taxable",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubPoints",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "StkType",
                table: "INVOICEDTL",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StkDesc",
                table: "INVOICEDTL",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StkCode",
                table: "INVOICEDTL",
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
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReturnCode",
                table: "INVOICEDTL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "INVOICEDTL",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "RefSeq",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PromoCode",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PriceOverrided",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PriceAuthID",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PrcDisplayType",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Points",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrgPrice",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NettPrice",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NettAmt",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsCal",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ExCode2",
                table: "INVOICEDTL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ExCode1",
                table: "INVOICEDTL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EntryTime",
                table: "INVOICEDTL",
                maxLength: 6,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Discounted",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscAmt",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "CustPkgID",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate5H",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate5G",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate4H",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate4G",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate3H",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate3G",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate2H",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate2G",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate1H",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate1G",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "BillNo",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BehvType",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseRate",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "OrderNo",
                table: "INVOICEDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<int>(
                name: "OrderSeq",
                table: "INVOICEDTL",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "BIZDOCUMENT",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "BIZDOCUMENT",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BizLocID",
                table: "BIZDOCUMENT",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_INVOICEHDR",
                table: "INVOICEHDR",
                columns: new[] { "BizRegID", "BizLocID", "TransNo", "BillNo", "OrderNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_INVOICEDTL",
                table: "INVOICEDTL",
                columns: new[] { "BizLocID", "BizRegID", "TransNo", "TransSeq", "ItemCode", "OrderNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIZDOCUMENT",
                table: "BIZDOCUMENT",
                columns: new[] { "DocCode", "BizRegID", "BizLocID", "DocType" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_INVOICEHDR",
                table: "INVOICEHDR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_INVOICEDTL",
                table: "INVOICEDTL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BIZDOCUMENT",
                table: "BIZDOCUMENT");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "INVOICEHDR");

            migrationBuilder.DropColumn(
                name: "ApprovedBy",
                table: "INVOICEHDR");

            migrationBuilder.DropColumn(
                name: "ApprovedDate",
                table: "INVOICEHDR");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "INVOICEHDR");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "INVOICEDTL");

            migrationBuilder.DropColumn(
                name: "OrderSeq",
                table: "INVOICEDTL");

            migrationBuilder.DropColumn(
                name: "BizLocID",
                table: "BIZDOCUMENT");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransValueSpDisc",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransType",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransSubTotal",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransStatus",
                table: "INVOICEHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransStartTime",
                table: "INVOICEHDR",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransRemark",
                table: "INVOICEHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransReasonCode",
                table: "INVOICEHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransPointsStatus",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransPoints",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransPayTime",
                table: "INVOICEHDR",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransEndTime",
                table: "INVOICEHDR",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransDiscValue",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransDiscType",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscRemark",
                table: "INVOICEHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscReasonCode",
                table: "INVOICEHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscCode",
                table: "INVOICEHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransDiscAuth",
                table: "INVOICEHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransDiscAmt",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransChgAmt",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtSpDisc",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtSave",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtRnd",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmtOrg",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransAmt",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Training",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalServer",
                table: "INVOICEHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPoints",
                table: "INVOICEHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TillID",
                table: "INVOICEHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TermID",
                table: "INVOICEHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TblPax",
                table: "INVOICEHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TblNo",
                table: "INVOICEHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "INVOICEHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SpDiscRemark",
                table: "INVOICEHDR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SpDiscReasonCode",
                table: "INVOICEHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ShiftCode",
                table: "INVOICEHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ServerID",
                table: "INVOICEHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Profiled",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "LastSyncBy",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "InSvcID",
                table: "INVOICEHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "EmpType",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "INVOICEHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "CustType",
                table: "INVOICEHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CustPrivilege",
                table: "INVOICEHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustPkgID",
                table: "INVOICEHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CashierID",
                table: "INVOICEHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AuthSpDisc",
                table: "INVOICEHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AcctNo",
                table: "INVOICEHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BillNo",
                table: "INVOICEHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WarSerialNo",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitCost",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TolAmt",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<int>(
                name: "TermID",
                table: "INVOICEDTL",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Taxable",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubPoints",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "StkType",
                table: "INVOICEDTL",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StkDesc",
                table: "INVOICEDTL",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StkCode",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReturnCode",
                table: "INVOICEDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "INVOICEDTL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "RefSeq",
                table: "INVOICEDTL",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "INVOICEDTL",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PromoCode",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PriceOverrided",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PriceAuthID",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PrcDisplayType",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Points",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrgPrice",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NettPrice",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NettAmt",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsCal",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ExCode2",
                table: "INVOICEDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ExCode1",
                table: "INVOICEDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EntryTime",
                table: "INVOICEDTL",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Discounted",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscAmt",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "CustPkgID",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate5H",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate5G",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate4H",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate4G",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate3H",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate3G",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate2H",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate2G",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate1H",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CoRate1G",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "BillNo",
                table: "INVOICEDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BehvType",
                table: "INVOICEDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseRate",
                table: "INVOICEDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "BIZDOCUMENT",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "BIZDOCUMENT",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_INVOICEHDR",
                table: "INVOICEHDR",
                columns: new[] { "BizRegID", "BizLocID", "TransNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_INVOICEDTL",
                table: "INVOICEDTL",
                columns: new[] { "BizLocID", "BizRegID", "TransNo", "TransSeq", "ItemCode" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIZDOCUMENT",
                table: "BIZDOCUMENT",
                columns: new[] { "DocCode", "BizRegID", "DocType" });
        }
    }
}
