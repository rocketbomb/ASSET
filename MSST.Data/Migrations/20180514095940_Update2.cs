using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Warrantys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Institue");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institue",
                table: "Institue",
                column: "InstitueId");

            migrationBuilder.CreateTable(
                name: "AssetGroup",
                columns: table => new
                {
                    AssetGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetGroup", x => x.AssetGroupId);
                });

            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    AssetTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.AssetTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AssetUnit",
                columns: table => new
                {
                    AssetUnitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetUnit", x => x.AssetUnitId);
                });

            migrationBuilder.CreateTable(
                name: "AssetWarrantyCompany",
                columns: table => new
                {
                    AssetWarrantyCompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetWarrantyCompany", x => x.AssetWarrantyCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DivisionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UniversityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyId);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    MajorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    FacultyId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.MajorId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    UniversityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.UniversityId);
                });

            migrationBuilder.CreateTable(
                name: "AssetDetail",
                columns: table => new
                {
                    AssetDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    GroupAssetGroupId = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    OldCode = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    TypeAssetTypeId = table.Column<int>(nullable: true),
                    UnitAssetUnitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDetail", x => x.AssetDetailId);
                    table.ForeignKey(
                        name: "FK_AssetDetail_AssetGroup_GroupAssetGroupId",
                        column: x => x.GroupAssetGroupId,
                        principalTable: "AssetGroup",
                        principalColumn: "AssetGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_AssetType_TypeAssetTypeId",
                        column: x => x.TypeAssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "AssetTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_AssetUnit_UnitAssetUnitId",
                        column: x => x.UnitAssetUnitId,
                        principalTable: "AssetUnit",
                        principalColumn: "AssetUnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetWarranty",
                columns: table => new
                {
                    AssetWarrantyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ContractNumber = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    PolicyNumber = table.Column<string>(nullable: true),
                    Premium = table.Column<double>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    Telphone = table.Column<string>(nullable: true),
                    VoucherNumber = table.Column<string>(nullable: true),
                    WarrantyCompanyAssetWarrantyCompanyId = table.Column<int>(nullable: true),
                    WarrantyDuration = table.Column<string>(nullable: true),
                    WarrantyEnd = table.Column<DateTime>(nullable: false),
                    WarrantyStart = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetWarranty", x => x.AssetWarrantyId);
                    table.ForeignKey(
                        name: "FK_AssetWarranty_AssetWarrantyCompany_WarrantyCompanyAssetWarrantyCompanyId",
                        column: x => x.WarrantyCompanyAssetWarrantyCompanyId,
                        principalTable: "AssetWarrantyCompany",
                        principalColumn: "AssetWarrantyCompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    DepartmentId1 = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId1",
                        column: x => x.DepartmentId1,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetCategory",
                columns: table => new
                {
                    AssetCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetDetailId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetCategory", x => x.AssetCategoryId);
                    table.ForeignKey(
                        name: "FK_AssetCategory_AssetDetail_AssetDetailId",
                        column: x => x.AssetDetailId,
                        principalTable: "AssetDetail",
                        principalColumn: "AssetDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetMaster",
                columns: table => new
                {
                    AssetMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetDetailId = table.Column<int>(nullable: true),
                    AssetWarrantyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetMaster", x => x.AssetMasterId);
                    table.ForeignKey(
                        name: "FK_AssetMaster_AssetDetail_AssetDetailId",
                        column: x => x.AssetDetailId,
                        principalTable: "AssetDetail",
                        principalColumn: "AssetDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetMaster_AssetWarranty_AssetWarrantyId",
                        column: x => x.AssetWarrantyId,
                        principalTable: "AssetWarranty",
                        principalColumn: "AssetWarrantyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategory_AssetDetailId",
                table: "AssetCategory",
                column: "AssetDetailId",
                unique: true,
                filter: "[AssetDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_GroupAssetGroupId",
                table: "AssetDetail",
                column: "GroupAssetGroupId",
                unique: true,
                filter: "[GroupAssetGroupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_TypeAssetTypeId",
                table: "AssetDetail",
                column: "TypeAssetTypeId",
                unique: true,
                filter: "[TypeAssetTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_UnitAssetUnitId",
                table: "AssetDetail",
                column: "UnitAssetUnitId",
                unique: true,
                filter: "[UnitAssetUnitId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetMaster_AssetDetailId",
                table: "AssetMaster",
                column: "AssetDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetMaster_AssetWarrantyId",
                table: "AssetMaster",
                column: "AssetWarrantyId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetWarranty_WarrantyCompanyAssetWarrantyCompanyId",
                table: "AssetWarranty",
                column: "WarrantyCompanyAssetWarrantyCompanyId",
                unique: true,
                filter: "[WarrantyCompanyAssetWarrantyCompanyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId1",
                table: "Employee",
                column: "DepartmentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetCategory");

            migrationBuilder.DropTable(
                name: "AssetMaster");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "AssetDetail");

            migrationBuilder.DropTable(
                name: "AssetWarranty");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "AssetGroup");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "AssetUnit");

            migrationBuilder.DropTable(
                name: "AssetWarrantyCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institue",
                table: "Institue");

            migrationBuilder.RenameTable(
                name: "Institue",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "InstitueId");

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
    }
}
