using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CAMPAIGNITEM_Table_20200527 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VatAmt",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Variance",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReq_C",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReq_B",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReqVar",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReq",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceRef",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UnitPriceRReq",
                table: "CAMPAIGNITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UnitPriceRRef",
                table: "CAMPAIGNITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceCamp",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceBase",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceAvgVar",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceAvg",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceAdd",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UOMRef",
                table: "CAMPAIGNITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UOM",
                table: "CAMPAIGNITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPriceReq",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPriceRef",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPriceBase",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxAmt",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotalReq",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CAMPAIGNITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo_B",
                table: "CAMPAIGNITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo",
                table: "CAMPAIGNITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QtyRmrkReq",
                table: "CAMPAIGNITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QtyRmrkRef",
                table: "CAMPAIGNITEM",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "QtyReq",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "QtyRef",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PointReq",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PointRef",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PackageCode",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Mechanic",
                table: "CAMPAIGNITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LineCode",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemName",
                table: "CAMPAIGNITEM",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc_B",
                table: "CAMPAIGNITEM",
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
                table: "CAMPAIGNITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscAmt",
                table: "CAMPAIGNITEM",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyReq",
                table: "CAMPAIGNITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyBase",
                table: "CAMPAIGNITEM",
                maxLength: 3,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ChangedBy_C",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ChangedBy_B",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AppInfo2",
                table: "CAMPAIGNITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AppInfo1",
                table: "CAMPAIGNITEM",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemCode",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CampNo",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "CAMPAIGNITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<byte>(
                name: "Active",
                table: "CAMPAIGNITEM",
                nullable: true,
                defaultValueSql: "(1)");

            migrationBuilder.AddColumn<byte>(
                name: "Inuse",
                table: "CAMPAIGNITEM",
                nullable: true,
                defaultValueSql: "(0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "CAMPAIGNITEM");

            migrationBuilder.DropColumn(
                name: "Inuse",
                table: "CAMPAIGNITEM");

            migrationBuilder.AlterColumn<decimal>(
                name: "VatAmt",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Variance",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReq_C",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReq_B",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReqVar",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceReq",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceRef",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UnitPriceRReq",
                table: "CAMPAIGNITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UnitPriceRRef",
                table: "CAMPAIGNITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceCamp",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceBase",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceAvgVar",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceAvg",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPriceAdd",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UOMRef",
                table: "CAMPAIGNITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UOM",
                table: "CAMPAIGNITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CAMPAIGNITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPriceReq",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPriceRef",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPriceBase",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TaxAmt",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotalReq",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CAMPAIGNITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CAMPAIGNITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo_B",
                table: "CAMPAIGNITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo",
                table: "CAMPAIGNITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QtyRmrkReq",
                table: "CAMPAIGNITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QtyRmrkRef",
                table: "CAMPAIGNITEM",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "QtyReq",
                table: "CAMPAIGNITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "QtyRef",
                table: "CAMPAIGNITEM",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CAMPAIGNITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PointReq",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PointRef",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PackageCode",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Mechanic",
                table: "CAMPAIGNITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CAMPAIGNITEM",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LineCode",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemName",
                table: "CAMPAIGNITEM",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc_B",
                table: "CAMPAIGNITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemDesc",
                table: "CAMPAIGNITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscAmt",
                table: "CAMPAIGNITEM",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyReq",
                table: "CAMPAIGNITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyBase",
                table: "CAMPAIGNITEM",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ChangedBy_C",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ChangedBy_B",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AppInfo2",
                table: "CAMPAIGNITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "AppInfo1",
                table: "CAMPAIGNITEM",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ItemCode",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CampNo",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "CAMPAIGNITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");
        }
    }
}
