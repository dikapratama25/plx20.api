using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_Seq_On_TASKASSIGN_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<int>(
                name: "Seq",
                table: "TASKASSIGN",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN",
                columns: new[] { "TaskID", "Seq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "Seq",
                table: "TASKASSIGN");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "TASKASSIGN",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN",
                column: "TaskID");
        }
    }
}
