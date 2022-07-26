using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Plexform.Migrations
{
    public partial class Added_PFI_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Status = table.Column<byte>(nullable: false, defaultValueSql: "''")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFI", x => new { x.BatchCode, x.SeqNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PFI");
        }
    }
}
