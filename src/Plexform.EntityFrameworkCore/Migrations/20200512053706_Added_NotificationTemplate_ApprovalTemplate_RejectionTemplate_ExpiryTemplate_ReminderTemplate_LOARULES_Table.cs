using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_NotificationTemplate_ApprovalTemplate_RejectionTemplate_ExpiryTemplate_ReminderTemplate_LOARULES_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovalTemplate",
                table: "LOARULES",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryTemplate",
                table: "LOARULES",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "NotificationTemplate",
                table: "LOARULES",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "RejectionTemplate",
                table: "LOARULES",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ReminderTemplate",
                table: "LOARULES",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "ExpiryTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "NotificationTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "RejectionTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "ReminderTemplate",
                table: "LOARULES");
        }
    }
}
