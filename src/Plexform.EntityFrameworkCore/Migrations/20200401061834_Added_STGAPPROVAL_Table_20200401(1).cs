using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_STGAPPROVAL_Table_202004011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_STATE",
                table: "STATE");

            migrationBuilder.AddColumn<string>(
                name: "BankCode1",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "STATE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "StateDesc",
                table: "STATE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RegionCode",
                table: "STATE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "OldStateCode",
                table: "STATE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "STATE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "STATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "STATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "STATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "EmailState",
                table: "STATE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "STATE",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "STATE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "STATE",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "StateCode",
                table: "STATE",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "STATE",
                maxLength: 2,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATE",
                table: "STATE",
                columns: new[] { "rowguid", "CountryCode", "StateCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_STATE",
                table: "STATE");

            migrationBuilder.DropColumn(
                name: "BankCode1",
                table: "STGAPPROVAL");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "STATE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "StateDesc",
                table: "STATE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RegionCode",
                table: "STATE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OldStateCode",
                table: "STATE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "STATE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "STATE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "STATE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "STATE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailState",
                table: "STATE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "STATE",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "STATE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "STATE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "StateCode",
                table: "STATE",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "STATE",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STATE",
                table: "STATE",
                columns: new[] { "CountryCode", "StateCode" });
        }
    }
}
