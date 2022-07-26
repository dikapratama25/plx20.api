using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_ATTENDANCELIST_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ATTENDANCELIST",
                columns: table => new
                {
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    OTP = table.Column<string>(maxLength: 20, nullable: false),
                    IsReq = table.Column<byte>(nullable: false),
                    IsResponse = table.Column<byte>(nullable: false),
                    IsLocked = table.Column<byte>(nullable: false),
                    IsApproved = table.Column<byte>(nullable: false),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Posted = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTENDANCELIST", x => new { x.CampID, x.BizRegID, x.BizLocID, x.SeqNo, x.UserID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATTENDANCELIST");
        }
    }
}
