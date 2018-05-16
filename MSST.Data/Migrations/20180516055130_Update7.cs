using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetCategory");

            migrationBuilder.DropTable(
                name: "AssetMaster");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeUniversity");

            migrationBuilder.DropTable(
                name: "AssetDetail");

            migrationBuilder.DropTable(
                name: "AssetWarranty");

            migrationBuilder.DropTable(
                name: "EmployeeFaculty");

            migrationBuilder.DropTable(
                name: "AssetGroup");

            migrationBuilder.DropTable(
                name: "AssetType");

            migrationBuilder.DropTable(
                name: "AssetUnit");

            migrationBuilder.DropTable(
                name: "AssetWarrantyCompany");

            migrationBuilder.DropTable(
                name: "EmployeeMajor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Base");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Base",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Base",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Base",
                newName: "Supplier_Name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Base",
                newName: "Supplier_Email");

            migrationBuilder.RenameColumn(
                name: "ContactPerson",
                table: "Base",
                newName: "Supplier_ContactPerson");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Base",
                newName: "Supplier_ContactNumber");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Base",
                newName: "Supplier_Code");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Base",
                newName: "Supplier_Address");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Base",
                newName: "SupplierId1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Base",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId1",
                table: "Base",
                nullable: true,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "Base",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "AssetUnitBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetWarrantyCompanyBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Base",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeFacultyBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetCategoryId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetDetailBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetDetailId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetDetail_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEng",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameThai",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OldCode",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNo",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetGroupId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetGroup_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetGroup_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetMaster_AssetDetailBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetMasterId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetWarrantyBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetTypeId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetType_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetType_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetUnitId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetUnit_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetUnit_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetWarrantyId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContractNumber",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PolicyNumber",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Premium",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telphone",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoucherNumber",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WarrantyCompanyBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarrantyDuration",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WarrantyEnd",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WarrantyStart",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetWarrantyCompany_Address",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetWarrantyCompanyId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetWarrantyCompany_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetWarrantyCompany_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee_Address",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee_ContactNumber",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee_ContactPerson",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee_Email",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MajorBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Employee_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFaculty_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeFacultyId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeFaculty_MajorBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeFaculty_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMajor_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeMajorId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeMajor_Name",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeUniversity_Code",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeUniversityId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FacultyBaseId",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeUniversity_NameEng",
                table: "Base",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeUniversity_NameThai",
                table: "Base",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Base",
                table: "Base",
                column: "BaseId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_AssetUnitBaseId",
                table: "Base",
                column: "AssetUnitBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_AssetWarrantyCompanyBaseId",
                table: "Base",
                column: "AssetWarrantyCompanyBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_EmployeeBaseId",
                table: "Base",
                column: "EmployeeBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_EmployeeFacultyBaseId",
                table: "Base",
                column: "EmployeeFacultyBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_AssetDetailBaseId",
                table: "Base",
                column: "AssetDetailBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_GroupBaseId",
                table: "Base",
                column: "GroupBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_TypeBaseId",
                table: "Base",
                column: "TypeBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_UnitBaseId",
                table: "Base",
                column: "UnitBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_AssetMaster_AssetDetailBaseId",
                table: "Base",
                column: "AssetMaster_AssetDetailBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_AssetWarrantyBaseId",
                table: "Base",
                column: "AssetWarrantyBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_WarrantyCompanyBaseId",
                table: "Base",
                column: "WarrantyCompanyBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_MajorBaseId",
                table: "Base",
                column: "MajorBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_EmployeeFaculty_MajorBaseId",
                table: "Base",
                column: "EmployeeFaculty_MajorBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_FacultyBaseId",
                table: "Base",
                column: "FacultyBaseId",
                principalTable: "Base",
                principalColumn: "BaseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_AssetUnitBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_AssetWarrantyCompanyBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_EmployeeBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_EmployeeFacultyBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_AssetDetailBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_GroupBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_TypeBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_UnitBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_AssetMaster_AssetDetailBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_AssetWarrantyBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_WarrantyCompanyBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_MajorBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_EmployeeFaculty_MajorBaseId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_FacultyBaseId",
                table: "Base");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Base",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_AssetUnitBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_AssetWarrantyCompanyBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_EmployeeBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_EmployeeFacultyBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_AssetDetailBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_GroupBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_TypeBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_UnitBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_AssetMaster_AssetDetailBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_AssetWarrantyBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_WarrantyCompanyBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_MajorBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_EmployeeFaculty_MajorBaseId",
                table: "Base");

            migrationBuilder.DropIndex(
                name: "IX_Base_FacultyBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetUnitBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyCompanyBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeFacultyBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetCategoryId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetDetailBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetDetailId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetDetail_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "GroupBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "NameEng",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "NameThai",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "OldCode",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "SerialNo",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "TypeBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "UnitBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetGroupId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetGroup_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetGroup_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetMaster_AssetDetailBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetMasterId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetTypeId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetType_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetType_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetUnitId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetUnit_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetUnit_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "ContractNumber",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "PolicyNumber",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Telphone",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "VoucherNumber",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "WarrantyCompanyBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "WarrantyDuration",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "WarrantyEnd",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "WarrantyStart",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyCompany_Address",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyCompanyId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyCompany_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "AssetWarrantyCompany_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Employee_Address",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Employee_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Employee_ContactNumber",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Employee_ContactPerson",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Employee_Email",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "MajorBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Employee_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeFaculty_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeFacultyId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeFaculty_MajorBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeFaculty_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeMajor_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeMajorId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeMajor_Name",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeUniversity_Code",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeUniversityId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "FacultyBaseId",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeUniversity_NameEng",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "EmployeeUniversity_NameThai",
                table: "Base");

            migrationBuilder.RenameTable(
                name: "Base",
                newName: "Supplier");

            migrationBuilder.RenameColumn(
                name: "SupplierId1",
                table: "Supplier",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "Supplier_Name",
                table: "Supplier",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Supplier_Email",
                table: "Supplier",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Supplier_ContactPerson",
                table: "Supplier",
                newName: "ContactPerson");

            migrationBuilder.RenameColumn(
                name: "Supplier_ContactNumber",
                table: "Supplier",
                newName: "ContactNumber");

            migrationBuilder.RenameColumn(
                name: "Supplier_Code",
                table: "Supplier",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "Supplier_Address",
                table: "Supplier",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Supplier",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Supplier",
                newName: "isActive");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Supplier",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Supplier",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "SupplierId");

            migrationBuilder.CreateTable(
                name: "AssetGroup",
                columns: table => new
                {
                    AssetGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMajor", x => x.EmployeeMajorId);
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    GroupAssetGroupId = table.Column<int>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    OldCode = table.Column<string>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    TypeAssetTypeId = table.Column<int>(nullable: true),
                    UnitAssetUnitId = table.Column<int>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    PolicyNumber = table.Column<string>(nullable: true),
                    Premium = table.Column<double>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    Telphone = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    VoucherNumber = table.Column<string>(nullable: true),
                    WarrantyCompanyAssetWarrantyCompanyId = table.Column<int>(nullable: true),
                    WarrantyDuration = table.Column<string>(nullable: true),
                    WarrantyEnd = table.Column<DateTime>(nullable: false),
                    WarrantyStart = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MajorEmployeeMajorId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    MajorEmployeeMajorId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                name: "AssetCategory",
                columns: table => new
                {
                    AssetCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetDetailId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
                    AssetWarrantyId = table.Column<int>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "EmployeeUniversity",
                columns: table => new
                {
                    EmployeeUniversityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    FacultyEmployeeFacultyId = table.Column<int>(nullable: true),
                    NameEng = table.Column<string>(nullable: true),
                    NameThai = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    isActive = table.Column<int>(nullable: false),
                    isDelete = table.Column<int>(nullable: false)
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
        }
    }
}
