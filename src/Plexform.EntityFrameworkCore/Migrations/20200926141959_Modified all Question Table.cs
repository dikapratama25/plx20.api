using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class ModifiedallQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONHDR",
                table: "QUESTIONHDR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONDTL",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "SecNo",
                table: "QUESTIONHDR");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "QUESTIONHDR");

            migrationBuilder.DropColumn(
                name: "TotalQty",
                table: "QUESTIONHDR");

            migrationBuilder.DropColumn(
                name: "GrpNo",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "OptType",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "OptValue",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "QuizValue",
                table: "QUESTIONDTL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "QUESTIONITEM",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "QUESTIONITEM",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONITEM",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "QUESTIONHDR",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "QUESTIONHDR",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizType",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "QUESTIONHDR",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "QUESTIONHDR",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "QUESTIONHDR",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "QUESTIONHDR",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<byte>(
                name: "DocReq",
                table: "QUESTIONHDR",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "QUESTIONHDR",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "QUESTIONHDR",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONHDR",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "QUESTIONDTL",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "QUESTIONDTL",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<byte>(
                name: "DocReq",
                table: "QUESTIONDTL",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "ParentID",
                table: "QUESTIONDTL",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "QUESTIONDTL",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<decimal>(
                name: "ScoreWeight",
                table: "QUESTIONDTL",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalQty",
                table: "QUESTIONDTL",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONHDR",
                table: "QUESTIONHDR",
                columns: new[] { "QuizID", "BizRegID", "BizLocID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONDTL",
                table: "QUESTIONDTL",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "SecNo" });

            migrationBuilder.CreateTable(
                name: "QUESTIONGROUP",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SecNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    GrpNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QuizValue = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    OptType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptValue = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true, defaultValueSql: "NULL"),
                    Description = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONGROUP", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.SecNo, x.GrpNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QUESTIONGROUP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONHDR",
                table: "QUESTIONHDR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QUESTIONDTL",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "DocReq",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "ScoreWeight",
                table: "QUESTIONDTL");

            migrationBuilder.DropColumn(
                name: "TotalQty",
                table: "QUESTIONDTL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "QUESTIONITEM",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "QUESTIONITEM",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONITEM",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "QUESTIONHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "QuizType",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<byte>(
                name: "Posted",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "ParentID",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "IsHost",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "DocReq",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "QUESTIONHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "QUESTIONHDR",
                type: "tinyint",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONHDR",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "SecNo",
                table: "QUESTIONHDR",
                type: "int",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "QUESTIONHDR",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<int>(
                name: "TotalQty",
                table: "QUESTIONHDR",
                type: "int",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "QUESTIONDTL",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "QUESTIONDTL",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizLocID",
                table: "QUESTIONDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "QUESTIONDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "QuizID",
                table: "QUESTIONDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddColumn<int>(
                name: "GrpNo",
                table: "QUESTIONDTL",
                type: "int",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<string>(
                name: "OptType",
                table: "QUESTIONDTL",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "OptValue",
                table: "QUESTIONDTL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "QuizValue",
                table: "QUESTIONDTL",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONHDR",
                table: "QUESTIONHDR",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "SecNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONDTL",
                table: "QUESTIONDTL",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "SecNo", "GrpNo" });
        }
    }
}
