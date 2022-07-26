using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CAMPAIGNITEM_Table20200724 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CAMPAIGNITEM",
                table: "CAMPAIGNITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAMPAIGNITEM",
                table: "CAMPAIGNITEM",
                columns: new[] { "BizRegID", "BizLocID", "CampNo", "SeqNo", "ItemCode", "PackageCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CAMPAIGNITEM",
                table: "CAMPAIGNITEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAMPAIGNITEM",
                table: "CAMPAIGNITEM",
                columns: new[] { "BizRegID", "BizLocID", "CampNo", "SeqNo", "ItemCode" });
        }
    }
}
