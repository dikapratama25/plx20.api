using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_BIZREFERENCE_Table_20200402 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BIZREFERENCE",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DOEFileNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZREFERENCE", x => new { x.BizRegID, x.BizLocID, x.DOEFileNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIZREFERENCE");
        }
    }
}
