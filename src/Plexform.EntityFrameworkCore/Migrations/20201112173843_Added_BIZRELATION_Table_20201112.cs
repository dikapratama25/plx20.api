using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_BIZRELATION_Table_20201112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BIZRELATION",
                table: "BIZRELATION");

            migrationBuilder.AlterColumn<int>(
                name: "TID",
                table: "BIZRELATION",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIZRELATION",
                table: "BIZRELATION",
                columns: new[] { "BizRegID", "PaxRegID", "PaxUserID", "TypeCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BIZRELATION",
                table: "BIZRELATION");

            migrationBuilder.AlterColumn<int>(
                name: "TID",
                table: "BIZRELATION",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIZRELATION",
                table: "BIZRELATION",
                columns: new[] { "TID", "BizRegID", "PaxRegID", "PaxUserID" });
        }
    }
}
