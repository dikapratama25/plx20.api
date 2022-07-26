using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_Credit_MasterBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterBalance",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    rowguid = table.Column<Guid>(nullable: false),
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
                    CreditBalance = table.Column<decimal>(nullable: false),
                    PointBalance = table.Column<decimal>(nullable: false),
                    CreditCurrency = table.Column<string>(maxLength: 3, nullable: false),
                    CreditType = table.Column<string>(maxLength: 20, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBalance", x => new { x.UserID, x.BizRegID, x.BizLocID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterBalance");
        }
    }
}
