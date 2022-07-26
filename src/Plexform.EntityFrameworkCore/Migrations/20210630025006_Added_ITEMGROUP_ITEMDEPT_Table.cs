using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_ITEMGROUP_ITEMDEPT_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ITEMDEPT",
                columns: table => new
                {
                    DivCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DeptCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    DeptDesc = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    MarginPercent = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AllowAltSupplier = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AllowOverRecv = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMDEPT", x => new { x.DivCode, x.DeptCode });
                });

            migrationBuilder.CreateTable(
                name: "ITEMGROUP",
                columns: table => new
                {
                    DeptCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    GroupCode = table.Column<string>(maxLength: 8, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    GroupDesc = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    SalesTarget = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DesireStock = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DualReceipt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PrintLineId = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMGROUP", x => new { x.DeptCode, x.GroupCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITEMDEPT");

            migrationBuilder.DropTable(
                name: "ITEMGROUP");
        }
    }
}
