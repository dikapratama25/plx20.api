using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_LOA_Table_20200914 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalDTL");

            migrationBuilder.DropTable(
                name: "ApprovalHDR");

            migrationBuilder.DropTable(
                name: "EMPAPPROVER");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "TASKLOG");

            migrationBuilder.DropColumn(
                name: "NextActionBy",
                table: "TASKLOG");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "TASKLOG");

            migrationBuilder.DropColumn(
                name: "Seq",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "ActionDate",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "ActionTakenBy",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "NextActionBy",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "ActionLink",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "ApprovalTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "ExpiryTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "LowerLimitCurrency",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "NotificationTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "RejectAction",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "RejectionTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "ReminderTemplate",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "UpperLimitCurrency",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "ActionLink",
                table: "APPTRAIL");

            migrationBuilder.RenameColumn(
                name: "Rowguid",
                table: "TASKLOG",
                newName: "rowguid");

            migrationBuilder.RenameColumn(
                name: "Ishost",
                table: "TASKLOG",
                newName: "IsHost");

            migrationBuilder.RenameColumn(
                name: "Rowguid",
                table: "TASKASSIGN",
                newName: "rowguid");

            migrationBuilder.RenameColumn(
                name: "Ishost",
                table: "TASKASSIGN",
                newName: "IsHost");

            migrationBuilder.RenameColumn(
                name: "Rowguid",
                table: "LOARULES",
                newName: "rowguid");

            migrationBuilder.RenameColumn(
                name: "Ishost",
                table: "LOARULES",
                newName: "IsHost");

            migrationBuilder.RenameColumn(
                name: "Rowguid",
                table: "LOA",
                newName: "rowguid");

            migrationBuilder.RenameColumn(
                name: "Ishost",
                table: "LOA",
                newName: "IsHost");

            migrationBuilder.RenameColumn(
                name: "Rowguid",
                table: "APPTRAIL",
                newName: "rowguid");

            migrationBuilder.RenameColumn(
                name: "Ishost",
                table: "APPTRAIL",
                newName: "IsHost");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "TASKLOG",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TaskType",
                table: "TASKLOG",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "TaskCode",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "TASKLOG",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "TASKLOG",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalID",
                table: "TASKLOG",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TaskType",
                table: "TASKASSIGN",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaskCode",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "TASKASSIGN",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "TASKASSIGN",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalID",
                table: "TASKASSIGN",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<decimal>(
                name: "UpperUnBudgetAmt",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpperSign",
                table: "LOARULES",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "UpperBudgetAmt",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "LOARULES",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Seq",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesType",
                table: "LOARULES",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesReff",
                table: "LOARULES",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "LOARULES",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesCode",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RulesBy",
                table: "LOARULES",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RoleID",
                table: "LOARULES",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "MinApprover",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LowerUnBudgetAmt",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<decimal>(
                name: "LowerBudgetAmt",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LogicCondition",
                table: "LOARULES",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprCode",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "LOA",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesType",
                table: "LOA",
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "LOA",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "LOA",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "LOA",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LOAType",
                table: "LOA",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LOADesc",
                table: "LOA",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOACode",
                table: "LOA",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "LOA",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "LOA",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "AppliedUrl",
                table: "LOA",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "APPTRAIL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Seq",
                table: "APPTRAIL",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "APPTRAIL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "ApprovalType",
                table: "APPTRAIL",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalCode",
                table: "APPTRAIL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN",
                column: "TaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN");

            migrationBuilder.DropColumn(
                name: "AppliedUrl",
                table: "LOA");

            migrationBuilder.RenameColumn(
                name: "rowguid",
                table: "TASKLOG",
                newName: "Rowguid");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "TASKLOG",
                newName: "Ishost");

            migrationBuilder.RenameColumn(
                name: "rowguid",
                table: "TASKASSIGN",
                newName: "Rowguid");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "TASKASSIGN",
                newName: "Ishost");

            migrationBuilder.RenameColumn(
                name: "rowguid",
                table: "LOARULES",
                newName: "Rowguid");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "LOARULES",
                newName: "Ishost");

            migrationBuilder.RenameColumn(
                name: "rowguid",
                table: "LOA",
                newName: "Rowguid");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "LOA",
                newName: "Ishost");

            migrationBuilder.RenameColumn(
                name: "rowguid",
                table: "APPTRAIL",
                newName: "Rowguid");

            migrationBuilder.RenameColumn(
                name: "IsHost",
                table: "APPTRAIL",
                newName: "Ishost");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "TASKLOG",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TaskType",
                table: "TASKLOG",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "TaskCode",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "TASKLOG",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "TASKLOG",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalID",
                table: "TASKLOG",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "TASKLOG",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextActionBy",
                table: "TASKLOG",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "TASKLOG",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "TASKASSIGN",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "TaskType",
                table: "TASKASSIGN",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "TaskCode",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "TASKASSIGN",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "TASKASSIGN",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalID",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<int>(
                name: "Seq",
                table: "TASKASSIGN",
                type: "int",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActionDate",
                table: "TASKASSIGN",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionTakenBy",
                table: "TASKASSIGN",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NextActionBy",
                table: "TASKASSIGN",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "TASKASSIGN",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true,
                defaultValueSql: "NULL");

            migrationBuilder.AlterColumn<double>(
                name: "UpperUnBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpperSign",
                table: "LOARULES",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<double>(
                name: "UpperBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Seq",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesType",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesReff",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesCode",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RulesBy",
                table: "LOARULES",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "LOARULES",
                type: "int",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "MinApprover",
                table: "LOARULES",
                type: "int",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<double>(
                name: "LowerUnBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<double>(
                name: "LowerBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(decimal),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LogicCondition",
                table: "LOARULES",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprCode",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ActionLink",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ApprovalTemplate",
                table: "LOARULES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryTemplate",
                table: "LOARULES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "LowerLimitCurrency",
                table: "LOARULES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "NotificationTemplate",
                table: "LOARULES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "RejectAction",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "RejectionTemplate",
                table: "LOARULES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ReminderTemplate",
                table: "LOARULES",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "UpperLimitCurrency",
                table: "LOARULES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "LOA",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesType",
                table: "LOA",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "LOA",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "LOA",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "LOA",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "LOAType",
                table: "LOA",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LOADesc",
                table: "LOA",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOACode",
                table: "LOA",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "LOA",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "LOA",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "APPTRAIL",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "APPTRAIL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Seq",
                table: "APPTRAIL",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "APPTRAIL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "APPTRAIL",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<byte>(
                name: "ApprovalType",
                table: "APPTRAIL",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalCode",
                table: "APPTRAIL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "ActionLink",
                table: "APPTRAIL",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TASKASSIGN",
                table: "TASKASSIGN",
                columns: new[] { "TaskID", "Seq" });

            migrationBuilder.CreateTable(
                name: "ApprovalDTL",
                columns: table => new
                {
                    ApprovalID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ApprovalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovalDetail = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalDTL", x => x.ApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalHDR",
                columns: table => new
                {
                    ApprovalID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    AppAction = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true, defaultValueSql: "''"),
                    AppActionCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    AppDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    AppObj = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    ApprovalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ApprovalType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalHDR", x => x.ApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "EMPAPPROVER",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmpApprID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmpApprCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    EmpApprDesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    EmpApprType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Ishost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Level = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPAPPROVER", x => new { x.EmployeeID, x.EmpApprID });
                });
        }
    }
}
