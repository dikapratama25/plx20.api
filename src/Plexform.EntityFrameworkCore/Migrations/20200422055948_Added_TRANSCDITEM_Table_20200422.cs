using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_TRANSCDITEM_Table_20200422 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TRANSCDITEM",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CNDNDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ItemType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "(1)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Amount1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Amount2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ProcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ErrCode = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    FilePath = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSCDITEM", x => new { x.MonthCode, x.PBTCode, x.BizRegID, x.BatchCode, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TRANSCDITEM");
        }
    }
}
