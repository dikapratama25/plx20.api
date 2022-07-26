using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Remigrate_Plexform_For_Framework_Upgrade_8_9_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ANSWERGROUP",
                columns: table => new
                {
                    GroupID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
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
                    Text = table.Column<string>(maxLength: 4000, nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANSWERGROUP", x => new { x.GroupID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "ANSWEROPT",
                columns: table => new
                {
                    OptID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
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
                    OrderNo = table.Column<int>(nullable: true),
                    Value = table.Column<string>(maxLength: 4000, nullable: true),
                    Text = table.Column<string>(maxLength: 4000, nullable: true),
                    ScoreDefault = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANSWEROPT", x => new { x.OptID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "ANSWEROPTGROUP",
                columns: table => new
                {
                    GroupID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    OptID = table.Column<string>(maxLength: 20, nullable: false),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANSWEROPTGROUP", x => new { x.GroupID, x.BizRegID, x.BizLocID, x.OptID });
                });

            migrationBuilder.CreateTable(
                name: "APPTRAIL",
                columns: table => new
                {
                    ApprovalID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovalCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    EmpApprID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    Seq = table.Column<int>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPTRAIL", x => x.ApprovalID);
                });

            migrationBuilder.CreateTable(
                name: "AREA",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 3, nullable: false),
                    StateCode = table.Column<string>(maxLength: 5, nullable: false),
                    CityCode = table.Column<string>(maxLength: 5, nullable: false),
                    AreaCode = table.Column<string>(maxLength: 10, nullable: false),
                    AreaDesc = table.Column<string>(maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<byte>(nullable: false),
                    Inuse = table.Column<byte>(nullable: false),
                    Flag = table.Column<byte>(nullable: false),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: false),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AREA", x => new { x.CountryCode, x.StateCode, x.CityCode, x.AreaCode });
                });

            migrationBuilder.CreateTable(
                name: "BIZCATEGORY",
                columns: table => new
                {
                    CatgCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "(1)"),
                    CatgDesc = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CatgShortDesc = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Definition = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Prefix = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZCATEGORY", x => x.CatgCode);
                });

            migrationBuilder.CreateTable(
                name: "BIZDOCUMENT",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    DocNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    DocMode = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    ValidityStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValidityEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    Duration = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    RemindDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    DataKey = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(maxLength: 16, nullable: true, defaultValueSql: "NULL"),
                    Posted = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZDOCUMENT", x => new { x.DocCode, x.BizRegID, x.DocType });
                });

            migrationBuilder.CreateTable(
                name: "BIZENTITY",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
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
                    CompanyName = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    InitName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CompanyType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    RegDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FileNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Owner = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ICNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SubGrp = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "''"),
                    BizGrp = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    BizCatgID = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BizRegType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    BizRegStatus = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    CommID = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    IndustryType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BusinessType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    RegNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    StoreStatus = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    PrivilegeCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Address1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Address2 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address3 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    WCAddress1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    WCAddress2 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    WCAddress3 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    WCAddress4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Country = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    PBT = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    City = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Area = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TelNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    FaxNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Email = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    CoWebsite = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ContactPerson = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactRace = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ContactDesignation = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactPersonEmail = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ContactPersonTelNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactPersonFaxNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactPersonMobile = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactPerson2 = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactDesignation2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContactPersonEmail2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ContactPersonTelNo2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactPersonFaxNo2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactPersonMobile2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SMSAlertNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    AcctNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    AgrNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    AgrDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AgrAddDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AgrRenew = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    AgrRenewDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AcctNo2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    AgrNo2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    AgrDate2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    AgrAddDate2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    AgrRenew2 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    AgrRenewDate2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    BankCode1 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankAccount1 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankCode2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankAccount2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ReqSupp = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    ReqNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReqDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReqCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefAmount1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RefAmount2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    IsTermAgr = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    IsRateAgr = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    ImagePath = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    MediaUrl1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    MediaUrl2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    MediaUrl3 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsNew = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    BizType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo3 = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZENTITY", x => x.BizRegID);
                });

            migrationBuilder.CreateTable(
                name: "BIZGROUP",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    BizPBT = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BizArea = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    BizTery = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    BizGrp = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    ReqSupp = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZGROUP", x => new { x.BizRegID, x.BizLocID, x.BizState, x.BizPBT, x.BizArea });
                });

            migrationBuilder.CreateTable(
                name: "BIZITEM",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemName = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    StorageID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ShortDesc = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    ItemComponent = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    TariffCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    OrgCountry = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    MATNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    MarkNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    ItmSize2 = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItmSize1 = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItmSize = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ConSize = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ConUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    DefUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    ClassType = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    TypeCode = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    BehvShow = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ComboItem = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    ItmCatgCode = table.Column<string>(maxLength: 8, nullable: true, defaultValueSql: "''"),
                    ItmBrand = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LooseUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    IsSales = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsEmpDisc = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsRtnable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsDisc = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsFOC = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsTaxable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AvgCost = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    StdCost = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    StdMarkup = table.Column<decimal>(maxLength: 5, nullable: true, defaultValueSql: "(0)"),
                    StdSellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    IsSelected = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsBestBuy = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsPurchase = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsWLength = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsRecycle = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TrackSerial = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    MinQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    MaxQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ImageName = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    IncomingQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ReOrderLvl = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ReOrderQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    QtyOnHand = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    QtySellable = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    QtyBalance = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    POQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    OutgoingQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    QtyAdj = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    FirstIn = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastIn = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastPO = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastOut = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastRV = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CummQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    DayQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LDayQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    MthQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LMthQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    MtdQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    YrQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LYrQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    YtdQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ExpiredQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZITEM", x => new { x.BizRegID, x.BizLocID, x.ItemCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "BIZLOCATE",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BranchType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(1)"),
                    BranchName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    BranchCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BizRegType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    BizRegStatus = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    BizCatgID = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CommID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IndustryType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BusinessType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    AccNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Address1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Address2 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address3 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ContactPerson = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactDesignation = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactEmail = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ContactTelNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactMobile = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankAccount = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    StoreType = table.Column<string>(maxLength: 1, nullable: false, defaultValueSql: "''"),
                    Email = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Tel = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Fax = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Region = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Country = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    PBT = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    City = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Area = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    RefAmount1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RefAmount2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    StoreStatus = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpPrevBook = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    OpTimeStart = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    OpTimeEnd = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    OpDay1 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpDay2 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpDay3 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpDay4 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpDay5 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpDay6 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpDay7 = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    OpBookAlwDY = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    OpBookAlwHR = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    OpBookFirst = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    OpBookLast = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    OpBookIntv = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    SalesItemType = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    InSvcItemType = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    GenInSvcID = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    RcpHeader = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    RcpFooter = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PriceLevel = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    CapacityLevel = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsStockTake = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    UnitID = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZLOCATE", x => new { x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "BIZMEMBER",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MemberCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIZMEMBER", x => new { x.BizRegID, x.BizLocID, x.MemberCode });
                });

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

            migrationBuilder.CreateTable(
                name: "CAMPAIGNAFFILIATE",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DocMode = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    CreateMethod = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    URLRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(nullable: true, defaultValueSql: "NULL"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNAFFILIATE", x => new { x.BizLocID, x.BizRegID, x.CampNo, x.DocNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNDOCUMENT",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DocMode = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    CreateMethod = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    URLRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(nullable: true, defaultValueSql: "NULL"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNDOCUMENT", x => new { x.BizLocID, x.BizRegID, x.CampNo, x.DocNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNDTL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    LineType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LineName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LineDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LineImage = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UnitPriceReq_B = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_C = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UnitPriceReq_C = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNDTL", x => new { x.BizRegID, x.BizLocID, x.CampNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    CampType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampOrgAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CampDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalCampAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedDate_B = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNHDR", x => new { x.BizRegID, x.BizLocID, x.TransNo, x.CampNo });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNITEM",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackageCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemDesc_B = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrencyBase = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ExchangeRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceBase = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalPriceBase = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CurrencyReq = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceReq_B = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DateReq = table.Column<DateTime>(type: "datetime", nullable: true),
                    QtyReq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRReq = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    QtyRmrkReq = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    TaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SubTotalReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalPriceReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PointReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyRef = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    PointRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRRef = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    QtyRmrkRef = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    TotalPriceRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAdd = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAvg = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAvgVar = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReqVar = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Variance = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    VatAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AppInfo1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    AppInfo2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Mechanic = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    UOMRef = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceCamp = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RefNo = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    RefNo_B = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNITEM", x => new { x.BizRegID, x.BizLocID, x.CampNo, x.SeqNo, x.ItemCode, x.PackageCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPAIGNITEMSUPP",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    CampNo = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    PackageCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceBase = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    QtyRef = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRef = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    CurrencyReq = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    QtyReq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_B = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DiscAmt = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    TaxAmt = table.Column<decimal>(maxLength: 9, nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Flag = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPAIGNITEMSUPP", x => new { x.BizRegID, x.BizLocID, x.CampNo, x.SeqNo, x.PackageCode, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPCOMMITTEE",
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
                    table.PrimaryKey("PK_CAMPCOMMITTEE", x => new { x.CampID, x.BizRegID, x.BizLocID, x.SeqNo, x.UserID });
                });

            migrationBuilder.CreateTable(
                name: "CAMPDOC",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DocMode = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    CreateMethod = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    PathRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    URLRef = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<byte>(nullable: true, defaultValueSql: "NULL"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPDOC", x => new { x.BizLocID, x.BizRegID, x.CampID, x.DocNo, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPDTL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    LineType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LineName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LineDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LineImage = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UnitPriceReq_B = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_C = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UnitPriceReq_C = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPDTL", x => new { x.BizRegID, x.BizLocID, x.CampID, x.SeqNo, x.LineCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPHDR",
                columns: table => new
                {
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    DocumentNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Name = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Owner = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CampReason = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CampMonths = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    CampEffDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CampExpDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CampNote = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CampOrgAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CampDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalCampAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    RowType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Regions = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    CommID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QuizIDSuppDoc = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ExecStrategy = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Version = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Template = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BaseLineSpend = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TargetSaving = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    IsSetTime = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PublishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedBidStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BidStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedBidEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BidEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PreBidEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsRun = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PauseStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PauseEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PreBidOpt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LotBiddingOpt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    FirstLotRunTime = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    FirstLotRunTimeOpt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TimeLotClose = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TimeLotCloseOpt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsAllowBidOvrTime = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OvrTimeTrigger = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    StartOvrTime = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    OvrTimePeriod = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    EstAwardDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ImproveBidBy = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SubmitTieBidOpt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsAllowSelBidCurr = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsDispExchRate = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ViewMktInfoOpt = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsShowLeadBid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsCanSeeRank = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SeeRankAfter = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsSpecifyInitValue = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsCopy = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EventStatus = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    IsApproved = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ApprovalFlow = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPHDR", x => new { x.CampID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "CAMPITEM",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemDesc_B = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LineCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackageCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrencyBase = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ExchangeRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceBase = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalPriceBase = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CurrencyReq = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceReq_B = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DateReq = table.Column<DateTime>(type: "datetime", nullable: true),
                    QtyReq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRReq = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    QtyRmrkReq = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    TaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SubTotalReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalPriceReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PointReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyRef = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    PointRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRRef = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    QtyRmrkRef = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    TotalPriceRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAdd = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAvg = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceAvgVar = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReqVar = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Variance = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    VatAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AppInfo1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    AppInfo2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Mechanic = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    UOMRef = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceCamp = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RefNo = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    RefNo_B = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPITEM", x => new { x.BizRegID, x.BizLocID, x.CampID, x.SeqNo, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPITEMSUPP",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    PackageCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    ItemType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    UnitPriceBase = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyRef = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceRef = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CurrencyReq = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    QtyReq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_B = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UnitPriceReq_C = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ChangedBy_B = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChangedBy_C = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPITEMSUPP", x => new { x.BizRegID, x.BizLocID, x.CampID, x.SeqNo, x.PackageCode, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPLOT",
                columns: table => new
                {
                    LotID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LotSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    LotStatus = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
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
                    Category = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    LotCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LotName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LotDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LotType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CommID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsVisible = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    SubmitTieBidOpt = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    ImproveBidBy = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DecreaseAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    FrontBufferAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BackBufferAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PlannedLotStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedLotEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LotStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LotEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LotInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotMaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotMinAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotHistAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotMaxP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotMinP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotMin = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotHistP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotTotHist = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotSaveAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotSaveAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LotCurr = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    LeadBidPartRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LeadBidPartLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LeadBidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastBidPartRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastBidPartLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastBidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SelBidPartRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SelBidPartLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SelBidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsOvertime = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CntOvertime = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsSelected = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ShowSeq = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LastActTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPLOT", x => new { x.LotID, x.CampID, x.LotSeq, x.LotStatus });
                });

            migrationBuilder.CreateTable(
                name: "CAMPLOTITEM",
                columns: table => new
                {
                    LotID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    ItemName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    BidType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CommID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsVisible = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    PlannedItemBidStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedItemBidEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ItemBidStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ItemBidEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ItemInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemMaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemMinAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemHistAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotMaxP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotMinP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotMin = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotHistP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemTotHist = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemSaveAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemSaveAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemCurr = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    LeadBidPartRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LeadBidPartLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LeadBidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LeadBidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastBidPartRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastBidPartLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastBidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastBidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    SelBidPartRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SelBidPartLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SelBidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidTotAmtP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SelBidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsOvertime = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CntOvertime = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsSelected = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LotStatus = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPLOTITEM", x => new { x.LotID, x.CampID, x.DocNo, x.SeqNo, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "CAMPLOTPAX",
                columns: table => new
                {
                    LotID = table.Column<string>(maxLength: 20, nullable: false),
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    PaxMode = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PaxRole = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    JoinDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ContactPerson = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactDesignation = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    ContactEmail = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ContactTelNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    ContactMobile = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    IsReq = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsResponse = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsLocked = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsApproved = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    MaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotMaxP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPLOTPAX", x => new { x.LotID, x.CampID, x.BizRegID, x.BizLocID, x.SeqNo, x.PaxRegID, x.PaxLocID });
                });

            migrationBuilder.CreateTable(
                name: "CAMPPAX",
                columns: table => new
                {
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
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
                    PaxMode = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PaxRole = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    JoinDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ContactPerson = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContactDesignation = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    ContactEmail = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ContactTelNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    ContactMobile = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
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
                    table.PrimaryKey("PK_CAMPPAX", x => new { x.CampID, x.BizRegID, x.BizLocID, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "CBXBIDDING",
                columns: table => new
                {
                    BidID = table.Column<string>(maxLength: 20, nullable: false),
                    LotID = table.Column<string>(maxLength: 20, nullable: false),
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BidSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    BidTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    BidInitAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BidQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BidTotAmtP = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    BidTotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BidCurr = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    BidRank = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsPrebid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBXBIDDING", x => new { x.BidID, x.LotID, x.CampID, x.PaxRegID, x.PaxLocID, x.BidSeq });
                });

            migrationBuilder.CreateTable(
                name: "CITY",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    StateCode = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    CityCode = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
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
                    CityDesc = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITY", x => new { x.CountryCode, x.StateCode, x.CityCode });
                });

            migrationBuilder.CreateTable(
                name: "CODEMASTER",
                columns: table => new
                {
                    CodeType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    Code = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CodeDesc = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    CodeRemark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CodeSeq = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    CodeRef = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CodeVal1 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CodeVal2 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CodeVal3 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    SysCode = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true),
                    CodeNum = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CODEMASTER", x => new { x.CodeType, x.Code });
                });

            migrationBuilder.CreateTable(
                name: "CODENUM",
                columns: table => new
                {
                    CodeType = table.Column<string>(maxLength: 3, nullable: false),
                    Code = table.Column<int>(nullable: false),
                    CodeDesc = table.Column<string>(maxLength: 50, nullable: false),
                    CodeSeq = table.Column<int>(nullable: false),
                    SysCode = table.Column<byte>(nullable: false),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: false),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<byte>(nullable: false),
                    Inuse = table.Column<byte>(nullable: false),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CODENUM", x => new { x.CodeType, x.Code });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTDOCUMENT",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    DocCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    DocType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    DocMode = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Description = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    RefID = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PathRef = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Signature = table.Column<byte>(nullable: true, defaultValueSql: "NULL"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTDOCUMENT", x => new { x.BizLocID, x.BizRegID, x.ContractID, x.DocNo });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ContNature = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContComp = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RelatedID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefBatchCode1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefBatchCode2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CompanyID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DestRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CollectionAddress = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    RequestID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Description = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    VersionNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PartitionNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ContCountry = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    ContState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    ContPBT = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ContDuration = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ContDaysLeft = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AgreementDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LapseEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    BizLicID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsLapsed = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LoadCreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SourceSystem = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProcureUnit = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsReceivable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsInvoiceable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsService = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ServiceType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    RegistedSupp = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ActResCnt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtCommitment = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtCommitMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtCommitMin = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtReconcile = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileA = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtUsed = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtUsedP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtInvoiced = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtInvoicedP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtInvoicedA = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtLeftAVG = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtLeftAVGP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Tolerance = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtCommitOrg1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtCommitOrg2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    NextPayID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    NextPayDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextPayAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AuthID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    AuthPOS = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsApproved = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ApprovalFlow = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RefEffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveBy = table.Column<string>(maxLength: 20, nullable: true),
                    AppealDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeclineDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeclineBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TerminateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TerminateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Reason1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Reason2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Reason3 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    VerifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VerifiedBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    DefCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    KppVerifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    KppVerifiedBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTHDR", x => new { x.BizRegID, x.BizLocID, x.ContractID, x.ContractType });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTITEM",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    RefBatchCode1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefBatchCode2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemFreqNum = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ScopeType = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RefSeqNo = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "(0)"),
                    LineType = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItmCatgCode = table.Column<string>(maxLength: 8, nullable: false, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SupplierCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SuppPartNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RevenueID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CommodityERP = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Commodity = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    StatisticCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AssetCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AccountCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CostCenter = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WBSElement = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InternalOrder = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    EffectiveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ScopeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SchemeNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ZoneNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MaterialNo1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    MaterialNo2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    StartTime = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EndTime = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemFreqCode = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ItemFreqType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ItemFrequency = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemCost = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemUOM = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ItmCatgQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemQtyMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PackUOM = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyOrdered = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyOrdLeft = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyOrdLeftP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyReceived = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyRecLeft = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyRecLeftP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyReconcile = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyReconLeft = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyReconLeftP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemContSplitP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemAmtMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtOrdered = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtOrdLeft = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtOrdLeftP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtReceived = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtRecLeft = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtRecLeftP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtReconcile = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileP = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AmtReconcileA = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ReleaseType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PayMethod = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PayFreqType = table.Column<byte>(nullable: false, defaultValueSql: "''"),
                    PayFreq = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    IsRecycle = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    InitQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AddQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SellType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsPack = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemName = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LocCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    DefCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTITEM", x => new { x.BizRegID, x.BizLocID, x.ContractID, x.SeqNo, x.RefBatchCode1, x.RefBatchCode2, x.ContractNo, x.ItemFreqNum });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTRESOURCE",
                columns: table => new
                {
                    ContractID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ResourceID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ResourceType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    SchemeNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ZoneNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    MastType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    MastCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Reference1 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference2 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference3 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference4 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Reference5 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Port1 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Port2 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Station = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    LicID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransportType = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTRESOURCE", x => new { x.ContractID, x.ResourceID, x.ResourceType, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "CONTRACTSCOPESUM",
                columns: table => new
                {
                    ScopeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustBizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemFreqNum = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CustomerName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CollectionAddress = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ScopeType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    RouteSchNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RouteSchType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SchemeNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RouteNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    StreetCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ReqResCnt1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ReqResCnt4 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ActResCnt1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ActResCnt2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ActResCnt3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ActResCnt4 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    MastType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    MastCode = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    MastQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ItemType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCycle = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    StartTime = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EndTime = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemFreqCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItemFreqType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ItemFrequency = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Packaging = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Price = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PriceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPriceDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AvgPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Rate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ProcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    VariationID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ErrCode = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    LocCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    DefCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CurrRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTRACTSCOPESUM", x => new { x.ScopeID, x.MonthCode, x.BizRegID, x.CustBizRegID, x.ContractID, x.BatchCode, x.SeqNo, x.ItemFreqNum });
                });

            migrationBuilder.CreateTable(
                name: "COUNTRY",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 20, nullable: false),
                    CountryDesc = table.Column<string>(maxLength: 50, nullable: false),
                    Prefix = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<byte>(nullable: false),
                    Inuse = table.Column<byte>(nullable: false),
                    Flag = table.Column<byte>(nullable: false),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: false),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false),
                    CountryCode3C = table.Column<string>(maxLength: 20, nullable: false),
                    DefaultCurrencyCode = table.Column<string>(maxLength: 20, nullable: false),
                    HasProvinceStates = table.Column<string>(maxLength: 20, nullable: false),
                    APISRequiredOutbound = table.Column<string>(maxLength: 20, nullable: false),
                    APISRequiredInbound = table.Column<string>(maxLength: 20, nullable: false),
                    APPSRequiredOutbound = table.Column<string>(maxLength: 20, nullable: false),
                    APPSRequiredInbound = table.Column<string>(maxLength: 20, nullable: false),
                    APISCheckDocuments = table.Column<string>(maxLength: 20, nullable: false),
                    PaxAddressRequirement = table.Column<string>(maxLength: 20, nullable: false),
                    AQQRequired = table.Column<string>(maxLength: 20, nullable: false),
                    ConnectFee = table.Column<decimal>(maxLength: 9, nullable: false),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COUNTRY", x => x.CountryCode);
                });

            migrationBuilder.CreateTable(
                name: "CURRENCY",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 2, nullable: false),
                    CurrencyCode = table.Column<string>(maxLength: 3, nullable: false),
                    CurrencyDesc = table.Column<string>(maxLength: 50, nullable: false),
                    Rate = table.Column<decimal>(maxLength: 5, nullable: false),
                    Unit = table.Column<int>(nullable: false),
                    CurrencySymbol = table.Column<string>(maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<byte>(nullable: false),
                    Inuse = table.Column<byte>(nullable: false),
                    Flag = table.Column<byte>(nullable: false),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURRENCY", x => new { x.CountryCode, x.CurrencyCode });
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    CustomerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BranchID = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    CategoryID = table.Column<string>(maxLength: 8, nullable: true, defaultValueSql: "''"),
                    PrivilegeCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    CustType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Salutation = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Surname = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    NRICNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Address1 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Address2 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Address3 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Address4 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "''"),
                    Country = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "''"),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    Sex = table.Column<string>(maxLength: 1, nullable: true, defaultValueSql: "''"),
                    Race = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Religion = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Nationality = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Marital = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Occupation = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    HomeTel = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    OfficeTel = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    FaxNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    MobileNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Email = table.Column<string>(maxLength: 80, nullable: true, defaultValueSql: "''"),
                    LoyaltyMember = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    MemberID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    AccumPoints = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    RefID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Remarks = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CommID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    IsEmployee = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CrAccNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    FeedBack = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Referral = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    JoinDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefInfo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    IMAGE = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Expiry = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Rowgid = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    isHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(maxLength: 50, nullable: true, defaultValueSql: "(1)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Status1 = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => new { x.CustomerID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "DISTRICT",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    StateCode = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    DistrictCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    DistrictDesc = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DISTRICT", x => new { x.CountryCode, x.StateCode, x.DistrictCode });
                });

            migrationBuilder.CreateTable(
                name: "EMAIL",
                columns: table => new
                {
                    BatchNo = table.Column<string>(maxLength: 20, nullable: false),
                    MsgID = table.Column<string>(maxLength: 150, nullable: false, defaultValueSql: "''"),
                    TransID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    AgentID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RecordLocator = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QueueCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    FilePath = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    ExecutionID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    EmailType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    EmailAddress = table.Column<string>(maxLength: 266, nullable: true),
                    CCEmailAddress = table.Column<string>(maxLength: 266, nullable: true),
                    BCCEmailAddress = table.Column<string>(maxLength: 266, nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    Currency = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    BalanceDue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PaymentAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransTotalAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AttemptCountSender = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AttemptCountSenderDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    EmailFailedRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    IsSent = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    HelpLinePassword = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    EmailBody = table.Column<string>(nullable: true),
                    EmailTemplate = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    NotifyDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    IsTemplateUpdated = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ApprovedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    UpdatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsDeleted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMAIL", x => new { x.BatchNo, x.MsgID });
                });

            migrationBuilder.CreateTable(
                name: "EMPBRANCH",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    InAppt = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    IsServer = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPBRANCH", x => new { x.EmployeeID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    EmployeeType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    ReferralCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferralID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    NickName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SurName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
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
                    EmailAddress = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    Designation = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
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
                    Status = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    AccessLvl = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    LoginType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Department = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    FromTransporter = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    StatusAdd = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)"),
                    Position1 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Position2 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Role1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Role2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Role3 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    WorkerType = table.Column<byte>(maxLength: 1, nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => new { x.EmployeeID, x.BizRegID });
                });

            migrationBuilder.CreateTable(
                name: "IMAGEUPLOAD",
                columns: table => new
                {
                    UploadImageID = table.Column<string>(maxLength: 20, nullable: false),
                    RefNo = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false),
                    UploadType = table.Column<string>(maxLength: 10, nullable: false),
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
                    PathImage = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGEUPLOAD", x => new { x.UploadImageID, x.RefNo, x.SeqNo, x.UploadType });
                });

            migrationBuilder.CreateTable(
                name: "IMPRESSION",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UniqueID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    CampNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackageCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClickNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ClickDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubmitNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubmitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Validated = table.Column<byte>(nullable: false, defaultValueSql: "''"),
                    UserID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionType = table.Column<byte>(nullable: false, defaultValueSql: "''"),
                    ImpressionCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPRESSION", x => new { x.BizRegID, x.BizLocID, x.UniqueID, x.ImpressionID });
                });

            migrationBuilder.CreateTable(
                name: "IMPRESSIONPROGRESS",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UniqueID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImpressionID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CampNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ClickNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ClickDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubmitNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SubmitDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Validated = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    UserID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ImpressionType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ImpressionCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ishost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMPRESSIONPROGRESS", x => new { x.BizRegID, x.BizLocID, x.UniqueID, x.ImpressionID });
                });

            migrationBuilder.CreateTable(
                name: "INSERVICEDTL",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MSTRID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    DeliveryDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Qty = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    UnitCost = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OrgPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    NettPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SubTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    NettAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    SubPoints = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Points = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PriceOverrided = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Discounted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Taxable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ReturnCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PriceAuthID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    CustPkgID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PrcDisplayType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    PromoCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    QGroupID = table.Column<int>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSERVICEDTL", x => new { x.BizRegID, x.BizLocID, x.InSvcID, x.MSTRID, x.SeqNo, x.DeliveryDate });
                });

            migrationBuilder.CreateTable(
                name: "INSERVICEHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InSvcDate = table.Column<DateTime>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    CustRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CustAddress = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    CustPIC = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CustTelNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    CustEmail = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    RefStatus = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    InSvcTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    OutSvcTime = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    ServerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmpType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransSubTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransAmtRnd = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransAmtSave = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransAmtOrg = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransChgAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TransDiscType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscValue = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDiscAuth = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransDiscReasonCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransDiscRemark = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    TransAmtSpDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransValueSpDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ExchgRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CurrencyPaid = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    CollectedAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPaidID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastPaidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastPaidAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AuthSpDisc = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsSent = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SentAttempt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    SpDiscReasonCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SpDiscRemark = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    Reason = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    PrintedRpt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    IsCompleted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AnalysisSts = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ChkOutTermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Signature = table.Column<byte>(nullable: true),
                    FilePath = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSERVICEHDR", x => new { x.BizRegID, x.BizLocID, x.InSvcID, x.CustLocID, x.InSvcDate });
                });

            migrationBuilder.CreateTable(
                name: "INSPECTCHECK",
                columns: table => new
                {
                    InspectCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SiteCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LotCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    SubDest1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SiteType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    LotType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    MHECode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ClassType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TypeCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SentQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AdjQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SentPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AdjPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SYSKey = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SYSType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    SYSValue = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Condition = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Rating1 = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    Images = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Rating2 = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    Images2 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    ConfirmID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsLocked = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSPECTCHECK", x => new { x.InspectCode, x.SiteCode, x.LotCode, x.SeqNo, x.SubDest1, x.SubDest2 });
                });

            migrationBuilder.CreateTable(
                name: "INVOICEDTL",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RefSeq = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    IsCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    BillNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    EntryTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    StkCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    StkDesc = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    StkType = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ItemType = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    UnitCost = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    OrgPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    NettPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    TolAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    DiscAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    NettAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    SubPoints = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    Points = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    PriceOverrided = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Discounted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Taxable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ReturnCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    PriceAuthID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CustPkgID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    PrcDisplayType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    PromoCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ExCode1 = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    ExCode2 = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    BaseRate = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate2H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate2G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate3H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate3G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate4H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate4G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate5H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate5G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    WarSerialNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true),
                    PathRef = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICEDTL", x => new { x.BizLocID, x.BizRegID, x.TransNo, x.TransSeq, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "INVOICEHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    TransType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    BillNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CustPkgID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CashierID = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ShiftCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TotalServer = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    ServerID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    EmpType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TillID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransStartTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TransEndTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TransPayTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TransAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransSubTotal = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransAmtRnd = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransAmtSave = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransAmtOrg = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransChgAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransDiscCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TransDiscType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransDiscValue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransDiscAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransDiscAuth = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransDiscReasonCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransDiscRemark = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransAmtSpDisc = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransValueSpDisc = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AuthSpDisc = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SpDiscReasonCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SpDiscRemark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CustType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CustPrivilege = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    AcctNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TotalPoints = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransReasonCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    TransStatus = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    PostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Training = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Profiled = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TblNo = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TblPax = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    TransPointsStatus = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransPoints = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICEHDR", x => new { x.BizRegID, x.BizLocID, x.TransNo });
                });

            migrationBuilder.CreateTable(
                name: "INVOICEHDR_CWMS",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    TotalRec1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec4 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec5 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt4 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt5 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICEHDR_CWMS", x => new { x.MonthCode, x.PBTCode, x.BatchCode });
                });

            migrationBuilder.CreateTable(
                name: "INVOICEHDR_OLD",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TotalRec1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec4 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec5 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt4 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt5 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICEHDR_OLD", x => new { x.MonthCode, x.PBTCode, x.BatchCode });
                });

            migrationBuilder.CreateTable(
                name: "INVOICEITEM",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    CompanyName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    InvDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ItemType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Amount1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Amount2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ProcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ErrCode = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    FilePath = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICEITEM", x => new { x.MonthCode, x.PBTCode, x.BizRegID, x.BatchCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "INVOICETAX",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TaxCode = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    TaxAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    TaxRate = table.Column<decimal>(maxLength: 5, nullable: true, defaultValueSql: "(1)"),
                    TaxInEx = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TaxCharge = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    TaxRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Points = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICETAX", x => new { x.BizRegID, x.BizLocID, x.TransNo, x.TaxCode });
                });

            migrationBuilder.CreateTable(
                name: "ITEM",
                columns: table => new
                {
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmCatgCode = table.Column<string>(maxLength: 8, nullable: true, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ShortDesc = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ItmBrand = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TypeCode = table.Column<string>(maxLength: 8, nullable: true, defaultValueSql: "''"),
                    ItmSize = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ActType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ClassType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    RegType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TariffCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    OrgCountry = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    MATNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    MarkNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "(1)"),
                    ItmSize1 = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ItmSize2 = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ConSize = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    ConUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    DefUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    BehvShow = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ComboItem = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    FreqNum = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    FreqType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    LooseUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    IsSales = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsEmpDisc = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsRtnable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsDisc = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsFOC = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsTaxable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AvgCost = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    StdCost = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    StdMarkup = table.Column<decimal>(maxLength: 5, nullable: true, defaultValueSql: "(0)"),
                    StdSellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    IsSelected = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsBestBuy = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsPurchase = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsWLength = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsPack = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsConsumable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    PriceType = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    ImagePath = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    AppID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RemarkA = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RemarkB = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM", x => x.ItemCode);
                });

            migrationBuilder.CreateTable(
                name: "ITEMCATEGORY",
                columns: table => new
                {
                    DeptCode = table.Column<string>(maxLength: 4, nullable: false),
                    CatgCode = table.Column<string>(maxLength: 8, nullable: false),
                    CatgDesc = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    TypeCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SalesTarget = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    DesireStock = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    DualReceipt = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    PrintLineId = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCATEGORY", x => new { x.DeptCode, x.CatgCode });
                });

            migrationBuilder.CreateTable(
                name: "ITEMCOMBO",
                columns: table => new
                {
                    BranchID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "(1)"),
                    ItemCombo = table.Column<string>(maxLength: 20, nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    ComboType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    StdSellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    FixedPrice = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Qty = table.Column<int>(nullable: true, defaultValueSql: "(1)"),
                    PerSession = table.Column<int>(nullable: true, defaultValueSql: "(1)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCOMBO", x => new { x.BranchID, x.ItemCombo, x.ItemCode, x.ComboType });
                });

            migrationBuilder.CreateTable(
                name: "ITEMCOSTGRP",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmCatgCode = table.Column<string>(maxLength: 8, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Criteria = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Mode = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    FreqCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    FreqNum = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    FreqType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    PriceLevel = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    BranchID = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    CostPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RangeFrm = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RangeTo = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    Margin = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Points = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemFull = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemMixPoint = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemMixValue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate2H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate2G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate3H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate3G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate4H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate4G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate5H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate5G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CCID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    CostPrice1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostPrice2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostPrice3 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMCOSTGRP", x => new { x.DocCode, x.ItemCode, x.ItmCatgCode, x.ItemType, x.Criteria, x.Mode, x.FreqCode, x.FreqNum, x.FreqType, x.SvcType, x.EffDate, x.PriceLevel });
                });

            migrationBuilder.CreateTable(
                name: "ITEMLOC",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    StorageID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ShortDesc = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ItemComponent = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    TariffCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OrgCountry = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MATNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    MarkNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ItmSize2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmSize1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmSize = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ConSize = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ConUOM = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    DefUOM = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    ClassType = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    TypeCode = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    BehvShow = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ComboItem = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ItmCatgCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmBrand = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LooseUOM = table.Column<string>(maxLength: 4, nullable: false, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsSales = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsEmpDisc = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsRtnable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsDisc = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsFOC = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsTaxable = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AvgCost = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    StdCost = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    StdMarkup = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    StdSellPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    IsRecycle = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsSelected = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsBestBuy = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsPurchase = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsWLength = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TrackSerial = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    MinQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MaxQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ImageName = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    IncomingQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    IncomingPackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ReOrderLvl = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ReOrderQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyOnHand = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtySellable = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyBalance = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PackQtyBalance = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    POQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OutgoingQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OutgoingPackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    QtyAdj = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    PackQtyAdj = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    FirstIn = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastIn = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPackIn = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPO = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastOut = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPackOut = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastRV = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastAdj = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LastPackAdj = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CummQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    DayQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LDayQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MthQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LMthQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    MtdQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    YrQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    LYrQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    YtdQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ExpiredQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProcessDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMLOC", x => new { x.BizRegID, x.BizLocID, x.ItemCode, x.ItemType, x.SeqNo, x.ItemName });
                });

            migrationBuilder.CreateTable(
                name: "ITEMPRICE",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmCatgCode = table.Column<string>(maxLength: 8, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Criteria = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Mode = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    FreqCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    FreqNum = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    FreqType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    PriceLevel = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    BranchID = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RangeFrm = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RangeTo = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    Margin = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Points = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemFull = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemMixPoint = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemMixValue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate2H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate2G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate3H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate3G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate4H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate4G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate5H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate5G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CCID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    SellPrice1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice3 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMPRICE", x => new { x.DocCode, x.ItemCode, x.ItmCatgCode, x.ItemType, x.Criteria, x.Mode, x.FreqCode, x.FreqNum, x.FreqType, x.SvcType, x.EffDate, x.PriceLevel });
                });

            migrationBuilder.CreateTable(
                name: "ITEMPRICEHDR",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PriceLevel = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RegistedSupp = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CompanyID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CompanyType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransInit = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransSrc = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransDest = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    InterTrans = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Reason = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    PostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    ConfirmDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuthID = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    AuthPOS = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    RowGuid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMPRICEHDR", x => new { x.DocCode, x.BizLocID, x.TransType });
                });

            migrationBuilder.CreateTable(
                name: "ITEMSELLGRP",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItmCatgCode = table.Column<string>(maxLength: 8, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Criteria = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Mode = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    FreqCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    FreqNum = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    FreqType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    PriceLevel = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    BranchID = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RangeFrm = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RangeTo = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    Margin = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Points = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemFull = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemMixPoint = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RedeemMixValue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate2H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate2G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate3H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate3G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate4H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate4G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate5H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate5G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CCID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    SellPrice1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice3 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMSELLGRP", x => new { x.DocCode, x.ItemCode, x.ItmCatgCode, x.ItemType, x.Criteria, x.Mode, x.FreqCode, x.FreqNum, x.FreqType, x.SvcType, x.EffDate, x.PriceLevel });
                });

            migrationBuilder.CreateTable(
                name: "ITMTRANSDTL",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    StorageID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    SeqNo = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    TransType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    OperationType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    ItmPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ReqQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ReqPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    OpeningQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    OpeningPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Qty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    HandlingQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    HandlingPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ClosingQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ClosingPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastInQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastInPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastOutQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    LastOutPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RtnPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RtnQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecPackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ExpiredQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    LotNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    AreaCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    SecCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    BinCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    RowGuid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    isHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITMTRANSDTL", x => new { x.DocCode, x.ItemCode, x.ItemName, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "ITMTRANSHDR",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RequestCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    RegistedSupp = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CompanyID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CompanyType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransInit = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransSrc = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransDest = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    InterTrans = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Reason = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    PostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ConfirmDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuthID = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    AuthPOS = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApproveBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    isHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITMTRANSHDR", x => new { x.DocCode, x.BizLocID, x.TransType });
                });

            migrationBuilder.CreateTable(
                name: "LICENSE",
                columns: table => new
                {
                    ContractNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CompanyID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContType = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    ContCategory = table.Column<string>(maxLength: 8, nullable: true, defaultValueSql: "''"),
                    InquiryNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    InquiryDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    ValidityStart = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    ValidityEnd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    FileNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    SchemeNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    LocID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Country = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "''"),
                    PBT = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    City = table.Column<string>(maxLength: 5, nullable: true, defaultValueSql: "''"),
                    Area = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    ComplianceNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Compliance = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Remark4 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    Remark5 = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    LicenceQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    DestinationID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LicenseNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    LicenseDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    PaymentAmount = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    ReceiptNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Renew = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AuthID = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    AuthPOS = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApproveDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    ApproveBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    isHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true),
                    IDPREMIS = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICENSE", x => new { x.ContractNo, x.CompanyID });
                });

            migrationBuilder.CreateTable(
                name: "LOA",
                columns: table => new
                {
                    LOAID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    LOACode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LOAType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LOADesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RulesType = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    AppliedUrl = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOA", x => x.LOAID);
                });

            migrationBuilder.CreateTable(
                name: "LOARULES",
                columns: table => new
                {
                    RulesID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    RulesCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    EmpApprCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesBy = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LOAID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesReff = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LowerBudgetAmt = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    LowerUnBudgetAmt = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    LowerSign = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    UpperSign = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    UpperBudgetAmt = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    UpperUnBudgetAmt = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    LogicCondition = table.Column<string>(maxLength: 2, nullable: true, defaultValueSql: "''"),
                    MinApprover = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Seq = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RoleID = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOARULES", x => x.RulesID);
                });

            migrationBuilder.CreateTable(
                name: "LOGEVENT",
                columns: table => new
                {
                    EventID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "(0)"),
                    EventType = table.Column<int>(nullable: true, defaultValueSql: "''"),
                    EventDescription = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Browser = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    IP = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "(0)"),
                    ExecDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(0)"),
                    ScheduleID = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    ScheduleType = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(1)"),
                    Source = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    Destination = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    SuccessExec = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ExecMessage = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BusinessObject = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ErrorMessage = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreatedBy = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefNo = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGEVENT", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "MOB_QUEST",
                columns: table => new
                {
                    AppID = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    GrpID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ActType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SYSKey = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SYSType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    SYSDesc = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    RefType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    RefValue = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    IsCheck = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ChkType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ChkValue = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOB_QUEST", x => new { x.AppID, x.GrpID, x.ActType, x.SYSKey });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTDTL",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "(0)"),
                    TransRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    NextDueDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    NextDueAmount = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    RemindAttempt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    IsLatest = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    AttemptCount = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RemindLog = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LineTotal = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineTax = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineFee = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineCharge = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineVAT = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineOth = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineDisc = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    LineGST = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    IsOverride = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTDTL", x => new { x.BizLocID, x.BizRegID, x.PaymentID, x.TransRef, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentTransID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    MerchantCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    BaseCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    TransCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    TransTotalAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransPaidAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TransDueAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ProductDesc = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    UserName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    UserEmail = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    UserContact = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    ResponseURL = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    AdditionalURL = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Signature = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    TransStatus = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTHDR", x => new { x.BizRegID, x.BizLocID, x.PaymentTransID, x.PaymentRef, x.MerchantCode });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTLOG",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LogID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentTransID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RefNo = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LogRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    LogAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AuthorizationCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    MerchantCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BankCode = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BankName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CheckSum = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    CheckSumString = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTLOG", x => new { x.BizRegID, x.BizLocID, x.LogID, x.PaymentTransID, x.TenderID, x.TenderCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "PAYMENTTENDER",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentTransID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TenderType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    MerchantCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TenderRef = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    TenderDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    TenderCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    BaseCurrency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    ExchgRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TenderAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    FeeType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    FeeAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    PayAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(1)"),
                    TransStatus = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENTTENDER", x => new { x.BizRegID, x.BizLocID, x.PaymentTransID, x.TenderID, x.TenderCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "PBT",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 2, nullable: false),
                    StateCode = table.Column<string>(maxLength: 5, nullable: false),
                    PBTCode = table.Column<string>(maxLength: 10, nullable: false),
                    PBTDesc = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<byte>(nullable: false),
                    Inuse = table.Column<byte>(nullable: false),
                    Flag = table.Column<byte>(nullable: false),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: false),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PBT", x => new { x.CountryCode, x.StateCode, x.PBTCode });
                });

            migrationBuilder.CreateTable(
                name: "PFI",
                columns: table => new
                {
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false),
                    TID = table.Column<int>(nullable: true, defaultValueSql: "''"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Distributor = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Trans = table.Column<string>(maxLength: 50, nullable: true),
                    KD_Produk = table.Column<string>(maxLength: 20, nullable: true),
                    KD_Pabrik = table.Column<string>(maxLength: 20, nullable: true),
                    Nama_Produk = table.Column<string>(maxLength: 70, nullable: true),
                    Subbrand = table.Column<string>(maxLength: 50, nullable: true),
                    Brand = table.Column<string>(maxLength: 50, nullable: true),
                    Rasa = table.Column<string>(maxLength: 50, nullable: true),
                    Principal = table.Column<string>(maxLength: 50, nullable: true),
                    Kategori = table.Column<string>(maxLength: 50, nullable: true),
                    Prod_Class = table.Column<string>(maxLength: 20, nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    Kartonutuh = table.Column<int>(nullable: true),
                    Pieces = table.Column<int>(nullable: true),
                    Freegood_Pcs = table.Column<int>(nullable: true),
                    Nilai_Bruto_DPP = table.Column<decimal>(nullable: true),
                    Nilai_Netto_DPP = table.Column<decimal>(nullable: true),
                    Nilai_Netto_PPN = table.Column<decimal>(nullable: true),
                    Nilai_Freegood = table.Column<decimal>(nullable: true),
                    Discitem = table.Column<decimal>(nullable: true),
                    Discnota = table.Column<decimal>(nullable: true),
                    KD_Cust = table.Column<string>(maxLength: 20, nullable: true),
                    NM_Cust = table.Column<string>(maxLength: 70, nullable: true),
                    Type = table.Column<string>(maxLength: 50, nullable: true),
                    Area = table.Column<string>(maxLength: 20, nullable: true),
                    Subarea = table.Column<string>(maxLength: 50, nullable: true),
                    Salesman = table.Column<string>(maxLength: 20, nullable: true),
                    Supervisor = table.Column<string>(maxLength: 20, nullable: true),
                    Hcode1 = table.Column<string>(maxLength: 20, nullable: true),
                    Hdesc1 = table.Column<string>(maxLength: 50, nullable: true),
                    Hcode2 = table.Column<string>(maxLength: 20, nullable: true),
                    Hdesc2 = table.Column<string>(maxLength: 50, nullable: true),
                    Hcode3 = table.Column<string>(maxLength: 20, nullable: true),
                    Hdesc3 = table.Column<string>(maxLength: 50, nullable: true),
                    No_Nota = table.Column<string>(maxLength: 20, nullable: true),
                    Tanggal = table.Column<DateTime>(type: "datetime", nullable: true),
                    Bulan = table.Column<string>(maxLength: 20, nullable: true),
                    Tahun_Bulan = table.Column<string>(maxLength: 20, nullable: true),
                    Week = table.Column<string>(maxLength: 20, nullable: true),
                    KeyAcount = table.Column<string>(maxLength: 50, nullable: true),
                    KodeSalesman = table.Column<string>(maxLength: 20, nullable: true),
                    CustGroup = table.Column<string>(maxLength: 50, nullable: true),
                    Cabang = table.Column<string>(maxLength: 50, nullable: true),
                    Alamat = table.Column<string>(maxLength: 255, nullable: true),
                    Customerpo = table.Column<string>(maxLength: 20, nullable: true),
                    Divisi = table.Column<string>(maxLength: 20, nullable: true),
                    Tonnage = table.Column<int>(nullable: true),
                    Qtysold_Pcs = table.Column<int>(nullable: true),
                    DiscSpesial = table.Column<decimal>(nullable: true),
                    DiscSpesialRp = table.Column<decimal>(nullable: true),
                    DiscPromosiTotalRp = table.Column<decimal>(nullable: true),
                    DiscPromoLvl1 = table.Column<decimal>(nullable: true),
                    DiscPromoRPLvl1 = table.Column<decimal>(nullable: true),
                    DiscPromoLvl2 = table.Column<decimal>(nullable: true),
                    DiscPromoRPLvl2 = table.Column<decimal>(nullable: true),
                    DiscPromoLvl3 = table.Column<decimal>(nullable: true),
                    DiscPromoRPLvl3 = table.Column<decimal>(nullable: true),
                    JoinDateSalesman = table.Column<DateTime>(type: "datetime", nullable: true),
                    JoinDateCustomer = table.Column<DateTime>(type: "datetime", nullable: true),
                    Product_Barcode = table.Column<string>(maxLength: 70, nullable: true),
                    Customer_Barcode = table.Column<string>(maxLength: 70, nullable: true),
                    DriverID = table.Column<int>(nullable: true),
                    ACC = table.Column<string>(maxLength: 10, nullable: true),
                    KA_NKA = table.Column<string>(maxLength: 10, nullable: true),
                    Types = table.Column<string>(maxLength: 10, nullable: true),
                    BatchDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    ErrorMessage = table.Column<string>(maxLength: 4000, nullable: true),
                    ErrorCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    FileName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Rowgid = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFI", x => new { x.BatchCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "PROCTASK",
                columns: table => new
                {
                    ProSegID = table.Column<string>(maxLength: 20, nullable: false),
                    TaskID = table.Column<long>(nullable: false),
                    AgentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TaskType = table.Column<byte>(nullable: false),
                    SubType = table.Column<string>(maxLength: 3, nullable: false),
                    TaskStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    TaskEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    TaskValue1 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    TaskValue2 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Result = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "(0)"),
                    BatchNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    MsgID = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    TransID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RecordLocator = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QueueCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    EmailType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    EmailAddress = table.Column<string>(maxLength: 266, nullable: true, defaultValueSql: "''"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    Currency = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    BalanceDue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PaymentAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransTotalAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AttemptCountSender = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AttemptCountSenderDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsSuccess = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    FinishedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    FailedRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ApprovedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "NULL"),
                    UpdatedBy = table.Column<string>(maxLength: 100, nullable: true, defaultValueSql: "''"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsDeleted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROCTASK", x => new { x.ProSegID, x.TaskID, x.AgentID, x.TaskType, x.SubType, x.TaskStartDate });
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTISMUPLOAD",
                columns: table => new
                {
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Brand = table.Column<string>(maxLength: 50, nullable: true),
                    SysCode = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CodeNum = table.Column<decimal>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTISMUPLOAD", x => new { x.LastUpdate, x.Code });
                });

            migrationBuilder.CreateTable(
                name: "PROJECT",
                columns: table => new
                {
                    ProjectID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ProjectType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ProjectDesc = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Ishost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJECT", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "PROMOPOLICY",
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
                    table.PrimaryKey("PK_PROMOPOLICY", x => new { x.BizRegID, x.BizLocID, x.PromoID, x.PolicyNo, x.ItemCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONDTL",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SecNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Role = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    DocReq = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONDTL", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.SecNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONGROUP",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SecNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    GrpNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QuizValue = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    OptType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptValue = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true, defaultValueSql: "NULL"),
                    Description = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONGROUP", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.SecNo, x.GrpNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONHDR",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true, defaultValueSql: "''"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Role = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    Description = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    DocReq = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONHDR", x => new { x.QuizID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONITEM",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SecNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    GrpNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    QuizValue = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    OptType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptValue = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    OptGroupID = table.Column<string>(maxLength: 20, nullable: true),
                    ScoreWeight = table.Column<decimal>(nullable: true, defaultValueSql: "NULL"),
                    UOM = table.Column<string>(maxLength: 3, nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONITEM", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.SecNo, x.GrpNo, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONPAX",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SecNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true),
                    TotalAmt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AvgScore = table.Column<decimal>(nullable: true),
                    WeightedScore = table.Column<decimal>(nullable: true),
                    NormalisedScore = table.Column<decimal>(nullable: true),
                    WeightedScorePercent = table.Column<decimal>(nullable: true),
                    WeightedScoreDefault = table.Column<decimal>(nullable: true),
                    NormalisedScoreDefault = table.Column<decimal>(nullable: true),
                    WeightedScorePercentDefault = table.Column<decimal>(nullable: true),
                    Response = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    ResponseOptID = table.Column<string>(maxLength: 20, nullable: true),
                    ResponseText = table.Column<string>(maxLength: 4000, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAX", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.PaxRegID, x.PaxLocID, x.ParentID, x.SecNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONPAXITEM",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SecNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    GrpNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
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
                    OptType = table.Column<string>(maxLength: 20, nullable: true),
                    OptID = table.Column<string>(maxLength: 20, nullable: true),
                    Value = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    UOM = table.Column<string>(maxLength: 3, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Note = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAXITEM", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.PaxRegID, x.PaxLocID, x.ParentID, x.SecNo, x.GrpNo, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONPAXSCORE",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false),
                    SecNo = table.Column<int>(nullable: false),
                    GrpNo = table.Column<int>(nullable: false),
                    SeqNo = table.Column<int>(nullable: false),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    ReviewedBy = table.Column<string>(maxLength: 20, nullable: false),
                    Score = table.Column<int>(nullable: false),
                    ScoreDefault = table.Column<int>(nullable: false),
                    DocNo = table.Column<string>(maxLength: 50, nullable: false),
                    UOM = table.Column<string>(maxLength: 3, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false),
                    Note = table.Column<string>(maxLength: 4000, nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Posted = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAXSCORE", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.PaxRegID, x.PaxLocID, x.ParentID, x.SecNo, x.GrpNo, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "QUESTIONPAXSUM",
                columns: table => new
                {
                    QuizID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxRegID = table.Column<string>(maxLength: 20, nullable: false),
                    PaxLocID = table.Column<string>(maxLength: 20, nullable: false),
                    ParentID = table.Column<string>(maxLength: 20, nullable: false),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    QuizType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScoreWeight = table.Column<decimal>(nullable: true),
                    TotalAmt = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalQty = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    AvgScore = table.Column<decimal>(nullable: true),
                    WeightedScore = table.Column<decimal>(nullable: true),
                    NormalisedScore = table.Column<decimal>(nullable: true),
                    WeightedScorePercent = table.Column<decimal>(nullable: true),
                    WeightedScoreDefault = table.Column<decimal>(nullable: true),
                    NormalisedScoreDefault = table.Column<decimal>(nullable: true),
                    WeightedScorePercentDefault = table.Column<decimal>(nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QUESTIONPAXSUM", x => new { x.QuizID, x.BizRegID, x.BizLocID, x.PaxRegID, x.PaxLocID, x.ParentID });
                });

            migrationBuilder.CreateTable(
                name: "SAP_ITEMPRICE",
                columns: table => new
                {
                    ConditionKey = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefGrp = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Material = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BranchID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    PriceType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CostCenter = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ExpDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ItemType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    UnitPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    UOM = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ActionID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    ActionDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAP_ITEMPRICE", x => x.ConditionKey);
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULEDTL",
                columns: table => new
                {
                    ScheduleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    VehicleNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WorkerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEDTL", x => new { x.ScheduleID, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULEHDR",
                columns: table => new
                {
                    MSTRID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PlanID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
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
                    RequestID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubRequestID = table.Column<string>(maxLength: 6, nullable: false, defaultValueSql: "''"),
                    WorkType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    VehicleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    PlannedStartTime = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PlannedEndTime = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ActualStartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(0)"),
                    ActualEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(0)"),
                    ActualStartTime = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ActualEndTime = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ReferenceNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocDesc1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    SubOri1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubOri2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocRemark1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocRemark2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    IsReq = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    IsCompleted = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    LiveCal = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    DestRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "'COL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEHDR", x => new { x.MSTRID, x.PlanID, x.ScheduleID, x.ContractID, x.BizLocID, x.LocID, x.CustomerID, x.TransDate, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "SCHEDULEITEM",
                columns: table => new
                {
                    ScheduleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
                    MastType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Multiplier = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellPrice3 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TotAmt1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TotAmt2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TotAmt3 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    IsPack = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    InitQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AddQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SellType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CostAmt1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostAmt2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CostAmt3 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHEDULEITEM", x => new { x.ScheduleID, x.SeqNo, x.MastType, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "STATE",
                columns: table => new
                {
                    CountryCode = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    StateCode = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
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
                    RegionCode = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    OldStateCode = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    StateDesc = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    EmailState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATE", x => new { x.CountryCode, x.StateCode });
                });

            migrationBuilder.CreateTable(
                name: "STGAPPROVAL",
                columns: table => new
                {
                    StagingID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AddressType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    AddressChange = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Address1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Address2 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address3 = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "''"),
                    Address4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    PackageType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Email = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Country = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    State = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    City = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    District = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    TransporterID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BankCode1 = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ContactPerson2 = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    QtyBin = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RefNo1 = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsRead = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    RejectRemark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    StatusApproval = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STGAPPROVAL", x => new { x.StagingID, x.BizRegID });
                });

            migrationBuilder.CreateTable(
                name: "SYSCODEB",
                columns: table => new
                {
                    BranchID = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SysCode = table.Column<string>(maxLength: 20, nullable: false),
                    SysDesc = table.Column<string>(maxLength: 50, nullable: true),
                    Prefix = table.Column<string>(maxLength: 10, nullable: true),
                    SpCode = table.Column<string>(maxLength: 10, nullable: true),
                    RunNo = table.Column<int>(nullable: true),
                    NoLength = table.Column<byte>(nullable: true),
                    NoPos = table.Column<byte>(nullable: true),
                    Postfix = table.Column<string>(maxLength: 10, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    SysID = table.Column<byte>(nullable: true),
                    CheckFormat = table.Column<string>(maxLength: 20, nullable: true),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSCODEB", x => new { x.BranchID, x.SysCode });
                });

            migrationBuilder.CreateTable(
                name: "SYSPREFB",
                columns: table => new
                {
                    BranchID = table.Column<string>(maxLength: 10, nullable: false),
                    SYSKey = table.Column<string>(maxLength: 50, nullable: false),
                    SYSValue = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    SYSSet = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSPREFB", x => new { x.BranchID, x.SYSKey });
                });

            migrationBuilder.CreateTable(
                name: "SYSPREFT",
                columns: table => new
                {
                    AppID = table.Column<byte>(nullable: false),
                    GrpID = table.Column<string>(maxLength: 20, nullable: false),
                    SYSKey = table.Column<string>(maxLength: 50, nullable: false),
                    SYSValue = table.Column<string>(maxLength: 255, nullable: false),
                    SYSValueEx = table.Column<string>(maxLength: 255, nullable: false),
                    SYSSet = table.Column<byte>(nullable: false),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: false),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: false),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSPREFT", x => new { x.AppID, x.GrpID, x.SYSKey });
                });

            migrationBuilder.CreateTable(
                name: "SYSREPORT",
                columns: table => new
                {
                    APPID = table.Column<byte>(nullable: false),
                    RPTCode = table.Column<string>(maxLength: 20, nullable: false),
                    RPTName = table.Column<string>(maxLength: 255, nullable: true),
                    RPTDesc = table.Column<string>(maxLength: 255, nullable: true),
                    QueryType = table.Column<byte>(nullable: true),
                    RPTQuery = table.Column<string>(maxLength: 4000, nullable: true),
                    RPTType = table.Column<byte>(nullable: true),
                    RPTSection = table.Column<byte>(nullable: true),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true),
                    SeqNo = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSREPORT", x => new { x.APPID, x.RPTCode });
                });

            migrationBuilder.CreateTable(
                name: "TASKASSIGN",
                columns: table => new
                {
                    TaskID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TaskCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TaskType = table.Column<byte>(nullable: false),
                    LOAID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(nullable: false),
                    EmpApprID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASKASSIGN", x => x.TaskID);
                });

            migrationBuilder.CreateTable(
                name: "TASKLOG",
                columns: table => new
                {
                    TaskID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TaskCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TaskType = table.Column<byte>(nullable: false),
                    LOAID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ProjectID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RulesLvl = table.Column<byte>(nullable: false),
                    EmpApprID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ApprovalDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TASKLOG", x => x.TaskID);
                });

            migrationBuilder.CreateTable(
                name: "TENDER",
                columns: table => new
                {
                    TenderID = table.Column<string>(maxLength: 10, nullable: false),
                    TenderType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TenderDesc = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CurrencyCode = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    TenderPrompt = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    RefPrompt = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    DefValue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Pickup1 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Pickup2 = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    MinTenderAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    MaxTenderAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AllowPickup = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AllowFloat = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    AllowOverTender = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    OpenDrawer = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TrackRefNo = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TrackClrDate = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    TrackAppCode = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TENDER", x => x.TenderID);
                });

            migrationBuilder.CreateTable(
                name: "TENDERTYPE",
                columns: table => new
                {
                    TenderCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TenderType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TenderDesc = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    EffDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TENDERTYPE", x => x.TenderCode);
                });

            migrationBuilder.CreateTable(
                name: "TRANSCDHDR",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "(1)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    TotalRec1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec4 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalRec5 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt4 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotalAmt5 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSCDHDR", x => new { x.MonthCode, x.PBTCode, x.BatchCode });
                });

            migrationBuilder.CreateTable(
                name: "TRANSCDITEM",
                columns: table => new
                {
                    MonthCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PBTCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CompanyName = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    CNDNDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ItemType = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "(1)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemDesc = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Amount1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Amount2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ProcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ErrCode = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: false, defaultValueSql: "''"),
                    FilePath = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSCDITEM", x => new { x.MonthCode, x.PBTCode, x.BizRegID, x.BatchCode, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "TRANSDTL",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefSeq = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    IsCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    BillNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    EntryTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    StkCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    StkDesc = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    StkType = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    BehvType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ItemType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    UnitCost = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    OrgPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    NettPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    TolAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    DiscAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    NettAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    SubPoints = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    Points = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    PriceOverrided = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Discounted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Taxable = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ReturnCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    SerialNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    PriceAuthID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "''"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CustPkgID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    PrcDisplayType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    PromoCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ExCode1 = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    ExCode2 = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    BaseRate = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    CoRate1G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate2H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate2G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate3H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate3G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate4H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate4G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate5H = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    CoRate5G = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(1)"),
                    WarSerialNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "(1)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSDTL", x => new { x.BizLocID, x.TermID, x.TransNo, x.TransSeq });
                });

            migrationBuilder.CreateTable(
                name: "TRANSFPX",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TenderID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TenderAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ExchgRate = table.Column<decimal>(maxLength: 5, nullable: true, defaultValueSql: "(0)"),
                    TenderDue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ChangeAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RefInfo = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CCrefInfo = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ExpDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustName = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ClearingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSFPX", x => new { x.BizRegID, x.BizLocID, x.TermID, x.TransNo, x.TransSeq });
                });

            migrationBuilder.CreateTable(
                name: "TRANSHDR",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    BillNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CustPkgID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    CashierID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    ShiftCode = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    TotalServer = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    ServerID = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    EmpType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TillID = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransStartTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TransEndTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TransPayTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "''"),
                    TransAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransSubTotal = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransAmtRnd = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransAmtSave = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransAmtOrg = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransChgAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransDiscCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TransDiscType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransDiscValue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransDiscAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransDiscAuth = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransDiscReasonCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransDiscRemark = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransAmtSpDisc = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    TransValueSpDisc = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    AuthSpDisc = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SpDiscReasonCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    SpDiscRemark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CustomerID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CustType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CustPrivilege = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    AcctNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TotalPoints = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    InSvcID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransReasonCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    TransRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    TransStatus = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    PostDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Training = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Profiled = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LiveCal = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TblNo = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TblPax = table.Column<int>(nullable: true, defaultValueSql: "(0)"),
                    TransPointsStatus = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransPoints = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SyncCreateBy = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSHDR", x => new { x.BizRegID, x.BizLocID, x.TermID, x.TransNo });
                });

            migrationBuilder.CreateTable(
                name: "TRANSTENDER",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TermID = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    TransNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransSeq = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    BillNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransTime = table.Column<string>(maxLength: 6, nullable: true, defaultValueSql: "(0)"),
                    TenderType = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TenderID = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    TenderAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ExchgRate = table.Column<decimal>(maxLength: 5, nullable: true, defaultValueSql: "(0)"),
                    TenderDue = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ChangeAmt = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Currency = table.Column<string>(maxLength: 3, nullable: true, defaultValueSql: "''"),
                    ExternalID = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    MerchantID = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RefKey = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RefType = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefToken = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    RefRemark = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    RefRemark2 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    RefRemark3 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    RefOth1 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RefOth2 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RefOth3 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    CustName = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    CardNo = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    BankCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    BankAccNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    RespCode = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    AuthCode = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    TraceNo = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ExpDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClearingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsApproved = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ApprovedBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovalFlow = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransStatus = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TransVoid = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSTENDER", x => new { x.BizRegID, x.BizLocID, x.TermID, x.TransNo, x.TransSeq });
                });

            migrationBuilder.CreateTable(
                name: "USRAPP",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AppID = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    AccessCode = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    IsInherit = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    PermissionAPI = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USRAPP", x => new { x.UserID, x.AppID });
                });

            migrationBuilder.CreateTable(
                name: "USRGROUP",
                columns: table => new
                {
                    APPID = table.Column<byte>(nullable: false),
                    GroupCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    GroupName = table.Column<string>(maxLength: 30, nullable: true, defaultValueSql: "''"),
                    AccessLevel = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USRGROUP", x => new { x.APPID, x.GroupCode });
                });

            migrationBuilder.CreateTable(
                name: "USRPROFILE",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    UserName = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    Password = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    ParentID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Logged = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    LogStation = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastLogout = table.Column<DateTime>(type: "datetime", nullable: true),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TID = table.Column<int>(nullable: true),
                    RoleCode = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsShared = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Email = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USRPROFILE", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "USRVERIFY",
                columns: table => new
                {
                    UserID = table.Column<string>(maxLength: 20, nullable: false),
                    VeriKey = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    UserType = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    KeyIndex = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    VeriCode = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    VeriType = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Remark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    DeviceBrand = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    TID = table.Column<int>(nullable: true),
                    RejectRemark = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    RequestDate1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequestDate2 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USRVERIFY", x => new { x.UserID, x.VeriKey });
                });

            migrationBuilder.CreateTable(
                name: "VEHICLE",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    VehicleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RegNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    GrpCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Ownership = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "(1)"),
                    VehicleType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    BDM = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BTM = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ManufactYear = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RegisterYear = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RegisterCard = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    WithGPS = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    WithCont = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    WithLifter = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    WithPaint = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    WithPhoto = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OptWith1 = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OptDesc1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptWith2 = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OptDesc2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    OptWith3 = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    OptDesc3 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLE", x => new { x.BizRegID, x.VehicleID });
                });

            migrationBuilder.CreateTable(
                name: "VEHICLEDOCUMENT",
                columns: table => new
                {
                    DocCode = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    VehicleID = table.Column<string>(maxLength: 20, nullable: false),
                    DocType = table.Column<string>(maxLength: 10, nullable: true),
                    DocMode = table.Column<byte>(nullable: true),
                    ValidityStart = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ValidityEnd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Duration = table.Column<int>(nullable: true),
                    DocNo = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    RemindDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    Description = table.Column<string>(maxLength: 70, nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true),
                    PathRef = table.Column<string>(maxLength: 50, nullable: true),
                    DataKey = table.Column<string>(maxLength: 50, nullable: true),
                    Signature = table.Column<byte>(nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    Posted = table.Column<byte>(nullable: true),
                    Status = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    Flag = table.Column<byte>(nullable: true),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    IsHost = table.Column<byte>(nullable: true),
                    TID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VEHICLEDOCUMENT", x => new { x.DocCode, x.BizRegID, x.VehicleID });
                });

            migrationBuilder.CreateTable(
                name: "VOC_VOUCHER",
                columns: table => new
                {
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizUnitID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    VoucherNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RandCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RefType = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    ActivedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AuthCode = table.Column<string>(maxLength: 20, nullable: true),
                    BranchTo = table.Column<string>(maxLength: 20, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IssueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "''"),
                    OwnerID = table.Column<string>(maxLength: 20, nullable: true),
                    RedeemBranchID = table.Column<string>(maxLength: 20, nullable: true),
                    RedeemTransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RedeemTransNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RedeemRegNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    RegistrationNo = table.Column<string>(maxLength: 20, nullable: true),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    TransferDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VoidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    VoidTransNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VoidRegNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VoidBranchID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    UserID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Validated = table.Column<byte>(nullable: true),
                    VoucherType = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    DAY1 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    DAY2 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    DAY3 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    DAY4 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    DAY5 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    DAY6 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    DAY7 = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TMID = table.Column<long>(nullable: true, defaultValueSql: "(0)"),
                    UnitPrice = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "''"),
                    FileRef1 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    FileRef2 = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VOC_VOUCHER", x => new { x.BizRegID, x.BizLocID, x.BizUnitID, x.ItemCode, x.VoucherNo, x.RandCode });
                });

            migrationBuilder.CreateTable(
                name: "WORKER",
                columns: table => new
                {
                    WorkerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    WorkerType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ReferralCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ReferralID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    NickName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SurName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Salutation = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Sex = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    PlaceOfBirth = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    NRICNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Nationality = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Race = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Religion = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Marital = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CoAddress1 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress2 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress3 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoAddress4 = table.Column<string>(maxLength: 40, nullable: false, defaultValueSql: "''"),
                    CoPostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    CoState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    CoCountry = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    PnAddress1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress3 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnAddress4 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    PnPostalCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PnState = table.Column<string>(maxLength: 5, nullable: false, defaultValueSql: "''"),
                    PnCountry = table.Column<string>(maxLength: 2, nullable: false, defaultValueSql: "''"),
                    EmerContactPerson = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    EmerContactNo = table.Column<string>(maxLength: 16, nullable: false, defaultValueSql: "''"),
                    EmailAddress = table.Column<string>(maxLength: 80, nullable: false, defaultValueSql: "''"),
                    Designation = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ForeignLocal = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Position1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Position2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Role1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Role2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    Role3 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    CommID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Salary = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    OffDay = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Overtime = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Leave = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Levy = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Allergies = table.Column<string>(maxLength: 70, nullable: false, defaultValueSql: "''"),
                    ClerkNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    DateHired = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    DateLeft = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    TransportAllowance = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    ServiceAllowance = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    OtherAllowance = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    Remarks = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    PrivilegeCode = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    AccessLvl = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    LocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKER", x => new { x.WorkerID, x.BizRegID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERBIN",
                columns: table => new
                {
                    WOID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false),
                    MastType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PackSerial = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    UOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PackQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Remark1 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERBIN", x => new { x.WOID, x.SeqNo, x.MastType, x.ItemCode, x.PackSerial });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERDTL",
                columns: table => new
                {
                    WOID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    MastType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    ItemType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SentQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AdjQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ActualQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ActualQty1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ActualQty2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    UOM = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PackUOM = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    PackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    RecPackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SentPackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AdjPackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ActualPackQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Multiplier = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SellPrice = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SellPrice1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SellPrice2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SellPrice3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BaseRate = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotAmt1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotAmt2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotAmt3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    IsPack = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Rating1 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Rating2 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    Rating3 = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    ImageRes1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageRes2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageRes3 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageSign1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageSign2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    ImageSign3 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    RefNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Remark3 = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    InitQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    AddQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    SellType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    TreatmentType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CostAmt1 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CostAmt2 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    CostAmt3 = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    ProdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ProdCompany = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NextProcessDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERDTL", x => new { x.WOID, x.SeqNo, x.MastType, x.ItemCode });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERDTLLOG",
                columns: table => new
                {
                    WOID = table.Column<string>(maxLength: 20, nullable: false),
                    SeqNo = table.Column<int>(nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    SellType = table.Column<byte>(nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    RowVersion = table.Column<int>(nullable: false),
                    CRUD = table.Column<string>(maxLength: 1, nullable: true),
                    PrevQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    Qty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevSentQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    SentQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevRecQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    RecQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevActualQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    ActualQty = table.Column<decimal>(maxLength: 9, nullable: true, defaultValueSql: "(0)"),
                    PrevUOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    UOM = table.Column<string>(maxLength: 10, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true),
                    Active = table.Column<byte>(nullable: true),
                    Inuse = table.Column<byte>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERDTLLOG", x => new { x.WOID, x.SeqNo, x.ItemCode, x.SellType, x.LogDate, x.RowVersion });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERHDR",
                columns: table => new
                {
                    MSTRID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WOID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ContractID = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
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
                    CustomerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    RefID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PaymentType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ReceiptNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ChequeNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    WorkType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    VehicleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlannedEndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartTime = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    EndTime = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    ReferenceNo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LocDesc1 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc2 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    LocDesc3 = table.Column<string>(maxLength: 255, nullable: false, defaultValueSql: "''"),
                    SubOri1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubOri2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    IsParent = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    ProcStatus = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    ProcType = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    DestRegID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RcvDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransportType = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    TransportQty = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    BankID = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    SvcType = table.Column<string>(maxLength: 10, nullable: false, defaultValueSql: "''"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    PICName = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    PICID = table.Column<string>(maxLength: 200, nullable: true, defaultValueSql: "''"),
                    LocID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    CODFilePath = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    CODCreateDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERHDR", x => new { x.MSTRID, x.ScheduleID, x.WOID, x.ContractID, x.BizLocID });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERLOG",
                columns: table => new
                {
                    MSTRID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ScheduleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WorkerID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    VehicleID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    LogDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    Status = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(nullable: false, defaultValueSql: "newid()"),
                    TID = table.Column<int>(nullable: true),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "''"),
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
                    SubDest1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Remark1 = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 200, nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERLOG", x => new { x.MSTRID, x.ScheduleID, x.WorkerID, x.VehicleID, x.LogDate, x.Status });
                });

            migrationBuilder.CreateTable(
                name: "WORKORDERPERSON",
                columns: table => new
                {
                    WOID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "(0)"),
                    InitVehicleNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    VehicleNo = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    WorkerID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    LastUpdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Active = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    Inuse = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    Flag = table.Column<byte>(nullable: true, defaultValueSql: "(1)"),
                    rowguid = table.Column<Guid>(maxLength: 16, nullable: false, defaultValueSql: "newid()"),
                    SyncCreate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SyncLastUpd = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastSyncBy = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    IsHost = table.Column<byte>(nullable: true, defaultValueSql: "(0)"),
                    TID = table.Column<int>(nullable: true),
                    InitWorkerID = table.Column<string>(maxLength: 20, nullable: true, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKORDERPERSON", x => new { x.WOID, x.SeqNo });
                });

            migrationBuilder.CreateTable(
                name: "WORKRESULT",
                columns: table => new
                {
                    BatchCode = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    WID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SeqNo = table.Column<int>(nullable: false, defaultValueSql: "''"),
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
                    EmployeeID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    InspectStartDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    InspectEndDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "getdate()"),
                    ResultTitle = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    SubDest1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    SubDest2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    ImageRes1 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageRes2 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageRes3 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageSign1 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageSign2 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    ImageSign3 = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(1)"),
                    Rating = table.Column<int>(nullable: false, defaultValueSql: "(1)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    Remark2 = table.Column<string>(maxLength: 4000, nullable: true, defaultValueSql: "''"),
                    IsRedo = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    RefWID = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    AssignTo = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Qty = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    PackQty = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    ActualQty = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    ActualPackQty = table.Column<decimal>(nullable: true, defaultValueSql: "(0)"),
                    ActualQtyDepart = table.Column<decimal>(nullable: true),
                    ActualPackQtyDepart = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORKRESULT", x => new { x.BatchCode, x.WID, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANSWERGROUP");

            migrationBuilder.DropTable(
                name: "ANSWEROPT");

            migrationBuilder.DropTable(
                name: "ANSWEROPTGROUP");

            migrationBuilder.DropTable(
                name: "APPTRAIL");

            migrationBuilder.DropTable(
                name: "AREA");

            migrationBuilder.DropTable(
                name: "BIZCATEGORY");

            migrationBuilder.DropTable(
                name: "BIZDOCUMENT");

            migrationBuilder.DropTable(
                name: "BIZENTITY");

            migrationBuilder.DropTable(
                name: "BIZGROUP");

            migrationBuilder.DropTable(
                name: "BIZITEM");

            migrationBuilder.DropTable(
                name: "BIZLOCATE");

            migrationBuilder.DropTable(
                name: "BIZMEMBER");

            migrationBuilder.DropTable(
                name: "BIZREFERENCE");

            migrationBuilder.DropTable(
                name: "CAMPAIGNAFFILIATE");

            migrationBuilder.DropTable(
                name: "CAMPAIGNDOCUMENT");

            migrationBuilder.DropTable(
                name: "CAMPAIGNDTL");

            migrationBuilder.DropTable(
                name: "CAMPAIGNHDR");

            migrationBuilder.DropTable(
                name: "CAMPAIGNITEM");

            migrationBuilder.DropTable(
                name: "CAMPAIGNITEMSUPP");

            migrationBuilder.DropTable(
                name: "CAMPCOMMITTEE");

            migrationBuilder.DropTable(
                name: "CAMPDOC");

            migrationBuilder.DropTable(
                name: "CAMPDTL");

            migrationBuilder.DropTable(
                name: "CAMPHDR");

            migrationBuilder.DropTable(
                name: "CAMPITEM");

            migrationBuilder.DropTable(
                name: "CAMPITEMSUPP");

            migrationBuilder.DropTable(
                name: "CAMPLOT");

            migrationBuilder.DropTable(
                name: "CAMPLOTITEM");

            migrationBuilder.DropTable(
                name: "CAMPLOTPAX");

            migrationBuilder.DropTable(
                name: "CAMPPAX");

            migrationBuilder.DropTable(
                name: "CBXBIDDING");

            migrationBuilder.DropTable(
                name: "CITY");

            migrationBuilder.DropTable(
                name: "CODEMASTER");

            migrationBuilder.DropTable(
                name: "CODENUM");

            migrationBuilder.DropTable(
                name: "CONTRACTDOCUMENT");

            migrationBuilder.DropTable(
                name: "CONTRACTHDR");

            migrationBuilder.DropTable(
                name: "CONTRACTITEM");

            migrationBuilder.DropTable(
                name: "CONTRACTRESOURCE");

            migrationBuilder.DropTable(
                name: "CONTRACTSCOPESUM");

            migrationBuilder.DropTable(
                name: "COUNTRY");

            migrationBuilder.DropTable(
                name: "CURRENCY");

            migrationBuilder.DropTable(
                name: "CUSTOMER");

            migrationBuilder.DropTable(
                name: "DISTRICT");

            migrationBuilder.DropTable(
                name: "EMAIL");

            migrationBuilder.DropTable(
                name: "EMPBRANCH");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "IMAGEUPLOAD");

            migrationBuilder.DropTable(
                name: "IMPRESSION");

            migrationBuilder.DropTable(
                name: "IMPRESSIONPROGRESS");

            migrationBuilder.DropTable(
                name: "INSERVICEDTL");

            migrationBuilder.DropTable(
                name: "INSERVICEHDR");

            migrationBuilder.DropTable(
                name: "INSPECTCHECK");

            migrationBuilder.DropTable(
                name: "INVOICEDTL");

            migrationBuilder.DropTable(
                name: "INVOICEHDR");

            migrationBuilder.DropTable(
                name: "INVOICEHDR_CWMS");

            migrationBuilder.DropTable(
                name: "INVOICEHDR_OLD");

            migrationBuilder.DropTable(
                name: "INVOICEITEM");

            migrationBuilder.DropTable(
                name: "INVOICETAX");

            migrationBuilder.DropTable(
                name: "ITEM");

            migrationBuilder.DropTable(
                name: "ITEMCATEGORY");

            migrationBuilder.DropTable(
                name: "ITEMCOMBO");

            migrationBuilder.DropTable(
                name: "ITEMCOSTGRP");

            migrationBuilder.DropTable(
                name: "ITEMLOC");

            migrationBuilder.DropTable(
                name: "ITEMPRICE");

            migrationBuilder.DropTable(
                name: "ITEMPRICEHDR");

            migrationBuilder.DropTable(
                name: "ITEMSELLGRP");

            migrationBuilder.DropTable(
                name: "ITMTRANSDTL");

            migrationBuilder.DropTable(
                name: "ITMTRANSHDR");

            migrationBuilder.DropTable(
                name: "LICENSE");

            migrationBuilder.DropTable(
                name: "LOA");

            migrationBuilder.DropTable(
                name: "LOARULES");

            migrationBuilder.DropTable(
                name: "LOGEVENT");

            migrationBuilder.DropTable(
                name: "MOB_QUEST");

            migrationBuilder.DropTable(
                name: "PAYMENTDTL");

            migrationBuilder.DropTable(
                name: "PAYMENTHDR");

            migrationBuilder.DropTable(
                name: "PAYMENTLOG");

            migrationBuilder.DropTable(
                name: "PAYMENTTENDER");

            migrationBuilder.DropTable(
                name: "PBT");

            migrationBuilder.DropTable(
                name: "PFI");

            migrationBuilder.DropTable(
                name: "PROCTASK");

            migrationBuilder.DropTable(
                name: "PRODUCTISMUPLOAD");

            migrationBuilder.DropTable(
                name: "PROJECT");

            migrationBuilder.DropTable(
                name: "PROMOPOLICY");

            migrationBuilder.DropTable(
                name: "QUESTIONDTL");

            migrationBuilder.DropTable(
                name: "QUESTIONGROUP");

            migrationBuilder.DropTable(
                name: "QUESTIONHDR");

            migrationBuilder.DropTable(
                name: "QUESTIONITEM");

            migrationBuilder.DropTable(
                name: "QUESTIONPAX");

            migrationBuilder.DropTable(
                name: "QUESTIONPAXITEM");

            migrationBuilder.DropTable(
                name: "QUESTIONPAXSCORE");

            migrationBuilder.DropTable(
                name: "QUESTIONPAXSUM");

            migrationBuilder.DropTable(
                name: "SAP_ITEMPRICE");

            migrationBuilder.DropTable(
                name: "SCHEDULEDTL");

            migrationBuilder.DropTable(
                name: "SCHEDULEHDR");

            migrationBuilder.DropTable(
                name: "SCHEDULEITEM");

            migrationBuilder.DropTable(
                name: "STATE");

            migrationBuilder.DropTable(
                name: "STGAPPROVAL");

            migrationBuilder.DropTable(
                name: "SYSCODEB");

            migrationBuilder.DropTable(
                name: "SYSPREFB");

            migrationBuilder.DropTable(
                name: "SYSPREFT");

            migrationBuilder.DropTable(
                name: "SYSREPORT");

            migrationBuilder.DropTable(
                name: "TASKASSIGN");

            migrationBuilder.DropTable(
                name: "TASKLOG");

            migrationBuilder.DropTable(
                name: "TENDER");

            migrationBuilder.DropTable(
                name: "TENDERTYPE");

            migrationBuilder.DropTable(
                name: "TRANSCDHDR");

            migrationBuilder.DropTable(
                name: "TRANSCDITEM");

            migrationBuilder.DropTable(
                name: "TRANSDTL");

            migrationBuilder.DropTable(
                name: "TRANSFPX");

            migrationBuilder.DropTable(
                name: "TRANSHDR");

            migrationBuilder.DropTable(
                name: "TRANSTENDER");

            migrationBuilder.DropTable(
                name: "USRAPP");

            migrationBuilder.DropTable(
                name: "USRGROUP");

            migrationBuilder.DropTable(
                name: "USRPROFILE");

            migrationBuilder.DropTable(
                name: "USRVERIFY");

            migrationBuilder.DropTable(
                name: "VEHICLE");

            migrationBuilder.DropTable(
                name: "VEHICLEDOCUMENT");

            migrationBuilder.DropTable(
                name: "VOC_VOUCHER");

            migrationBuilder.DropTable(
                name: "WORKER");

            migrationBuilder.DropTable(
                name: "WORKORDERBIN");

            migrationBuilder.DropTable(
                name: "WORKORDERDTL");

            migrationBuilder.DropTable(
                name: "WORKORDERDTLLOG");

            migrationBuilder.DropTable(
                name: "WORKORDERHDR");

            migrationBuilder.DropTable(
                name: "WORKORDERLOG");

            migrationBuilder.DropTable(
                name: "WORKORDERPERSON");

            migrationBuilder.DropTable(
                name: "WORKRESULT");
        }
    }
}
