﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_QUESTIONPAX_Table20200709 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QUESTIONPAX",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TotalAmt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAX", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QUESTIONPAX");
        }
    }
}
