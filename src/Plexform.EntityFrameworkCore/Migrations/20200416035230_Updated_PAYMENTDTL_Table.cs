using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Updated_PAYMENTDTL_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinetOth",
                table: "PAYMENTDTL");

            migrationBuilder.AddColumn<decimal>(
                name: "LineOth",
                table: "PAYMENTDTL",
                nullable: false,
                defaultValueSql: "(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineOth",
                table: "PAYMENTDTL");

            migrationBuilder.AddColumn<decimal>(
                name: "LinetOth",
                table: "PAYMENTDTL",
                type: "decimal(18,2)",
                nullable: false,
                defaultValueSql: "(1)");
        }
    }
}
