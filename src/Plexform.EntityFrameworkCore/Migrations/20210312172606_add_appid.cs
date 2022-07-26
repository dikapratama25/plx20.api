using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class add_appid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPTRAIL");

            migrationBuilder.DropTable(
                name: "CAMPAIGNAFFILIATE");

            migrationBuilder.DropTable(
                name: "CAMPAIGNDOCUMENT");

            migrationBuilder.DropTable(
                name: "CAMPAIGNDTL");

            migrationBuilder.DropTable(
                name: "CAMPAIGNHDR");

            migrationBuilder.DropTable(
                name: "CAMPAIGNITEM");

            migrationBuilder.DropTable(
                name: "CAMPAIGNITEMSUPP");

            migrationBuilder.DropTable(
                name: "CONTRACTDOCUMENT");

            migrationBuilder.DropTable(
                name: "CONTRACTHDR");

            migrationBuilder.DropTable(
                name: "CONTRACTITEM");

            migrationBuilder.DropTable(
                name: "CONTRACTRESOURCE");

            migrationBuilder.DropTable(
                name: "CONTRACTSCOPESUM");

            migrationBuilder.DropTable(
                name: "IMAGEUPLOAD");

            migrationBuilder.DropTable(
                name: "IMPRESSION");

            migrationBuilder.DropTable(
                name: "IMPRESSIONPROGRESS");

            migrationBuilder.DropTable(
                name: "INSERVICEDTL");

            migrationBuilder.DropTable(
                name: "INSERVICEHDR");

            migrationBuilder.DropTable(
                name: "INSPECTCHECK");

            migrationBuilder.DropTable(
                name: "INVOICEHDR_CWMS");

            migrationBuilder.DropTable(
                name: "LOA");

            migrationBuilder.DropTable(
                name: "LOARULES");

            migrationBuilder.DropTable(
                name: "LOGEVENT");

            migrationBuilder.DropTable(
                name: "MOB_QUEST");

            migrationBuilder.DropTable(
                name: "SCHEDULEDTL");

            migrationBuilder.DropTable(
                name: "SCHEDULEHDR");

            migrationBuilder.DropTable(
                name: "SCHEDULEITEM");

            migrationBuilder.DropTable(
                name: "STGAPPROVAL");

            migrationBuilder.DropTable(
                name: "SYSREPORT");

            migrationBuilder.DropTable(
                name: "TASKASSIGN");

            migrationBuilder.DropTable(
                name: "TASKLOG");

            migrationBuilder.DropTable(
                name: "VEHICLE");

            migrationBuilder.DropTable(
                name: "VEHICLEDOCUMENT");

            migrationBuilder.DropTable(
                name: "WORKER");

            migrationBuilder.DropTable(
                name: "WORKORDERBIN");

            migrationBuilder.DropTable(
                name: "WORKORDERDTL");

            migrationBuilder.DropTable(
                name: "WORKORDERDTLLOG");

            migrationBuilder.DropTable(
                name: "WORKORDERHDR");

            migrationBuilder.DropTable(
                name: "WORKORDERLOG");

            migrationBuilder.DropTable(
                name: "WORKORDERPERSON");

            migrationBuilder.DropTable(
                name: "WORKRESULT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAMPPAX",
                table: "CAMPPAX");

            migrationBuilder.AlterColumn<string>(
                name: "SYSValue",
                table: "SYSPREFB",
                maxLength: 255,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "SYSSet",
                table: "SYSPREFB",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "SYSPREFB",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "Active",
                table: "SYSPREFB",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Inuse",
                table: "SYSPREFB",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "ScoreDefault",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewedBy",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "QUESTIONPAXSCORE",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "QUESTIONPAXSCORE",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "QUESTIONPAXSCORE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "QUESTIONPAXSCORE",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "QUESTIONPAXSCORE",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DocNo",
                table: "QUESTIONPAXSCORE",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "QUESTIONPAXSCORE",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeqNo",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GrpNo",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SecNo",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PaxLocID",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PaxRegID",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "TransNo",
                table: "QUESTIONPAXSCORE",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OptType",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransNo",
                table: "QUESTIONPAXITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "TransNo",
                table: "QUESTIONPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "TransNo",
                table: "CAMPPAX",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<byte>(
                name: "IsQualified",
                table: "CAMPPAX",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<byte>(
                name: "QualificationStep",
                table: "CAMPPAX",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "AbpEditions",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo", "UserID", "TransNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo", "UserID", "TransNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "UserID", "TransNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAMPPAX",
                table: "CAMPPAX",
                columns: new[] { "CampID", "BizRegID", "BizLocID", "SeqNo", "TransNo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAMPPAX",
                table: "CAMPPAX");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "SYSPREFB");

            migrationBuilder.DropColumn(
                name: "Inuse",
                table: "SYSPREFB");

            migrationBuilder.DropColumn(
                name: "TransNo",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.DropColumn(
                name: "TransNo",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "TransNo",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "TransNo",
                table: "CAMPPAX");

            migrationBuilder.DropColumn(
                name: "IsQualified",
                table: "CAMPPAX");

            migrationBuilder.DropColumn(
                name: "QualificationStep",
                table: "CAMPPAX");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "AbpEditions");

            migrationBuilder.AlterColumn<string>(
                name: "SYSValue",
                table: "SYSPREFB",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "SYSSet",
                table: "SYSPREFB",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "SYSPREFB",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "QUESTIONPAXSCORE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "ScoreDefault",
                table: "QUESTIONPAXSCORE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "QUESTIONPAXSCORE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewedBy",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "QUESTIONPAXSCORE",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "QUESTIONPAXSCORE",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "QUESTIONPAXSCORE",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "QUESTIONPAXSCORE",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "DocNo",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "QUESTIONPAXSCORE",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<int>(
                name: "SeqNo",
                table: "QUESTIONPAXSCORE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "GrpNo",
                table: "QUESTIONPAXSCORE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<int>(
                name: "SecNo",
                table: "QUESTIONPAXSCORE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PaxLocID",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PaxRegID",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONPAXSCORE",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OptType",
                table: "QUESTIONPAXITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAMPPAX",
                table: "CAMPPAX",
                columns: new[] { "CampID", "BizRegID", "BizLocID", "SeqNo" });

            migrationBuilder.CreateTable(
                name: "APPTRAIL",
                columns: table => new
                {
                    ApprovalID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ApprovalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ApprovalType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmpApprID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Seq = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPTRAIL", x => x.ApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNAFFILIATE",
                columns: table => new
                {
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DocNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, defaultValueSql: "''"),
                    DocCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocMode = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    DocType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "NULL"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    URLRef = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNAFFILIATE", x => new { x.BizLocID, x.BizRegID, x.CampNo, x.DocNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNDOCUMENT",
                columns: table => new
                {
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DocNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, defaultValueSql: "''"),
                    DocCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocMode = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    DocType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "NULL"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    URLRef = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNDOCUMENT", x => new { x.BizLocID, x.BizRegID, x.CampNo, x.DocNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNDTL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    LineCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ChangedBy_B = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LineDesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LineImage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LineType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_B = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNDTL", x => new { x.BizRegID, x.BizLocID, x.CampNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ApprovedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedBy_B = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedDate_B = table.Column<DateTime>(type: "datetime", nullable: true),
                    CampDisc = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CampOrgAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CampType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CustomerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TotalCampAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNHDR", x => new { x.BizRegID, x.BizLocID, x.TransNo, x.CampNo });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNITEM",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackageCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    AppInfo1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    AppInfo2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ChangedBy_B = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CurrencyBase = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrencyReq = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    DateReq = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiscAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ItemDesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemDesc_B = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LineCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Mechanic = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PointRef = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    PointReq = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    QtyRef = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    QtyReq = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    QtyRmrkRef = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    QtyRmrkReq = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    RefNo_B = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SubTotalReq = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TaxAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalPriceBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalPriceRef = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalPriceReq = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UOMRef = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceAdd = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAvg = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAvgVar = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceCamp = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRRef = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    UnitPriceRReq = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    UnitPriceRef = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReqVar = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_B = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Variance = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    VatAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNITEM", x => new { x.BizRegID, x.BizLocID, x.CampNo, x.SeqNo, x.ItemCode, x.PackageCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNITEMSUPP",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    PackageCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_B = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    CurrencyReq = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    DiscAmt = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ItemDesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    QtyRef = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    QtyReq = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TaxAmt = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceBase = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRef = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_B = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNITEMSUPP", x => new { x.BizRegID, x.BizLocID, x.CampNo, x.SeqNo, x.PackageCode, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTDOCUMENT",
                columns: table => new
                {
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    DocCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    DocMode = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    DocType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PathRef = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Signature = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "NULL"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTDOCUMENT", x => new { x.BizLocID, x.BizRegID, x.ContractID, x.DocNo });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ActResCnt = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    AgreementDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AmtCommitMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtCommitMin = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtCommitOrg1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtCommitOrg2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtCommitment = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtInvoiced = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtInvoicedA = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtInvoicedP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AmtLeftAVG = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtLeftAVGP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AmtReconcile = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileA = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AmtUsed = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtUsedP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AppealDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovalFlow = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApproveBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuthID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    AuthPOS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLicID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CollectionAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    CompanyID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContComp = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContCountry = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false, defaultValueSql: "''"),
                    ContDaysLeft = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ContDuration = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ContNature = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContPBT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ContState = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "''"),
                    ContractNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CurrRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    DeclineBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DeclineDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DefCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    DestRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsApproved = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsInvoiceable = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsLapsed = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsReceivable = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsService = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    KppVerifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    KppVerifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LapseEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LoadCreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LocCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    NextPayAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    NextPayDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextPayID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ParentID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PartitionNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ProcureUnit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Reason1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Reason2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Reason3 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    RefBatchCode1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefBatchCode2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefEffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefNo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RegistedSupp = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RelatedID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ReqResCnt = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    RequestID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ServiceType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SourceSystem = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TerminateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TerminateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tolerance = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VerifiedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    VerifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VersionNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTHDR", x => new { x.BizRegID, x.BizLocID, x.ContractID, x.ContractType });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTITEM",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    RefBatchCode1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefBatchCode2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemFreqNum = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AccountCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    AddQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtOrdLeft = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtOrdLeftP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AmtOrdered = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtRecLeft = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtRecLeftP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AmtReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtReconcile = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileA = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileP = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    AssetCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Commodity = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CommodityERP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CostCenter = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CurrRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    DefCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    InitQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    InternalOrder = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsPack = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsRecycle = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ItemAmtMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemContSplitP = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ItemCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ItemDesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemFreqCode = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemFreqType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ItemFrequency = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ItemQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ItemQtyMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ItemType = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ItemUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ItmCatgCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false, defaultValueSql: "''"),
                    ItmCatgQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LineType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LocCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    MaterialNo1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    MaterialNo2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    PackUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PayFreq = table.Column<int>(type: "int", nullable: false, defaultValueSql: "''"),
                    PayFreqType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "''"),
                    PayMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QtyOrdLeft = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyOrdLeftP = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyOrdered = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyRecLeft = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyRecLeftP = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyReconLeft = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyReconLeftP = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    QtyReconcile = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    RefSeqNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "(0)"),
                    ReleaseType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RevenueID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SchemeNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScopeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScopeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SellType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SerialNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    StartTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    StatisticCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SuppPartNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SupplierCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    WBSElement = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ZoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTITEM", x => new { x.BizRegID, x.BizLocID, x.ContractID, x.SeqNo, x.RefBatchCode1, x.RefBatchCode2, x.ContractNo, x.ItemFreqNum });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTRESOURCE",
                columns: table => new
                {
                    ContractID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ResourceID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ResourceType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LicID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    MastCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    MastType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Port1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Port2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Reference1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference5 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    SchemeNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Station = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    TransportType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ZoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTRESOURCE", x => new { x.ContractID, x.ResourceID, x.ResourceType, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTSCOPESUM",
                columns: table => new
                {
                    ScopeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MonthCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustBizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ItemFreqNum = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ActResCnt1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ActResCnt2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ActResCnt3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ActResCnt4 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    AvgPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CollectionAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CurrRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    DefCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    EndTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ErrCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCycle = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(1)"),
                    ItemFreqCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemFreqType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ItemFrequency = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    LastPriceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LocCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    MastCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    MastQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    MastType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    PBTCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Packaging = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    PriceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProcType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ReqResCnt1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt4 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    RouteNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RouteSchNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RouteSchType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SchemeNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScopeType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    StartTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    StreetCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VariationID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTSCOPESUM", x => new { x.ScopeID, x.MonthCode, x.BizRegID, x.CustBizRegID, x.ContractID, x.BatchCode, x.SeqNo, x.ItemFreqNum });
                });

            migrationBuilder.CreateTable(
                name: "IMAGEUPLOAD",
                columns: table => new
                {
                    UploadImageID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RefNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    UploadType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    PathImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGEUPLOAD", x => new { x.UploadImageID, x.RefNo, x.SeqNo, x.UploadType });
                });

            migrationBuilder.CreateTable(
                name: "IMPRESSION",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UniqueID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ClickDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClickNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ImpressionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImpressionNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackageCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SubmitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubmitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UserID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Validated = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPRESSION", x => new { x.BizRegID, x.BizLocID, x.UniqueID, x.ImpressionID });
                });

            migrationBuilder.CreateTable(
                name: "IMPRESSIONPROGRESS",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UniqueID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CampNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ClickDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClickNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ImpressionCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ImpressionType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Ishost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SubmitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubmitNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UserID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Validated = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPRESSIONPROGRESS", x => new { x.BizRegID, x.BizLocID, x.UniqueID, x.ImpressionID });
                });

            migrationBuilder.CreateTable(
                name: "INSERVICEDTL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MSTRID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true),
                    BehvType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CustPkgID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DiscAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Discounted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    NettAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    NettPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    OrgPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Points = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    PrcDisplayType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    PriceAuthID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PriceOverrided = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    PromoCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QGroupID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Qty = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    Remark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ReturnCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SubPoints = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    Taxable = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    TotAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSERVICEDTL", x => new { x.BizRegID, x.BizLocID, x.InSvcID, x.MSTRID, x.SeqNo, x.DeliveryDate });
                });

            migrationBuilder.CreateTable(
                name: "INSERVICEHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<byte>(type: "tinyint", nullable: true),
                    AnalysisSts = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    AuthSpDisc = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChkOutTermID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    CollectedAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Currency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrencyPaid = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CustAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    CustEmail = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, defaultValueSql: "''"),
                    CustName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CustPIC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CustRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustTelNo = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false, defaultValueSql: "''"),
                    EmpType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ExchgRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    FilePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true),
                    InSvcTime = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true),
                    IsCompleted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsSent = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastPaidAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    LastPaidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastPaidID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MonthCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    OutSvcTime = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    PrintedRpt = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Reason = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    RefStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, defaultValueSql: "''"),
                    SentAttempt = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    ServerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(type: "tinyint", nullable: true),
                    SpDiscReasonCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SpDiscRemark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TermID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TransAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransAmtOrg = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransAmtRnd = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransAmtSave = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransAmtSpDisc = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransChgAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransDiscAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransDiscAuth = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransDiscCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TransDiscReasonCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransDiscRemark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransDiscType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    TransDiscValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransSubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransValueSpDisc = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSERVICEHDR", x => new { x.BizRegID, x.BizLocID, x.InSvcID, x.CustLocID, x.InSvcDate });
                });

            migrationBuilder.CreateTable(
                name: "INSPECTCHECK",
                columns: table => new
                {
                    InspectCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SiteCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LotCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    SubDest1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AdjPackQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AdjQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ClassType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Condition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    ConfirmID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Images = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Images2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    IsLocked = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LotType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    MHECode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PackUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Rating1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    Rating2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    RecPackQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    SYSKey = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SYSType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SYSValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    SentPackQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SentQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SiteType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TypeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSPECTCHECK", x => new { x.InspectCode, x.SiteCode, x.LotCode, x.SeqNo, x.SubDest1, x.SubDest2 });
                });

            migrationBuilder.CreateTable(
                name: "INVOICEHDR_CWMS",
                columns: table => new
                {
                    MonthCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TotalAmt1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalAmt2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalAmt3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalAmt4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalAmt5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotalRec1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TotalRec2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TotalRec3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TotalRec4 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    TotalRec5 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICEHDR_CWMS", x => new { x.MonthCode, x.PBTCode, x.BatchCode });
                });

            migrationBuilder.CreateTable(
                name: "LOA",
                columns: table => new
                {
                    LOAID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    AppliedUrl = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LOACode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LOADesc = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LOAType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOA", x => x.LOAID);
                });

            migrationBuilder.CreateTable(
                name: "LOARULES",
                columns: table => new
                {
                    RulesID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmpApprCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LogicCondition = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true, defaultValueSql: "''"),
                    LowerBudgetAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    LowerSign = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true, defaultValueSql: "''"),
                    LowerUnBudgetAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    MinApprover = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    RoleID = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RulesBy = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    RulesCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RulesReff = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    RulesType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Seq = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UpperBudgetAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    UpperSign = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true, defaultValueSql: "''"),
                    UpperUnBudgetAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOARULES", x => x.RulesID);
                });

            migrationBuilder.CreateTable(
                name: "LOGEVENT",
                columns: table => new
                {
                    EventID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(0)"),
                    Browser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    BusinessObject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreatedBy = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(1)"),
                    ErrorMessage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    EventDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    EventType = table.Column<int>(type: "int", nullable: true, defaultValueSql: "''"),
                    ExecDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExecMessage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    IP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(0)"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    ScheduleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "''"),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SuccessExec = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGEVENT", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "MOB_QUEST",
                columns: table => new
                {
                    AppID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    GrpID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ActType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SYSKey = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ChkType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ChkValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsCheck = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    RefValue = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    SYSDesc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    SYSType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SeqNo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOB_QUEST", x => new { x.AppID, x.GrpID, x.ActType, x.SYSKey });
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULEDTL",
                columns: table => new
                {
                    ScheduleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VehicleNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WorkerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEDTL", x => new { x.ScheduleID, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULEHDR",
                columns: table => new
                {
                    MSTRID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PlanID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ActualEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(0)"),
                    ActualEndTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ActualStartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(0)"),
                    ActualStartTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    DestRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsCompleted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsReq = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LocDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocRemark1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocRemark2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    PlannedEndTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    PlannedStartTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    ReferenceNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RequestID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    SubDest1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubOri1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubOri2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubRequestID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "'COL'"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VehicleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WorkType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEHDR", x => new { x.MSTRID, x.PlanID, x.ScheduleID, x.ContractID, x.BizLocID, x.LocID, x.CustomerID, x.TransDate, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULEITEM",
                columns: table => new
                {
                    ScheduleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "''"),
                    MastType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    AddQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostAmt1 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostAmt2 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostAmt3 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    InitQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsPack = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ItemType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Multiplier = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PackUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    SellPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice1 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice2 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice3 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellType = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SvcType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TotAmt1 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TotAmt2 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TotAmt3 = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEITEM", x => new { x.ScheduleID, x.SeqNo, x.MastType, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "STGAPPROVAL",
                columns: table => new
                {
                    StagingID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Address1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Address2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address4 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValueSql: "''"),
                    AddressChange = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    AddressType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BankCode1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    City = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Country = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    District = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsRead = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PackageType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    QtyBin = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RejectRemark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    State = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    StatusApproval = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransporterID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STGAPPROVAL", x => new { x.StagingID, x.BizRegID });
                });

            migrationBuilder.CreateTable(
                name: "SYSREPORT",
                columns: table => new
                {
                    APPID = table.Column<byte>(type: "tinyint", nullable: false),
                    RPTCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    QueryType = table.Column<byte>(type: "tinyint", nullable: true),
                    RPTDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RPTName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RPTQuery = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    RPTSection = table.Column<byte>(type: "tinyint", nullable: true),
                    RPTType = table.Column<byte>(type: "tinyint", nullable: true),
                    SeqNo = table.Column<byte>(type: "tinyint", nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSREPORT", x => new { x.APPID, x.RPTCode });
                });

            migrationBuilder.CreateTable(
                name: "TASKASSIGN",
                columns: table => new
                {
                    TaskID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ApprovalID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmpApprID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(type: "tinyint", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TaskCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TaskType = table.Column<byte>(type: "tinyint", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASKASSIGN", x => x.TaskID);
                });

            migrationBuilder.CreateTable(
                name: "TASKLOG",
                columns: table => new
                {
                    TaskID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ApprovalID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmpApprID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(type: "tinyint", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TaskCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TaskType = table.Column<byte>(type: "tinyint", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASKLOG", x => x.TaskID);
                });

            migrationBuilder.CreateTable(
                name: "VEHICLE",
                columns: table => new
                {
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    VehicleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true),
                    BDM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BTM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    GrpCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ManufactYear = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptDesc1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptDesc2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptDesc3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptWith1 = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    OptWith2 = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    OptWith3 = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Ownership = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "(1)"),
                    RegNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RegisterCard = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RegisterYear = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VehicleType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    WithCont = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    WithGPS = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    WithLifter = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    WithPaint = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    WithPhoto = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLE", x => new { x.BizRegID, x.VehicleID });
                });

            migrationBuilder.CreateTable(
                name: "VEHICLEDOCUMENT",
                columns: table => new
                {
                    DocCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VehicleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    DataKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    DocMode = table.Column<byte>(type: "tinyint", nullable: true),
                    DocNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "''"),
                    DocType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    PathRef = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Posted = table.Column<byte>(type: "tinyint", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    RemindDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Signature = table.Column<byte>(type: "tinyint", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ValidityEnd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ValidityStart = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLEDOCUMENT", x => new { x.DocCode, x.BizRegID, x.VehicleID });
                });

            migrationBuilder.CreateTable(
                name: "WORKER",
                columns: table => new
                {
                    WorkerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AccessLvl = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true),
                    Allergies = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, defaultValueSql: "''"),
                    ClerkNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CoAddress1 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress2 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress3 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress4 = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoCountry = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false, defaultValueSql: "''"),
                    CoPostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CoState = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "''"),
                    CommID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    DateHired = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    DateLeft = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    EmailAddress = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, defaultValueSql: "''"),
                    EmerContactNo = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false, defaultValueSql: "''"),
                    EmerContactPerson = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ForeignLocal = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Leave = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Levy = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    LocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Marital = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    NRICNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Nationality = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    NickName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OffDay = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    OtherAllowance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Overtime = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PnAddress1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnCountry = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false, defaultValueSql: "''"),
                    PnPostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PnState = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "''"),
                    Position1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Position2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PrivilegeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Race = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ReferralCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferralID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Religion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Role1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Role2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Role3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Salutation = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ServiceAllowance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Sex = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SurName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransportAllowance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    WorkerType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKER", x => new { x.WorkerID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERBIN",
                columns: table => new
                {
                    WOID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    MastType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackSerial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PackUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RefNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERBIN", x => new { x.WOID, x.SeqNo, x.MastType, x.ItemCode, x.PackSerial });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERDTL",
                columns: table => new
                {
                    WOID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    MastType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ActualPackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ActualQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ActualQty1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    ActualQty2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AddQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AdjPackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    AdjQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CostAmt1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CostAmt2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CostAmt3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ImageRes1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageRes2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageRes3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageSign1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageSign2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageSign3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    InitQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsPack = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ItemType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Multiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    NextProcessDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    PackUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ProdCompany = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    Rating1 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Rating2 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Rating3 = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    RecPackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    RefNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SellPrice1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SellPrice2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SellPrice3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SellType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SentPackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SentQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    SvcType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TotAmt1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotAmt2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TotAmt3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TreatmentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERDTL", x => new { x.WOID, x.SeqNo, x.MastType, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERDTLLOG",
                columns: table => new
                {
                    WOID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SellType = table.Column<byte>(type: "tinyint", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    RowVersion = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<byte>(type: "tinyint", nullable: true),
                    ActualQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CRUD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PrevActualQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevRecQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevSentQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SentQty = table.Column<decimal>(type: "decimal(18,2)", maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERDTLLOG", x => new { x.WOID, x.SeqNo, x.ItemCode, x.SellType, x.LogDate, x.RowVersion });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERHDR",
                columns: table => new
                {
                    MSTRID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WOID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    BankID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CODCreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CODFilePath = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ChequeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CustomerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DestRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsParent = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LocDesc1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PICID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    PICName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "''"),
                    PaymentType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    ProcStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    ProcType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    RcvDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceiptNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferenceNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SubDest1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubOri1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubOri2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TransportQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValueSql: "(0)"),
                    TransportType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VehicleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WorkType = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERHDR", x => new { x.MSTRID, x.ScheduleID, x.WOID, x.ContractID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERLOG",
                columns: table => new
                {
                    MSTRID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WorkerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    VehicleID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Remark1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "''"),
                    SubDest1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERLOG", x => new { x.MSTRID, x.ScheduleID, x.WorkerID, x.VehicleID, x.LogDate, x.Status });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERPERSON",
                columns: table => new
                {
                    WOID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    InitVehicleNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    InitWorkerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VehicleNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    WorkerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERPERSON", x => new { x.WOID, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "WORKRESULT",
                columns: table => new
                {
                    BatchCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ActualPackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    ActualPackQtyDepart = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActualQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    ActualQtyDepart = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AssignTo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmployeeID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    ImageRes1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageRes2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageRes3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageSign1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageSign2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageSign3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "''"),
                    InspectEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    InspectStartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsRedo = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    PackQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "(0)"),
                    Rating = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(1)"),
                    RefWID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ResultTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(1)"),
                    SubDest1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKRESULT", x => new { x.BatchCode, x.WID, x.SeqNo });
                });
        }
    }
}
