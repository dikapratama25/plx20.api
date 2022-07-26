using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Rename_ATTENDANCELIST_TO_CAMPCOMMITTEE_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATTENDANCELIST");

            migrationBuilder.CreateTable(
                name: "CAMPCOMMITTEE",
                columns: table => new
                {
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UserID = table.Column<int>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
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
                    OTP = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsReq = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsResponse = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsLocked = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsApproved = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPCOMMITTEE", x => new { x.CampID, x.BizRegID, x.BizLocID, x.SeqNo, x.UserID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMPCOMMITTEE");

            migrationBuilder.CreateTable(
                name: "ATTENDANCELIST",
                columns: table => new
                {
                    CampID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(type: "int", nullable: false, defaultValueSql: "(0)"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    CreateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsApproved = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "(0)"),
                    IsLocked = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsReq = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    IsResponse = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    OTP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TID = table.Column<int>(type: "int", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATTENDANCELIST", x => new { x.CampID, x.BizRegID, x.BizLocID, x.SeqNo, x.UserID });
                });
        }
    }
}
