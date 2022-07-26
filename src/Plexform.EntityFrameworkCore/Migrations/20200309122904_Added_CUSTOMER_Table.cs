using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CUSTOMER_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CUSTOMER",
                table: "CUSTOMER");

            migrationBuilder.AddColumn<string>(
                name: "LowerLimitCurrency",
                table: "LOARULES",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpperLimitCurrency",
                table: "LOARULES",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BizRegID",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "BizLocID",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CUSTOMER",
                table: "CUSTOMER",
                columns: new[] { "CustomerID", "BizRegID", "BizLocID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CUSTOMER",
                table: "CUSTOMER");

            migrationBuilder.DropColumn(
                name: "LowerLimitCurrency",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "UpperLimitCurrency",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "BizRegID",
                table: "CUSTOMER");

            migrationBuilder.DropColumn(
                name: "BizLocID",
                table: "CUSTOMER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CUSTOMER",
                table: "CUSTOMER",
                column: "CustomerID");
        }
    }
}
