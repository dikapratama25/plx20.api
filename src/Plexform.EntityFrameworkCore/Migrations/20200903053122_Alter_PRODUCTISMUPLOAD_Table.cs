using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Alter_PRODUCTISMUPLOAD_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCTISMUPLOAD",
                table: "PRODUCTISMUPLOAD");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "PRODUCTISMUPLOAD",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "PRODUCTISMUPLOAD",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "PRODUCTISMUPLOAD",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "PRODUCTISMUPLOAD",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PRODUCTISMUPLOAD",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "PRODUCTISMUPLOAD",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PRODUCTISMUPLOAD",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "PRODUCTISMUPLOAD",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PRODUCTISMUPLOAD",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "PRODUCTISMUPLOAD",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<decimal>(
                name: "CodeNum",
                table: "PRODUCTISMUPLOAD",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateBy",
                table: "PRODUCTISMUPLOAD",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "SysCode",
                table: "PRODUCTISMUPLOAD",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCTISMUPLOAD",
                table: "PRODUCTISMUPLOAD",
                columns: new[] { "LastUpdate", "Code" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PRODUCTISMUPLOAD",
                table: "PRODUCTISMUPLOAD");

            migrationBuilder.DropColumn(
                name: "CodeNum",
                table: "PRODUCTISMUPLOAD");

            migrationBuilder.DropColumn(
                name: "LastUpdateBy",
                table: "PRODUCTISMUPLOAD");

            migrationBuilder.DropColumn(
                name: "SysCode",
                table: "PRODUCTISMUPLOAD");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "PRODUCTISMUPLOAD",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "PRODUCTISMUPLOAD",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "PRODUCTISMUPLOAD",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "PRODUCTISMUPLOAD",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "PRODUCTISMUPLOAD",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "PRODUCTISMUPLOAD",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PRODUCTISMUPLOAD",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "PRODUCTISMUPLOAD",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "PRODUCTISMUPLOAD",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "PRODUCTISMUPLOAD",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRODUCTISMUPLOAD",
                table: "PRODUCTISMUPLOAD",
                columns: new[] { "Code", "LastUpdate" });
        }
    }
}
