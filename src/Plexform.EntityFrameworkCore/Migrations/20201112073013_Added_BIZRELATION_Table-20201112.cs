using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_BIZRELATION_Table20201112 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BIZRELATION",
                columns: table => new
                {
                    TID = table.Column<int>(nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxUserID = table.Column<int>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TypeCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    IsApproved = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ApprovedBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZRELATION", x => new { x.TID, x.BizRegID, x.PaxRegID, x.PaxUserID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIZRELATION");
        }
    }
}
