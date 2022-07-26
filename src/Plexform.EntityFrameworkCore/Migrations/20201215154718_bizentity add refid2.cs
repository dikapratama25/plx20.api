using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class bizentityaddrefid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Rowgid",
                table: "PFI");

            migrationBuilder.DropColumn(
                name: "Rowgid",
                table: "CUSTOMER");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "QUESTIONPAXSCORE",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "QUESTIONPAXITEM",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "QUESTIONPAX",
                nullable: false,
                defaultValueSql: "(0)");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "PFI",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "PFI",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DriverID",
                table: "PFI",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customerpo",
                table: "PFI",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastSyncBy",
                table: "ITEM",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "IsHost",
                table: "CUSTOMER",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "rowguid",
                table: "CUSTOMER",
                nullable: false,
                defaultValueSql: "newid()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncCreate",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegDate",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "RefID2",
                table: "BIZENTITY",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

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

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QUESTIONPAXSCORE");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QUESTIONPAXITEM");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "QUESTIONPAX");

            migrationBuilder.DropColumn(
                name: "LastSyncBy",
                table: "ITEM");

            migrationBuilder.DropColumn(
                name: "IsHost",
                table: "CUSTOMER");

            migrationBuilder.DropColumn(
                name: "rowguid",
                table: "CUSTOMER");

            migrationBuilder.DropColumn(
                name: "RefID2",
                table: "BIZENTITY");

            migrationBuilder.AlterColumn<Guid>(
                name: "rowguid",
                table: "PFI",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "PFI",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverID",
                table: "PFI",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customerpo",
                table: "PFI",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rowgid",
                table: "PFI",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "Rowgid",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "newid()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncLastUpd",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SyncCreate",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegDate",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "BIZENTITY",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "BizRegID",
                table: "BIZENTITY",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXSCORE",
                table: "QUESTIONPAXSCORE",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAXITEM",
                table: "QUESTIONPAXITEM",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo", "GrpNo", "SeqNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_QUESTIONPAX",
                table: "QUESTIONPAX",
                columns: new[] { "QuizID", "BizRegID", "BizLocID", "PaxRegID", "PaxLocID", "ParentID", "SecNo" });
        }
    }
}
