using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class add_AppMaster_and_AppTenantEdition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APPMASTER",
                columns: table => new
                {
                    AppID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "(0)"),
                    AppDesc = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPMASTER", x => x.AppID);
                });

            migrationBuilder.CreateTable(
                name: "AppTenantEditions",
                columns: table => new
                {
                    TenantId = table.Column<int>(nullable: false),
                    EditionId = table.Column<int>(nullable: false),
                    AppId = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SubscriptionEndDateUtc = table.Column<DateTime>(nullable: true),
                    IsInTrialPeriod = table.Column<bool>(nullable: false, defaultValueSql: "CONVERT([bit],(0))"),
                    SubscriptionPaymentType = table.Column<int>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTenantEditions", x => new { x.TenantId, x.EditionId, x.AppId, x.UserId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPMASTER");

            migrationBuilder.DropTable(
                name: "AppTenantEditions");
        }
    }
}
