using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Update_MasterBalance_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "MasterBalance");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "MasterBalance",
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "MasterBalance",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "MasterBalance",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "MasterBalance",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "MasterBalance",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "MasterBalance",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "MasterBalance",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()");
        }
    }
}
