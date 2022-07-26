using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_AbpUserProfile_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpUserProfile",
                columns: table => new
                {
                    UPFID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UPFType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ReferralCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferralID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    REFUSR = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    NickName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LastName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Salutation = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Sex = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "''"),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlaceOfBirth = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    NRICNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Nationality = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Race = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Religion = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Marital = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DirectNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    MobileNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    EmailAddress = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    Designation = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CoAddress1 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress2 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress3 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoPostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CoState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    CoCountry = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    PnAddress1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress2 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    PnAddress3 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    PnAddress4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    PnPostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PnState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    PnCountry = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    EmerContactPerson = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    EmerContactNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    ForeignLocal = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CommID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Salary = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OffDay = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Overtime = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Leave = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Levy = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Allergies = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    ClerkNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    DateHired = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateLeft = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransportAllowance = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ServiceAllowance = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OtherAllowance = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Remarks = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PrivilegeCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    AccessLvl = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LoginType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Department = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    FromTransporter = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    StatusAdd = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Position1 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Position2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Role1 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Role2 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    Role3 = table.Column<string>(nullable: false, defaultValueSql: "''"),
                    WorkerType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmailAdd2 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    EmailAdd3 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    ExtSocial1 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    ExtSocial2 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    ExtSocial3 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    ExtSocial4 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    ExtSocial5 = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    ExtNote1 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ExtNote2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ExtNote3 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserProfile", x => new { x.UPFID, x.BizRegID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpUserProfile");
        }
    }
}
