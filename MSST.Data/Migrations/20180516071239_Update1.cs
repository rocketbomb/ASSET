using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Base",
                columns: table => new
                {
                    BaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetUnitBaseId = table.Column<int>(nullable: true),
                    AssetWarrantyCompanyBaseId = table.Column<int>(nullable: true),
                    CreateBy = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    EmployeeBaseId = table.Column<int>(nullable: true),
                    EmployeeFacultyBaseId = table.Column<int>(nullable: true),
                    IsActive = table.Column<int>(nullable: false),
                    IsDelete = table.Column<int>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    AssetCategoryId = table.Column<int>(nullable: true),
                    AssetDetailBaseId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AssetDetailId = table.Column<int>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    AssetDetail_Code = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    GroupBaseId = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    OldCode = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    TypeBaseId = table.Column<int>(nullable: true),
                    UnitBaseId = table.Column<int>(nullable: true),
                    AssetGroupId = table.Column<int>(nullable: true),
                    AssetId = table.Column<string>(nullable: true),
                    AssetGroup_Code = table.Column<string>(nullable: true),
                    AssetGroup_Name = table.Column<string>(nullable: true),
                    AssetMaster_AssetDetailBaseId = table.Column<int>(nullable: true),
                    AssetMasterId = table.Column<int>(nullable: true),
                    AssetWarrantyBaseId = table.Column<int>(nullable: true),
                    AssetTypeId = table.Column<int>(nullable: true),
                    AssetType_Code = table.Column<string>(nullable: true),
                    AssetType_Name = table.Column<string>(nullable: true),
                    AssetUnitId = table.Column<int>(nullable: true),
                    AssetUnit_Code = table.Column<string>(nullable: true),
                    AssetUnit_Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AssetWarrantyId = table.Column<int>(nullable: true),
                    ContractNumber = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    PolicyNumber = table.Column<string>(nullable: true),
                    Premium = table.Column<double>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true),
                    Telphone = table.Column<string>(nullable: true),
                    VoucherNumber = table.Column<string>(nullable: true),
                    WarrantyCompanyBaseId = table.Column<int>(nullable: true),
                    WarrantyDuration = table.Column<string>(nullable: true),
                    WarrantyEnd = table.Column<DateTime>(nullable: true),
                    WarrantyStart = table.Column<DateTime>(nullable: true),
                    AssetWarrantyCompany_Address = table.Column<string>(nullable: true),
                    AssetWarrantyCompanyId = table.Column<int>(nullable: true),
                    AssetWarrantyCompany_Code = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AssetWarrantyCompany_Name = table.Column<string>(nullable: true),
                    Employee_Address = table.Column<string>(nullable: true),
                    Employee_Code = table.Column<string>(nullable: true),
                    Employee_ContactNumber = table.Column<string>(nullable: true),
                    Employee_ContactPerson = table.Column<string>(nullable: true),
                    Employee_Email = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    MajorBaseId = table.Column<int>(nullable: true),
                    Employee_Name = table.Column<string>(nullable: true),
                    EmployeeFaculty_Code = table.Column<string>(nullable: true),
                    EmployeeFacultyId = table.Column<int>(nullable: true),
                    EmployeeFaculty_MajorBaseId = table.Column<int>(nullable: true),
                    EmployeeFaculty_Name = table.Column<string>(nullable: true),
                    EmployeeMajor_Code = table.Column<string>(nullable: true),
                    EmployeeMajorId = table.Column<int>(nullable: true),
                    EmployeeMajor_Name = table.Column<string>(nullable: true),
                    EmployeeUniversity_Code = table.Column<string>(nullable: true),
                    EmployeeUniversityId = table.Column<int>(nullable: true),
                    FacultyBaseId = table.Column<int>(nullable: true),
                    EmployeeUniversity_NameEng = table.Column<string>(nullable: true),
                    EmployeeUniversity_NameThai = table.Column<string>(nullable: true),
                    Supplier_Address = table.Column<string>(nullable: true),
                    Supplier_Code = table.Column<string>(nullable: true),
                    Supplier_ContactNumber = table.Column<string>(nullable: true),
                    Supplier_ContactPerson = table.Column<string>(nullable: true),
                    Supplier_Email = table.Column<string>(nullable: true),
                    Supplier_Name = table.Column<string>(nullable: true),
                    SupplierId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Base", x => x.BaseId);
                    table.ForeignKey(
                        name: "FK_Base_Base_AssetUnitBaseId",
                        column: x => x.AssetUnitBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_AssetWarrantyCompanyBaseId",
                        column: x => x.AssetWarrantyCompanyBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_EmployeeBaseId",
                        column: x => x.EmployeeBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_EmployeeFacultyBaseId",
                        column: x => x.EmployeeFacultyBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_AssetDetailBaseId",
                        column: x => x.AssetDetailBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_GroupBaseId",
                        column: x => x.GroupBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_TypeBaseId",
                        column: x => x.TypeBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_UnitBaseId",
                        column: x => x.UnitBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_AssetMaster_AssetDetailBaseId",
                        column: x => x.AssetMaster_AssetDetailBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_AssetWarrantyBaseId",
                        column: x => x.AssetWarrantyBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_WarrantyCompanyBaseId",
                        column: x => x.WarrantyCompanyBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_MajorBaseId",
                        column: x => x.MajorBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_EmployeeFaculty_MajorBaseId",
                        column: x => x.EmployeeFaculty_MajorBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Base_Base_FacultyBaseId",
                        column: x => x.FacultyBaseId,
                        principalTable: "Base",
                        principalColumn: "BaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Base_AssetUnitBaseId",
                table: "Base",
                column: "AssetUnitBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_AssetWarrantyCompanyBaseId",
                table: "Base",
                column: "AssetWarrantyCompanyBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_EmployeeBaseId",
                table: "Base",
                column: "EmployeeBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_EmployeeFacultyBaseId",
                table: "Base",
                column: "EmployeeFacultyBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_AssetDetailBaseId",
                table: "Base",
                column: "AssetDetailBaseId",
                unique: true,
                filter: "[AssetDetailBaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Base_GroupBaseId",
                table: "Base",
                column: "GroupBaseId",
                unique: true,
                filter: "[GroupBaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Base_TypeBaseId",
                table: "Base",
                column: "TypeBaseId",
                unique: true,
                filter: "[TypeBaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Base_UnitBaseId",
                table: "Base",
                column: "UnitBaseId",
                unique: true,
                filter: "[UnitBaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Base_AssetMaster_AssetDetailBaseId",
                table: "Base",
                column: "AssetMaster_AssetDetailBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_AssetWarrantyBaseId",
                table: "Base",
                column: "AssetWarrantyBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_WarrantyCompanyBaseId",
                table: "Base",
                column: "WarrantyCompanyBaseId",
                unique: true,
                filter: "[WarrantyCompanyBaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Base_MajorBaseId",
                table: "Base",
                column: "MajorBaseId",
                unique: true,
                filter: "[MajorBaseId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Base_EmployeeFaculty_MajorBaseId",
                table: "Base",
                column: "EmployeeFaculty_MajorBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Base_FacultyBaseId",
                table: "Base",
                column: "FacultyBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Base");
        }
    }
}
