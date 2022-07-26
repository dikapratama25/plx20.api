using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_STGAPPROVAL_Table_20200427 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "IsRead",
                table: "STGAPPROVAL",
                nullable: true,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "RefNo1",
                table: "STGAPPROVAL",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "RejectRemark",
                table: "STGAPPROVAL",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "STGAPPROVAL");

            migrationBuilder.DropColumn(
                name: "RefNo1",
                table: "STGAPPROVAL");

            migrationBuilder.DropColumn(
                name: "RejectRemark",
                table: "STGAPPROVAL");
        }
    }
}
