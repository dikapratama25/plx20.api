using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_PRODUCTISMUPLOAD_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUCTISMUPLOAD",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    Brand = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTISMUPLOAD", x => new { x.Code, x.LastUpdate });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUCTISMUPLOAD");
        }
    }
}
