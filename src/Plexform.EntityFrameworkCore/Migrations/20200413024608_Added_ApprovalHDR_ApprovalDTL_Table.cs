using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_ApprovalHDR_ApprovalDTL_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApprovalDTL",
                columns: table => new
                {
                    ApprovalID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovalDetail = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalDTL", x => x.ApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalHDR",
                columns: table => new
                {
                    ApprovalID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovalType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    RefID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    AppObj = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    AppDesc = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    AppActionCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    AppAction = table.Column<string>(maxLength: 2000, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalHDR", x => x.ApprovalID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalDTL");

            migrationBuilder.DropTable(
                name: "ApprovalHDR");
        }
    }
}
