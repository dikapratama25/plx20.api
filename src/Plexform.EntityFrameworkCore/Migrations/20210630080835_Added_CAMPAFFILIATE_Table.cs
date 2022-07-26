using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CAMPAFFILIATE_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAMPAFFILIATE",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false),
                    SeqNo = table.Column<int>(nullable: false),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    DocCode = table.Column<string>(maxLength: 20, nullable: false),
                    DocType = table.Column<string>(maxLength: 10, nullable: false),
                    DocMode = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 70, nullable: false),
                    CreateMethod = table.Column<string>(maxLength: 20, nullable: false),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false),
                    PathRef = table.Column<string>(maxLength: 4000, nullable: false),
                    URLRef = table.Column<string>(maxLength: 4000, nullable: false),
                    Signature = table.Column<byte>(nullable: true),
                    Posted = table.Column<byte>(nullable: false),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAFFILIATE", x => new { x.BizLocID, x.BizRegID, x.CampNo, x.DocNo, x.SeqNo, x.LineCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMPAFFILIATE");
        }
    }
}
