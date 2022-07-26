using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CAMPAIGNAFFILIATE_Table_20200619 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAMPAIGNAFFILIATE",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DocMode = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    CreateMethod = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    URLRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(nullable: true, defaultValueSql: "NULL"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNAFFILIATE", x => new { x.BizLocID, x.BizRegID, x.CampNo, x.DocNo, x.SeqNo, x.LineCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMPAIGNAFFILIATE");
        }
    }
}
