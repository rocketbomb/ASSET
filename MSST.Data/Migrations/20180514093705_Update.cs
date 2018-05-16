using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Companies",
                newName: "InstitueId");

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    AssetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    OldCode = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    UnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.AssetId);
                });

            migrationBuilder.CreateTable(
                name: "Warrantys",
                columns: table => new
                {
                    WarrantyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    AssetId = table.Column<int>(nullable: false),
                    ContractNumber = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    PolicyNumber = table.Column<string>(nullable: true),
                    Premium = table.Column<double>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    Telphone = table.Column<string>(nullable: true),
                    VoucherNumber = table.Column<string>(nullable: true),
                    WarrantyCompanyId = table.Column<int>(nullable: false),
                    WarrantyDuration = table.Column<string>(nullable: true),
                    WarrantyEnd = table.Column<DateTime>(nullable: false),
                    WarrantyStart = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warrantys", x => x.WarrantyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Warrantys");

            migrationBuilder.RenameColumn(
                name: "InstitueId",
                table: "Companies",
                newName: "CompanyId");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    OldCode = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }
    }
}
