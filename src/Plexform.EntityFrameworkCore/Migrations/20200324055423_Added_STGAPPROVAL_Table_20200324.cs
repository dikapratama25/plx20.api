using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_STGAPPROVAL_Table_20200324 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STGAPPROVAL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    AddressType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Address1 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    Address2 = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    Address3 = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    Address4 = table.Column<string>(maxLength: 40, nullable: true, defaultValueSql: "''"),
                    PackageType = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Email = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Country = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "''"),
                    City = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TransporterID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STGAPPROVAL", x => x.BizRegID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STGAPPROVAL");
        }
    }
}
