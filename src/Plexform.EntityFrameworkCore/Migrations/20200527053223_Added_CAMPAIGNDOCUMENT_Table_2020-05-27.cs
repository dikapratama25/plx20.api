using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CAMPAIGNDOCUMENT_Table_20200527 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransType",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalQty",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalCampAmt",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CAMPAIGNHDR",
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
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "CAMPAIGNHDR",
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
                table: "CAMPAIGNHDR",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "CAMPAIGNHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "CampType",
                table: "CAMPAIGNHDR",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CampOrgAmt",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CampDisc",
                table: "CAMPAIGNHDR",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 9,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy_B",
                table: "CAMPAIGNHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "CAMPAIGNHDR",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "Active",
                table: "CAMPAIGNHDR",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Inuse",
                table: "CAMPAIGNHDR",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "URLRef",
                table: "CAMPAIGNDOCUMENT",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CAMPAIGNDOCUMENT",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CAMPAIGNDOCUMENT",
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
                table: "CAMPAIGNDOCUMENT",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PathRef",
                table: "CAMPAIGNDOCUMENT",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CAMPAIGNDOCUMENT",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "CAMPAIGNDOCUMENT",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "DocType",
                table: "CAMPAIGNDOCUMENT",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "DocMode",
                table: "CAMPAIGNDOCUMENT",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "DocCode",
                table: "CAMPAIGNDOCUMENT",
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
                table: "CAMPAIGNDOCUMENT",
                maxLength: 70,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateMethod",
                table: "CAMPAIGNDOCUMENT",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "Active",
                table: "CAMPAIGNDOCUMENT",
                nullable: true,
                defaultValueSql: "(1)");

            migrationBuilder.AddColumn<string>(
                name: "LastSyncBy",
                table: "CAMPAIGNDOCUMENT",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "CAMPAIGNHDR");

            migrationBuilder.DropColumn(
                name: "Inuse",
                table: "CAMPAIGNHDR");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "CAMPAIGNDOCUMENT");

            migrationBuilder.DropColumn(
                name: "LastSyncBy",
                table: "CAMPAIGNDOCUMENT");

            migrationBuilder.AlterColumn<byte>(
                name: "TransVoid",
                table: "CAMPAIGNHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "TransType",
                table: "CAMPAIGNHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalQty",
                table: "CAMPAIGNHDR",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalCampAmt",
                table: "CAMPAIGNHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CAMPAIGNHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CAMPAIGNHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CAMPAIGNHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "LiveCal",
                table: "CAMPAIGNHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "CAMPAIGNHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CAMPAIGNHDR",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "CAMPAIGNHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "CampType",
                table: "CAMPAIGNHDR",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<decimal>(
                name: "CampOrgAmt",
                table: "CAMPAIGNHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "CampDisc",
                table: "CAMPAIGNHDR",
                type: "decimal(18,2)",
                maxLength: 9,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy_B",
                table: "CAMPAIGNHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "CAMPAIGNHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "URLRef",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CAMPAIGNDOCUMENT",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "CAMPAIGNDOCUMENT",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "PathRef",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "CAMPAIGNDOCUMENT",
                type: "datetime",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocType",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "DocMode",
                table: "CAMPAIGNDOCUMENT",
                type: "int",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "DocCode",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 70,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateMethod",
                table: "CAMPAIGNDOCUMENT",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");
        }
    }
}
