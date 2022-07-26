using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_3_colomn_TASKASSIGN_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActionDate",
                table: "TASKASSIGN",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionTakenBy",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextActionBy",
                table: "TASKASSIGN",
                maxLength: 2000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionDate",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "ActionTakenBy",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "NextActionBy",
                table: "TASKASSIGN");
        }
    }
}
