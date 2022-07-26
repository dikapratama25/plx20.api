using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_PROMOPOLICY_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAMPPOLICY",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PromoID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PolicyNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    EffectiveDay = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EntAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ExpiryDay = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    GST = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    GroupCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    IsGST = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsMix = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    MaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MinAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MixDesc = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OptPolicy = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PeriodDay = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PeriodMonth = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PeriodType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PeriodWeek = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PolicyCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PolicyType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark4 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark5 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark6 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Remark7 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TradeupAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MaxQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    MinQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ExpiryType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    QtyType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPPOLICY", x => new { x.BizRegID, x.BizLocID, x.PromoID, x.PolicyNo, x.ItemCode, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAMPPOLICY");
        }
    }
}
