using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class workorderhdrdtl_20200623 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "WorkType",
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleID",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransportType",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransportQty",
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SvcType",
                table: "WORKORDERHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubOri2",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubOri1",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubDest2",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubDest1",
                table: "WORKORDERHDR",
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
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "WORKORDERHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNo",
                table: "WORKORDERHDR",
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
                table: "WORKORDERHDR",
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
                table: "WORKORDERHDR",
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
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptNo",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "ProcType",
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "ProcStatus",
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentType",
                table: "WORKORDERHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocID",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocDesc3",
                table: "WORKORDERHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocDesc2",
                table: "WORKORDERHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocDesc1",
                table: "WORKORDERHDR",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsParent",
                table: "WORKORDERHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "WORKORDERHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DestRegID",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ChequeNo",
                table: "WORKORDERHDR",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankID",
                table: "WORKORDERHDR",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UOM",
                table: "WORKORDERDTL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TreatmentType",
                table: "WORKORDERDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotAmt3",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotAmt2",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotAmt1",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SvcType",
                table: "WORKORDERDTL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "SentQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SentPackQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "SellType",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice3",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice2",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice1",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark3",
                table: "WORKORDERDTL",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark2",
                table: "WORKORDERDTL",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark1",
                table: "WORKORDERDTL",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo",
                table: "WORKORDERDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "RecQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RecPackQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Rating3",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Rating2",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Rating1",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PackUOM",
                table: "WORKORDERDTL",
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
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Multiplier",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "WORKORDERDTL",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsPack",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InitQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSign3",
                table: "WORKORDERDTL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSign2",
                table: "WORKORDERDTL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSign1",
                table: "WORKORDERDTL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageRes3",
                table: "WORKORDERDTL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageRes2",
                table: "WORKORDERDTL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageRes1",
                table: "WORKORDERDTL",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostAmt3",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostAmt2",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostAmt1",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseRate",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjPackQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AddQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualQty2",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualQty1",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualPackQty",
                table: "WORKORDERDTL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "WorkType",
                table: "WORKORDERHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleID",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TransportType",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TransportQty",
                table: "WORKORDERHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SvcType",
                table: "WORKORDERHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubOri2",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubOri1",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubDest2",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "SubDest1",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "WORKORDERHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "WORKORDERHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReferenceNo",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo2",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo1",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptNo",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "ProcType",
                table: "WORKORDERHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "ProcStatus",
                table: "WORKORDERHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "WORKORDERHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentType",
                table: "WORKORDERHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocID",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocDesc3",
                table: "WORKORDERHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocDesc2",
                table: "WORKORDERHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LocDesc1",
                table: "WORKORDERHDR",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsParent",
                table: "WORKORDERHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "WORKORDERHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DestRegID",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "WORKORDERHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ChequeNo",
                table: "WORKORDERHDR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BankID",
                table: "WORKORDERHDR",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UOM",
                table: "WORKORDERDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "TreatmentType",
                table: "WORKORDERDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotAmt3",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotAmt2",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotAmt1",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "SvcType",
                table: "WORKORDERDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "SentQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SentPackQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "SellType",
                table: "WORKORDERDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice3",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice2",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice1",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark3",
                table: "WORKORDERDTL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark2",
                table: "WORKORDERDTL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark1",
                table: "WORKORDERDTL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefNo",
                table: "WORKORDERDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "RecQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "RecPackQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Rating3",
                table: "WORKORDERDTL",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Rating2",
                table: "WORKORDERDTL",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Rating1",
                table: "WORKORDERDTL",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PackUOM",
                table: "WORKORDERDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "PackQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Multiplier",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "WORKORDERDTL",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsPack",
                table: "WORKORDERDTL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "InitQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSign3",
                table: "WORKORDERDTL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSign2",
                table: "WORKORDERDTL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageSign1",
                table: "WORKORDERDTL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageRes3",
                table: "WORKORDERDTL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageRes2",
                table: "WORKORDERDTL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ImageRes1",
                table: "WORKORDERDTL",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostAmt3",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostAmt2",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostAmt1",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseRate",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AdjPackQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "AddQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualQty2",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualQty1",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualPackQty",
                table: "WORKORDERDTL",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");
        }
    }
}
