using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_CAMPLOTITEM_Table20200709 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAMPDOC",
                columns: table => new
                {
                    BizLocID = table.Column<string>(maxLength: 20, nullable: false),
                    BizRegID = table.Column<string>(maxLength: 20, nullable: false),
                    CampID = table.Column<string>(maxLength: 20, nullable: false),
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
                    DocumentNo = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
                    RefNo1 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    RefNo2 = table.Column<string>(maxLength: 20, nullable: false, defaultValueSql: "''"),
                    Name = table.Column<string>(maxLength: 50, nullable: false, defaultValueSql: "''"),
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
                    MaxAmt = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotMaxP = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    TotMax = table.Column<decimal>(nullable: false, defaultValueSql: "(0)"),
                    Remark = table.Column<string>(maxLength: 4000, nullable: false, defaultValueSql: "''"),
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "(0)"),
                    Posted = table.Column<byte>(nullable: false, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAMPLOTPAX", x => new { x.LotID, x.CampID, x.BizRegID, x.BizLocID, x.SeqNo });
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
