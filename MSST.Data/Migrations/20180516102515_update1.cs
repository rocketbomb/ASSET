using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetDepreciation",
                columns: table => new
                {
                    AssetDepreciationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetAge = table.Column<double>(nullable: false),
                    CalculatePrice = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    DayOffCalculate = table.Column<double>(nullable: false),
                    DepreciateOpen = table.Column<double>(nullable: false),
                    DepreciatePerDay = table.Column<double>(nullable: false),
                    DepreciateRatio = table.Column<double>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    RemainPrice = table.Column<double>(nullable: false),
                    Remark = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UsefulLife = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDepreciation", x => x.AssetDepreciationId);
                });

            migrationBuilder.CreateTable(
                name: "AssetGroup",
                columns: table => new
                {
                    AssetGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetWarrantyCompany", x => x.AssetWarrantyCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMajor",
                columns: table => new
                {
                    EmployeeMajorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMajor", x => x.EmployeeMajorId);
                });

            migrationBuilder.CreateTable(
                name: "LocationGroup",
                columns: table => new
                {
                    LocationGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationGroup", x => x.LocationGroupId);
                });

            migrationBuilder.CreateTable(
                name: "SupplierGroup",
                columns: table => new
                {
                    SupplierGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierGroup", x => x.SupplierGroupId);
                });

            migrationBuilder.CreateTable(
                name: "AssetWarranty",
                columns: table => new
                {
                    AssetWarrantyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ContractNumber = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    PolicyNumber = table.Column<string>(nullable: true),
                    Premium = table.Column<double>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    Telphone = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
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
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    MajorEmployeeMajorId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeMajor_MajorEmployeeMajorId",
                        column: x => x.MajorEmployeeMajorId,
                        principalTable: "EmployeeMajor",
                        principalColumn: "EmployeeMajorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFaculty",
                columns: table => new
                {
                    EmployeeFacultyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    MajorEmployeeMajorId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFaculty", x => x.EmployeeFacultyId);
                    table.ForeignKey(
                        name: "FK_EmployeeFaculty_EmployeeMajor_MajorEmployeeMajorId",
                        column: x => x.MajorEmployeeMajorId,
                        principalTable: "EmployeeMajor",
                        principalColumn: "EmployeeMajorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Barcode = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    LocationGroupId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_LocationGroup_LocationGroupId",
                        column: x => x.LocationGroupId,
                        principalTable: "LocationGroup",
                        principalColumn: "LocationGroupId",
                        onDelete: ReferentialAction.Restrict);
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
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SupplierGroupId = table.Column<int>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Supplier_SupplierGroup_SupplierGroupId",
                        column: x => x.SupplierGroupId,
                        principalTable: "SupplierGroup",
                        principalColumn: "SupplierGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeUniversity",
                columns: table => new
                {
                    EmployeeUniversityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    FacultyEmployeeFacultyId = table.Column<int>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUniversity", x => x.EmployeeUniversityId);
                    table.ForeignKey(
                        name: "FK_EmployeeUniversity_EmployeeFaculty_FacultyEmployeeFacultyId",
                        column: x => x.FacultyEmployeeFacultyId,
                        principalTable: "EmployeeFaculty",
                        principalColumn: "EmployeeFacultyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ownership",
                columns: table => new
                {
                    OwnershipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    EmployeeFacultyId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    EmployeeMajorId = table.Column<int>(nullable: true),
                    EmployeeUniversityId = table.Column<int>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ownership", x => x.OwnershipId);
                    table.ForeignKey(
                        name: "FK_Ownership_EmployeeFaculty_EmployeeFacultyId",
                        column: x => x.EmployeeFacultyId,
                        principalTable: "EmployeeFaculty",
                        principalColumn: "EmployeeFacultyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ownership_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ownership_EmployeeMajor_EmployeeMajorId",
                        column: x => x.EmployeeMajorId,
                        principalTable: "EmployeeMajor",
                        principalColumn: "EmployeeMajorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ownership_EmployeeUniversity_EmployeeUniversityId",
                        column: x => x.EmployeeUniversityId,
                        principalTable: "EmployeeUniversity",
                        principalColumn: "EmployeeUniversityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetDetail",
                columns: table => new
                {
                    AssetDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetDepreciationId = table.Column<int>(nullable: true),
                    AssetWarrantyId = table.Column<int>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    EmployeeFacultyId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    EmployeeMajorId = table.Column<int>(nullable: true),
                    EmployeeUniversityId = table.Column<int>(nullable: true),
                    GroupAssetGroupId = table.Column<int>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    OldCode = table.Column<string>(nullable: true),
                    OwnershipId = table.Column<int>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    TypeAssetTypeId = table.Column<int>(nullable: true),
                    UnitAssetUnitId = table.Column<int>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetDetail", x => x.AssetDetailId);
                    table.ForeignKey(
                        name: "FK_AssetDetail_AssetDepreciation_AssetDepreciationId",
                        column: x => x.AssetDepreciationId,
                        principalTable: "AssetDepreciation",
                        principalColumn: "AssetDepreciationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_AssetWarranty_AssetWarrantyId",
                        column: x => x.AssetWarrantyId,
                        principalTable: "AssetWarranty",
                        principalColumn: "AssetWarrantyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_EmployeeFaculty_EmployeeFacultyId",
                        column: x => x.EmployeeFacultyId,
                        principalTable: "EmployeeFaculty",
                        principalColumn: "EmployeeFacultyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_EmployeeMajor_EmployeeMajorId",
                        column: x => x.EmployeeMajorId,
                        principalTable: "EmployeeMajor",
                        principalColumn: "EmployeeMajorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_EmployeeUniversity_EmployeeUniversityId",
                        column: x => x.EmployeeUniversityId,
                        principalTable: "EmployeeUniversity",
                        principalColumn: "EmployeeUniversityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_AssetGroup_GroupAssetGroupId",
                        column: x => x.GroupAssetGroupId,
                        principalTable: "AssetGroup",
                        principalColumn: "AssetGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetDetail_Ownership_OwnershipId",
                        column: x => x.OwnershipId,
                        principalTable: "Ownership",
                        principalColumn: "OwnershipId",
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
                name: "AssetCategory",
                columns: table => new
                {
                    AssetCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetDetailId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_AssetCategory_AssetDetailId",
                table: "AssetCategory",
                column: "AssetDetailId",
                unique: true,
                filter: "[AssetDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_AssetDepreciationId",
                table: "AssetDetail",
                column: "AssetDepreciationId",
                unique: true,
                filter: "[AssetDepreciationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_AssetWarrantyId",
                table: "AssetDetail",
                column: "AssetWarrantyId",
                unique: true,
                filter: "[AssetWarrantyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_EmployeeFacultyId",
                table: "AssetDetail",
                column: "EmployeeFacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_EmployeeId",
                table: "AssetDetail",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_EmployeeMajorId",
                table: "AssetDetail",
                column: "EmployeeMajorId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_EmployeeUniversityId",
                table: "AssetDetail",
                column: "EmployeeUniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_GroupAssetGroupId",
                table: "AssetDetail",
                column: "GroupAssetGroupId",
                unique: true,
                filter: "[GroupAssetGroupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_LocationId",
                table: "AssetDetail",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDetail_OwnershipId",
                table: "AssetDetail",
                column: "OwnershipId",
                unique: true,
                filter: "[OwnershipId] IS NOT NULL");

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
                name: "IX_AssetWarranty_WarrantyCompanyAssetWarrantyCompanyId",
                table: "AssetWarranty",
                column: "WarrantyCompanyAssetWarrantyCompanyId",
                unique: true,
                filter: "[WarrantyCompanyAssetWarrantyCompanyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MajorEmployeeMajorId",
                table: "Employee",
                column: "MajorEmployeeMajorId",
                unique: true,
                filter: "[MajorEmployeeMajorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFaculty_MajorEmployeeMajorId",
                table: "EmployeeFaculty",
                column: "MajorEmployeeMajorId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUniversity_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity",
                column: "FacultyEmployeeFacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocationGroupId",
                table: "Location",
                column: "LocationGroupId",
                unique: true,
                filter: "[LocationGroupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_EmployeeFacultyId",
                table: "Ownership",
                column: "EmployeeFacultyId",
                unique: true,
                filter: "[EmployeeFacultyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_EmployeeId",
                table: "Ownership",
                column: "EmployeeId",
                unique: true,
                filter: "[EmployeeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_EmployeeMajorId",
                table: "Ownership",
                column: "EmployeeMajorId",
                unique: true,
                filter: "[EmployeeMajorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_EmployeeUniversityId",
                table: "Ownership",
                column: "EmployeeUniversityId",
                unique: true,
                filter: "[EmployeeUniversityId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_SupplierGroupId",
                table: "Supplier",
                column: "SupplierGroupId",
                unique: true,
                filter: "[SupplierGroupId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetCategory");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "AssetDetail");

            migrationBuilder.DropTable(
                name: "SupplierGroup");

            migrationBuilder.DropTable(
                name: "AssetDepreciation");

            migrationBuilder.DropTable(
                name: "AssetWarranty");

            migrationBuilder.DropTable(
                name: "AssetGroup");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Ownership");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "AssetUnit");

            migrationBuilder.DropTable(
                name: "AssetWarrantyCompany");

            migrationBuilder.DropTable(
                name: "LocationGroup");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeUniversity");

            migrationBuilder.DropTable(
                name: "EmployeeFaculty");

            migrationBuilder.DropTable(
                name: "EmployeeMajor");
        }
    }
}
