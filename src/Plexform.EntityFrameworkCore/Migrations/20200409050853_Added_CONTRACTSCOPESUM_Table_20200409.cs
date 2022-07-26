using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CONTRACTSCOPESUM_Table_20200409 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_STATE",
                table: "STATE");

            migrationBuilder.RenameColumn(
                name: "isHost",
                table: "ITEMLOC",
                newName: "IsHost");

            migrationBuilder.RenameColumn(
                name: "isHost",
                table: "CONTRACTSCOPESUM",
                newName: "IsHost");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "STATE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "STATE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "STATE",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "STATE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "STATE",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "YtdQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "YrQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TypeCode",
                table: "ITEMLOC",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TrackSerial",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TariffCode",
                table: "ITEMLOC",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StorageID",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "StdSellPrice",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StdMarkup",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StdCost",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDesc",
                table: "ITEMLOC",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReOrderQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReOrderLvl",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtySellable",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOnHand",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyBalance",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyAdj",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PackUOM",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQtyBalance",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQtyAdj",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "POQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutgoingQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutgoingPackQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OrgCountry",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "MthQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MtdQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MinQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MaxQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "MarkNo",
                table: "ITEMLOC",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MATNo",
                table: "ITEMLOC",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LooseUOM",
                table: "ITEMLOC",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastRV",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPackOut",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPackIn",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPackAdj",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPO",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastOut",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastIn",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastAdj",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LYrQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LMthQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LDayQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItmSize2",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmSize1",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmSize",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmCatgCode",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmBrand",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc",
                table: "ITEMLOC",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemComponent",
                table: "ITEMLOC",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsWLength",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsTaxable",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsSelected",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsSales",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRtnable",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRecycle",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsPurchase",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsFOC",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsEmpDisc",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsDisc",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsBestBuy",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IncomingQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IncomingPackQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "ITEMLOC",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "FirstIn",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExpiredQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "DefUOM",
                table: "ITEMLOC",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "DayQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CummQty",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ConUOM",
                table: "ITEMLOC",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConSize",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ComboItem",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ClassType",
                table: "ITEMLOC",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BehvType",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BehvShow",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AvgCost",
                table: "ITEMLOC",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "LastSyncBy",
                table: "ITEMLOC",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "WorkerType",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransportAllowance",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusAdd",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceAllowance",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Salutation",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "EMPLOYEE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Role3",
                table: "EMPLOYEE",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Role2",
                table: "EMPLOYEE",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Role1",
                table: "EMPLOYEE",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Religion",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReferralID",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReferralCode",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Race",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PrivilegeCode",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Position2",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Position1",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnState",
                table: "EMPLOYEE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnPostalCode",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnCountry",
                table: "EMPLOYEE",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress4",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress3",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress2",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress1",
                table: "EMPLOYEE",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PlaceOfBirth",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "Overtime",
                table: "EMPLOYEE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OtherAllowance",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OffDay",
                table: "EMPLOYEE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "NRICNo",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Marital",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LoginType",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LocID",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Levy",
                table: "EMPLOYEE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Leave",
                table: "EMPLOYEE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "FromTransporter",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ForeignLocal",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "EmployeeType",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactPerson",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactNo",
                table: "EMPLOYEE",
                maxLength: 16,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "EMPLOYEE",
                maxLength: 80,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoState",
                table: "EMPLOYEE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoPostalCode",
                table: "EMPLOYEE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoCountry",
                table: "EMPLOYEE",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress4",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress3",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress2",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress1",
                table: "EMPLOYEE",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ClerkNo",
                table: "EMPLOYEE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "EMPLOYEE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Allergies",
                table: "EMPLOYEE",
                maxLength: 70,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "AccessLvl",
                table: "EMPLOYEE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsServer",
                table: "EMPBRANCH",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "InAppt",
                table: "EMPBRANCH",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "CONTRACTSCOPESUM",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "VariationID",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UOM",
                table: "CONTRACTSCOPESUM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "CONTRACTSCOPESUM",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SvcType",
                table: "CONTRACTSCOPESUM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StreetCode",
                table: "CONTRACTSCOPESUM",
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
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeType",
                table: "CONTRACTSCOPESUM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SchemeNo",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RouteSchType",
                table: "CONTRACTSCOPESUM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RouteSchNo",
                table: "CONTRACTSCOPESUM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RouteNo",
                table: "CONTRACTSCOPESUM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt4",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt3",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt2",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt1",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark2",
                table: "CONTRACTSCOPESUM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CONTRACTSCOPESUM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ProcType",
                table: "CONTRACTSCOPESUM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "CONTRACTSCOPESUM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Packaging",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PBTCode",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "MastType",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MastQty",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "MastCode",
                table: "CONTRACTSCOPESUM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocCurrency",
                table: "CONTRACTSCOPESUM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastRate",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPrice",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "ItemType",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFrequency",
                table: "CONTRACTSCOPESUM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqType",
                table: "CONTRACTSCOPESUM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqCode",
                table: "CONTRACTSCOPESUM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemCycle",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemCode",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ErrCode",
                table: "CONTRACTSCOPESUM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "CONTRACTSCOPESUM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DefCurrency",
                table: "CONTRACTSCOPESUM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CONTRACTSCOPESUM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrRate",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "CONTRACTSCOPESUM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CollectionAddress",
                table: "CONTRACTSCOPESUM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "AvgPrice",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt4",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt3",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt2",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt1",
                table: "CONTRACTSCOPESUM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ZoneNo",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WBSElement",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCode",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SuppPartNo",
                table: "CONTRACTITEM",
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
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "StatisticCode",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNo",
                table: "CONTRACTITEM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "SellType",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeType",
                table: "CONTRACTITEM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeID",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SchemeNo",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RevenueID",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "ReleaseType",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RefSeqNo",
                table: "CONTRACTITEM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReconcile",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReconLeftP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReconLeft",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReceived",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyRecLeftP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyRecLeft",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOrdered",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOrdLeftP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOrdLeft",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PayMethod",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PayFreqType",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "PayFreq",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PackUOM",
                table: "CONTRACTITEM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialNo2",
                table: "CONTRACTITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialNo1",
                table: "CONTRACTITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocCurrency",
                table: "CONTRACTITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "LineType",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItmCatgQty",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItmCatgCode",
                table: "CONTRACTITEM",
                maxLength: 8,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemUOM",
                table: "CONTRACTITEM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "CONTRACTITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemQtyMax",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemQty",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemName",
                table: "CONTRACTITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFrequency",
                table: "CONTRACTITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqType",
                table: "CONTRACTITEM",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqCode",
                table: "CONTRACTITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc",
                table: "CONTRACTITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemCost",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemContSplitP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemCode",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemAmtMax",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRecycle",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsPack",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "InternalOrder",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InitQty",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DefCurrency",
                table: "CONTRACTITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrRate",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CostCenter",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommodityERP",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Commodity",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AssetCode",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "AmtReconcileP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcileA",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcile",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReceived",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtRecLeftP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtRecLeft",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtOrdered",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtOrdLeftP",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtOrdLeft",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AddQty",
                table: "CONTRACTITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountCode",
                table: "CONTRACTITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "VersionNo",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "VerifiedBy",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Tolerance",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TerminateBy",
                table: "CONTRACTHDR",
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
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SourceSystem",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceType",
                table: "CONTRACTHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RequestID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CONTRACTHDR",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RelatedID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RegistedSupp",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReferID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo2",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo1",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefBatchCode2",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefBatchCode1",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Reason3",
                table: "CONTRACTHDR",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Reason2",
                table: "CONTRACTHDR",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Reason1",
                table: "CONTRACTHDR",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProcureUnit",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "PartitionNo",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "NextPayID",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NextPayAmt",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LocCurrency",
                table: "CONTRACTHDR",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "KppVerifiedBy",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsService",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsReceivable",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsLapsed",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsInvoiceable",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsApproved",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "DestRegID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CONTRACTHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DefCurrency",
                table: "CONTRACTHDR",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DeclineBy",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrRate",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ContractNo",
                table: "CONTRACTHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContState",
                table: "CONTRACTHDR",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContPBT",
                table: "CONTRACTHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContNature",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "ContDuration",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ContDaysLeft",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ContCountry",
                table: "CONTRACTHDR",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContComp",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CollectionAddress",
                table: "CONTRACTHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLicID",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BatchCode",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AuthPOS",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AuthID",
                table: "CONTRACTHDR",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalFlow",
                table: "CONTRACTHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "AmtUsedP",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtUsed",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtReconcileP",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcileA",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcile",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtLeftAVGP",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtLeftAVG",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtInvoicedP",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtInvoicedA",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtInvoiced",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitment",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitOrg2",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitOrg1",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitMin",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitMax",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt",
                table: "CONTRACTHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "BIZLOCATE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UnitID",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StoreType",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "StoreStatus",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "BIZLOCATE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SalesItemType",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "BIZLOCATE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount2",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount1",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RcpHeader",
                table: "BIZLOCATE",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RcpFooter",
                table: "BIZLOCATE",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PriceLevel",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PBT",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OpTimeStart",
                table: "BIZLOCATE",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OpTimeEnd",
                table: "BIZLOCATE",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OpPrevBook",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay7",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay6",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay5",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay4",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay3",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay2",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay1",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OpBookLast",
                table: "BIZLOCATE",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OpBookIntv",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OpBookFirst",
                table: "BIZLOCATE",
                maxLength: 4,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OpBookAlwHR",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "OpBookAlwDY",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsStockTake",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "IndustryType",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "InSvcItemType",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "GenInSvcID",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "BIZLOCATE",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "BIZLOCATE",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "BIZLOCATE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "BIZLOCATE",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactTelNo",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson",
                table: "BIZLOCATE",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactMobile",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "BIZLOCATE",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDesignation",
                table: "BIZLOCATE",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "BIZLOCATE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "CapacityLevel",
                table: "BIZLOCATE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "BusinessType",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BranchType",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "BIZLOCATE",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BranchCode",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegType",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegStatus",
                table: "BIZLOCATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "BizCatgID",
                table: "BIZLOCATE",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankName",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankAccount",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "BIZLOCATE",
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
                table: "BIZLOCATE",
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
                table: "BIZLOCATE",
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
                table: "BIZLOCATE",
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
                table: "BIZLOCATE",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AccNo",
                table: "BIZLOCATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "BIZGROUP",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "BIZGROUP",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "BIZGROUP",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "BIZGROUP",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "BIZGROUP",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "BIZGROUP",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(1)");

            migrationBuilder.AddColumn<string>(
                name: "LastSyncBy",
                table: "BIZGROUP",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress4",
                table: "BIZENTITY",
                maxLength: 40,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress3",
                table: "BIZENTITY",
                maxLength: 100,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress2",
                table: "BIZENTITY",
                maxLength: 100,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress1",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "SubGrp",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "StoreStatus",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "BIZENTITY",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SMSAlertNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "ReqSupp",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReqNo",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReqCode",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark2",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "BIZENTITY",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RegNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo2",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo1",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount2",
                table: "BIZENTITY",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount1",
                table: "BIZENTITY",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PrivilegeCode",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PBT",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl3",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl2",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl1",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsTermAgr",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRateAgr",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsNew",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "InitName",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "IndustryType",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ICNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FileNo",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FaxNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "BIZENTITY",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactRace",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonTelNo2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonTelNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonMobile2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonMobile",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonFaxNo2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonFaxNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonEmail2",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonEmail",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson2",
                table: "BIZENTITY",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson",
                table: "BIZENTITY",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDesignation2",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDesignation",
                table: "BIZENTITY",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyType",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "BIZENTITY",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoWebsite",
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BusinessType",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BizType",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegType",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegStatus",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizGrp",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "BizCatgID",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankCode2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankCode1",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankAccount2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankAccount1",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "BIZENTITY",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "AgrRenew2",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "AgrRenew",
                table: "BIZENTITY",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "AgrNo2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AgrNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "BIZENTITY",
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
                table: "BIZENTITY",
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
                table: "BIZENTITY",
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
                table: "BIZENTITY",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AcctNo2",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AcctNo",
                table: "BIZENTITY",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "BIZDOCUMENT",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "BIZDOCUMENT",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "BIZDOCUMENT",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "PathRef",
                table: "BIZDOCUMENT",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "BIZDOCUMENT",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "DocMode",
                table: "BIZDOCUMENT",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BIZDOCUMENT",
                maxLength: 70,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DataKey",
                table: "BIZDOCUMENT",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "Active",
                table: "BIZDOCUMENT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastSyncBy",
                table: "BIZDOCUMENT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATE",
                table: "STATE",
                columns: new[] { "CountryCode", "StateCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_STATE",
                table: "STATE");

            migrationBuilder.DropColumn(
                name: "LastSyncBy",
                table: "ITEMLOC");

            migrationBuilder.DropColumn(
                name: "LastSyncBy",
                table: "BIZGROUP");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "BIZDOCUMENT");

            migrationBuilder.DropColumn(
                name: "LastSyncBy",
                table: "BIZDOCUMENT");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "ITEMLOC",
                newName: "isHost");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "CONTRACTSCOPESUM",
                newName: "isHost");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "STATE",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "STATE",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "STATE",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "STATE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "STATE",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "YtdQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "YrQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TypeCode",
                table: "ITEMLOC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TrackSerial",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TariffCode",
                table: "ITEMLOC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StorageID",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "StdSellPrice",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StdMarkup",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "StdCost",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDesc",
                table: "ITEMLOC",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReOrderQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ReOrderLvl",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtySellable",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOnHand",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyBalance",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyAdj",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PackUOM",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQtyBalance",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQtyAdj",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "POQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutgoingQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "OutgoingPackQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OrgCountry",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "MthQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MtdQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MinQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MaxQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "MarkNo",
                table: "ITEMLOC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MATNo",
                table: "ITEMLOC",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LooseUOM",
                table: "ITEMLOC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastRV",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPackOut",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPackIn",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPackAdj",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPO",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastOut",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastIn",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastAdj",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LYrQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LMthQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LDayQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItmSize2",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmSize1",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmSize",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmCatgCode",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItmBrand",
                table: "ITEMLOC",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc",
                table: "ITEMLOC",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemComponent",
                table: "ITEMLOC",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsWLength",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsTaxable",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsSelected",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsSales",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRtnable",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRecycle",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsPurchase",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsFOC",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsEmpDisc",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsDisc",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsBestBuy",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IncomingQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IncomingPackQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "ITEMLOC",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "FirstIn",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExpiredQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "DefUOM",
                table: "ITEMLOC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "DayQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CummQty",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ConUOM",
                table: "ITEMLOC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ConSize",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ComboItem",
                table: "ITEMLOC",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ClassType",
                table: "ITEMLOC",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BehvType",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BehvShow",
                table: "ITEMLOC",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AvgCost",
                table: "ITEMLOC",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "WorkerType",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TransportAllowance",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SyncCreateBy",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusAdd",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "EMPLOYEE",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceAllowance",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Salutation",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "EMPLOYEE",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Role3",
                table: "EMPLOYEE",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Role2",
                table: "EMPLOYEE",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Role1",
                table: "EMPLOYEE",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Religion",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReferralID",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReferralCode",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Race",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PrivilegeCode",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Position2",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Position1",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnState",
                table: "EMPLOYEE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnPostalCode",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnCountry",
                table: "EMPLOYEE",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress4",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress3",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress2",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PnAddress1",
                table: "EMPLOYEE",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PlaceOfBirth",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "Overtime",
                table: "EMPLOYEE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OtherAllowance",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OffDay",
                table: "EMPLOYEE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "NickName",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "NRICNo",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Marital",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LoginType",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LocID",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Levy",
                table: "EMPLOYEE",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Leave",
                table: "EMPLOYEE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "FromTransporter",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ForeignLocal",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "EmployeeType",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactPerson",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmerContactNo",
                table: "EMPLOYEE",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 16,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "EMPLOYEE",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoState",
                table: "EMPLOYEE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoPostalCode",
                table: "EMPLOYEE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoCountry",
                table: "EMPLOYEE",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress4",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress3",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress2",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoAddress1",
                table: "EMPLOYEE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ClerkNo",
                table: "EMPLOYEE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "EMPLOYEE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Allergies",
                table: "EMPLOYEE",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 70,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "AccessLvl",
                table: "EMPLOYEE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsServer",
                table: "EMPBRANCH",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "InAppt",
                table: "EMPBRANCH",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "VariationID",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UOM",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SyncLastUpd",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SvcType",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StreetCode",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeType",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SchemeNo",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RouteSchType",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RouteSchNo",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RouteNo",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt4",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt3",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt2",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt1",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark2",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rate",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ProcType",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Packaging",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PBTCode",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "MastType",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MastQty",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "MastCode",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocCurrency",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastRate",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LastPrice",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "ItemType",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFrequency",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqType",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqCode",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemCycle",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemCode",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "isHost",
                table: "CONTRACTSCOPESUM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ErrCode",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DefCurrency",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrRate",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CollectionAddress",
                table: "CONTRACTSCOPESUM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "AvgPrice",
                table: "CONTRACTSCOPESUM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt4",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt3",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt2",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt1",
                table: "CONTRACTSCOPESUM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ZoneNo",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WBSElement",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCode",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SuppPartNo",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "StatisticCode",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SerialNo",
                table: "CONTRACTITEM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "SellType",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeType",
                table: "CONTRACTITEM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ScopeID",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SchemeNo",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RevenueID",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "ReleaseType",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RefSeqNo",
                table: "CONTRACTITEM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReconcile",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReconLeftP",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReconLeft",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyReceived",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyRecLeftP",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyRecLeft",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOrdered",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOrdLeftP",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "QtyOrdLeft",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PayMethod",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PayFreqType",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "PayFreq",
                table: "CONTRACTITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(int),
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PackUOM",
                table: "CONTRACTITEM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialNo2",
                table: "CONTRACTITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MaterialNo1",
                table: "CONTRACTITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocCurrency",
                table: "CONTRACTITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "LineType",
                table: "CONTRACTITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItmCatgQty",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItmCatgCode",
                table: "CONTRACTITEM",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemUOM",
                table: "CONTRACTITEM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "CONTRACTITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemQtyMax",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemQty",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemPrice",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemName",
                table: "CONTRACTITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFrequency",
                table: "CONTRACTITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqType",
                table: "CONTRACTITEM",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemFreqCode",
                table: "CONTRACTITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc",
                table: "CONTRACTITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemCost",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemContSplitP",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemCode",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemAmtMax",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRecycle",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsPack",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "InternalOrder",
                table: "CONTRACTITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InitQty",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DefCurrency",
                table: "CONTRACTITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrRate",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CostCenter",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommodityERP",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Commodity",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AssetCode",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "AmtReconcileP",
                table: "CONTRACTITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcileA",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcile",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReceived",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtRecLeftP",
                table: "CONTRACTITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtRecLeft",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtOrdered",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtOrdLeftP",
                table: "CONTRACTITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtOrdLeft",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AddQty",
                table: "CONTRACTITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountCode",
                table: "CONTRACTITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "VersionNo",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "VerifiedBy",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Tolerance",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TerminateBy",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SourceSystem",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceType",
                table: "CONTRACTHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RequestID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "ReqResCnt",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CONTRACTHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RelatedID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RegistedSupp",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReferID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo2",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo1",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefBatchCode2",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefBatchCode1",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Reason3",
                table: "CONTRACTHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Reason2",
                table: "CONTRACTHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Reason1",
                table: "CONTRACTHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProcureUnit",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "PartitionNo",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "NextPayID",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "NextPayAmt",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LocCurrency",
                table: "CONTRACTHDR",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "KppVerifiedBy",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsService",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsReceivable",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsLapsed",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsInvoiceable",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsApproved",
                table: "CONTRACTHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "DestRegID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CONTRACTHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DefCurrency",
                table: "CONTRACTHDR",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DeclineBy",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CurrRate",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ContractNo",
                table: "CONTRACTHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContState",
                table: "CONTRACTHDR",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContPBT",
                table: "CONTRACTHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContNature",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "ContDuration",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ContDaysLeft",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ContCountry",
                table: "CONTRACTHDR",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContComp",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CollectionAddress",
                table: "CONTRACTHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLicID",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BatchCode",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AuthPOS",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AuthID",
                table: "CONTRACTHDR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalFlow",
                table: "CONTRACTHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "AmtUsedP",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtUsed",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtReconcileP",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcileA",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtReconcile",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtLeftAVGP",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtLeftAVG",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "AmtInvoicedP",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtInvoicedA",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtInvoiced",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitment",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitOrg2",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitOrg1",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitMin",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AmtCommitMax",
                table: "CONTRACTHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ActResCnt",
                table: "CONTRACTHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UnitID",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StoreType",
                table: "BIZLOCATE",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "StoreStatus",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "BIZLOCATE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SalesItemType",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "BIZLOCATE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount2",
                table: "BIZLOCATE",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount1",
                table: "BIZLOCATE",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RcpHeader",
                table: "BIZLOCATE",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RcpFooter",
                table: "BIZLOCATE",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "PriceLevel",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PBT",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OpTimeStart",
                table: "BIZLOCATE",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OpTimeEnd",
                table: "BIZLOCATE",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OpPrevBook",
                table: "BIZLOCATE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay7",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay6",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay5",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay4",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay3",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay2",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "OpDay1",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OpBookLast",
                table: "BIZLOCATE",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OpBookIntv",
                table: "BIZLOCATE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "OpBookFirst",
                table: "BIZLOCATE",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "OpBookAlwHR",
                table: "BIZLOCATE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "OpBookAlwDY",
                table: "BIZLOCATE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsStockTake",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "IndustryType",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "InSvcItemType",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "GenInSvcID",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Fax",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "BIZLOCATE",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "BIZLOCATE",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "BIZLOCATE",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactTelNo",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson",
                table: "BIZLOCATE",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactMobile",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "BIZLOCATE",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDesignation",
                table: "BIZLOCATE",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "BIZLOCATE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "CapacityLevel",
                table: "BIZLOCATE",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "BusinessType",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BranchType",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "BIZLOCATE",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BranchCode",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegType",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegStatus",
                table: "BIZLOCATE",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "BizCatgID",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankName",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankAccount",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "BIZLOCATE",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "BIZLOCATE",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address3",
                table: "BIZLOCATE",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "BIZLOCATE",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "BIZLOCATE",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AccNo",
                table: "BIZLOCATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "BIZGROUP",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "BIZGROUP",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "BIZGROUP",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "BIZGROUP",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "BIZGROUP",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "BIZGROUP",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress4",
                table: "BIZENTITY",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress3",
                table: "BIZENTITY",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress2",
                table: "BIZENTITY",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "WCAddress1",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TelNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "SubGrp",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "StoreStatus",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "BIZENTITY",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SMSAlertNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "ReqSupp",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReqNo",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReqCode",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark2",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "BIZENTITY",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RegNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo2",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo1",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount2",
                table: "BIZENTITY",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RefAmount1",
                table: "BIZENTITY",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PrivilegeCode",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PBT",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Owner",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl3",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl2",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MediaUrl1",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsTermAgr",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsRateAgr",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "IsNew",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "InitName",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "IndustryType",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ICNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FileNo",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FaxNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "BIZENTITY",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactRace",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonTelNo2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonTelNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonMobile2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonMobile",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonFaxNo2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonFaxNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonEmail2",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPersonEmail",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson2",
                table: "BIZENTITY",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactPerson",
                table: "BIZENTITY",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDesignation2",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ContactDesignation",
                table: "BIZENTITY",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyType",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "BIZENTITY",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CoWebsite",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BusinessType",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "BizType",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegType",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizRegStatus",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "BizGrp",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "BizCatgID",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankCode2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankCode1",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankAccount2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankAccount1",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "BIZENTITY",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "AgrRenew2",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "AgrRenew",
                table: "BIZENTITY",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "AgrNo2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AgrNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "BIZENTITY",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address3",
                table: "BIZENTITY",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "BIZENTITY",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "BIZENTITY",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AcctNo2",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AcctNo",
                table: "BIZENTITY",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "BIZDOCUMENT",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "BIZDOCUMENT",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "BIZDOCUMENT",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "PathRef",
                table: "BIZDOCUMENT",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "BIZDOCUMENT",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "DocMode",
                table: "BIZDOCUMENT",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BIZDOCUMENT",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 70,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DataKey",
                table: "BIZDOCUMENT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATE",
                table: "STATE",
                columns: new[] { "rowguid", "CountryCode", "StateCode" });
        }
    }
}
