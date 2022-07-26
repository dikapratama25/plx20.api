using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_STGAPPROVAL_Table_20200326 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "STGAPPROVAL",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefID",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "STGAPPROVAL");

            migrationBuilder.DropColumn(
                name: "RefID",
                table: "STGAPPROVAL");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "STGAPPROVAL");
        }
    }
}
