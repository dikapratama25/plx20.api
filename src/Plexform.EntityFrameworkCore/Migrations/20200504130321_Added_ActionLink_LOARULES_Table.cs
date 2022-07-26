using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_ActionLink_LOARULES_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UpperUnBudgetAmt",
                table: "LOARULES",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpperLimitCurrency",
                table: "LOARULES",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "UpperBudgetAmt",
                table: "LOARULES",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "NULL",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Seq",
                table: "LOARULES",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "RulesType",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesReff",
                table: "LOARULES",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesCode",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesBy",
                table: "LOARULES",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "RejectAction",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MinApprover",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LowerUnBudgetAmt",
                table: "LOARULES",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LowerSign",
                table: "LOARULES",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LowerLimitCurrency",
                table: "LOARULES",
                maxLength: 3,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "LowerBudgetAmt",
                table: "LOARULES",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogicCondition",
                table: "LOARULES",
                maxLength: 2,
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Ishost",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprCode",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "LOARULES",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "LOARULES",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "LOARULES",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "LOARULES",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "LOARULES",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "ActionLink",
                table: "LOARULES",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionLink",
                table: "LOARULES");

            migrationBuilder.AlterColumn<double>(
                name: "UpperUnBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(double),
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpperLimitCurrency",
                table: "LOARULES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<double>(
                name: "UpperBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(double),
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "NULL");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Seq",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesType",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesReff",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "RulesLvl",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesCode",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RulesBy",
                table: "LOARULES",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "LOARULES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "RejectAction",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "MinApprover",
                table: "LOARULES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<double>(
                name: "LowerUnBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(double),
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LowerSign",
                table: "LOARULES",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LowerLimitCurrency",
                table: "LOARULES",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<double>(
                name: "LowerBudgetAmt",
                table: "LOARULES",
                type: "float",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(double),
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LogicCondition",
                table: "LOARULES",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LOAID",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Ishost",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "EmpApprCode",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "LOARULES",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "LOARULES",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "RulesID",
                table: "LOARULES",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");
        }
    }
}
