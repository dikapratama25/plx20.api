using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_WORKORDERHDR_Table_20200311 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefNo1",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "RefNo2",
                table: "WORKORDERHDR",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''");

            migrationBuilder.AddColumn<string>(
                name: "LowerLimitCurrency",
                table: "LOARULES",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpperLimitCurrency",
                table: "LOARULES",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "isHost",
                table: "CUSTOMER",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "CUSTOMER",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status1",
                table: "CUSTOMER",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CUSTOMER",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "CUSTOMER",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "CUSTOMER",
                maxLength: 1,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Salutation",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Rowgid",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "newid()",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Religion",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Referral",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefInfo",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Race",
                table: "CUSTOMER",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PrivilegeCode",
                table: "CUSTOMER",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "CUSTOMER",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeTel",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Occupation",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "NRICNo",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MemberID",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Marital",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LoyaltyMember",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "IsEmployee",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "CUSTOMER",
                nullable: true,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "IMAGE",
                table: "CUSTOMER",
                maxLength: 4000,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "HomeTel",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "CUSTOMER",
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldMaxLength: 1,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBack",
                table: "CUSTOMER",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FaxNo",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Expiry",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CUSTOMER",
                maxLength: 80,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "CUSTOMER",
                type: "datetime",
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustType",
                table: "CUSTOMER",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CUSTOMER",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "CUSTOMER",
                maxLength: 20,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CrAccNo",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "CUSTOMER",
                maxLength: 5,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryID",
                table: "CUSTOMER",
                maxLength: 8,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BranchID",
                table: "CUSTOMER",
                maxLength: 10,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address3",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "CUSTOMER",
                maxLength: 200,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Active",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "(1)",
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "AccumPoints",
                table: "CUSTOMER",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldDefaultValueSql: "''");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefNo1",
                table: "WORKORDERHDR");

            migrationBuilder.DropColumn(
                name: "RefNo2",
                table: "WORKORDERHDR");

            migrationBuilder.DropColumn(
                name: "LowerLimitCurrency",
                table: "LOARULES");

            migrationBuilder.DropColumn(
                name: "UpperLimitCurrency",
                table: "LOARULES");

            migrationBuilder.AlterColumn<byte>(
                name: "isHost",
                table: "CUSTOMER",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdateBy",
                table: "CUSTOMER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "CUSTOMER",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Status1",
                table: "CUSTOMER",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CUSTOMER",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "CUSTOMER",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "CUSTOMER",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Salutation",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Rowgid",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "newid()",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "newid()");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Religion",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Referral",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefInfo",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "RefID",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Race",
                table: "CUSTOMER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PrivilegeCode",
                table: "CUSTOMER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "CUSTOMER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "OfficeTel",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Occupation",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "NRICNo",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNo",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "MemberID",
                table: "CUSTOMER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Marital",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LoyaltyMember",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateBy",
                table: "CUSTOMER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "LastSyncBy",
                table: "CUSTOMER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "IsEmployee",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Inuse",
                table: "CUSTOMER",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(0)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(0)");

            migrationBuilder.AlterColumn<string>(
                name: "IMAGE",
                table: "CUSTOMER",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 4000,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "HomeTel",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<byte>(
                name: "Flag",
                table: "CUSTOMER",
                type: "tinyint",
                maxLength: 1,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBack",
                table: "CUSTOMER",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "FaxNo",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Expiry",
                table: "CUSTOMER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "CUSTOMER",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 80,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "CUSTOMER",
                type: "datetime",
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CustType",
                table: "CUSTOMER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CUSTOMER",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CreateBy",
                table: "CUSTOMER",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CrAccNo",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "CUSTOMER",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 5,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CommID",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryID",
                table: "CUSTOMER",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "BranchID",
                table: "CUSTOMER",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address4",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address3",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address2",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "CUSTOMER",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValueSql: "''");

            migrationBuilder.AlterColumn<int>(
                name: "Active",
                table: "CUSTOMER",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "(1)",
                oldClrType: typeof(byte),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "(1)");

            migrationBuilder.AlterColumn<string>(
                name: "AccumPoints",
                table: "CUSTOMER",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "''",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "''");
        }
    }
}
