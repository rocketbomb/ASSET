using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetDepreciation_AssetDepreciationId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetWarranty_AssetWarrantyId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetCategory_CategoryAssetCategoryId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetGroup_GroupAssetGroupId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Ownership_OwnershipId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetType_TypeAssetTypeId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetUnit_UnitAssetUnitId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetDepreciationId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetWarrantyId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_CategoryAssetCategoryId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_GroupAssetGroupId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_OwnershipId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_TypeAssetTypeId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_UnitAssetUnitId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetGroup");

            migrationBuilder.DropColumn(
                name: "CategoryAssetCategoryId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "GroupAssetGroupId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "TypeAssetTypeId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "UnitAssetUnitId",
                table: "Asset");

            migrationBuilder.AlterColumn<int>(
                name: "OwnershipId",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetWarrantyId",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetDepreciationId",
                table: "Asset",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetCategoryId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssetGroupId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssetTypeId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssetUnitId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetCategoryId",
                table: "Asset",
                column: "AssetCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetDepreciationId",
                table: "Asset",
                column: "AssetDepreciationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetGroupId",
                table: "Asset",
                column: "AssetGroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetUnitId",
                table: "Asset",
                column: "AssetUnitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetWarrantyId",
                table: "Asset",
                column: "AssetWarrantyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_OwnershipId",
                table: "Asset",
                column: "OwnershipId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetCategory_AssetCategoryId",
                table: "Asset",
                column: "AssetCategoryId",
                principalTable: "AssetCategory",
                principalColumn: "AssetCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetDepreciation_AssetDepreciationId",
                table: "Asset",
                column: "AssetDepreciationId",
                principalTable: "AssetDepreciation",
                principalColumn: "AssetDepreciationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetGroup_AssetGroupId",
                table: "Asset",
                column: "AssetGroupId",
                principalTable: "AssetGroup",
                principalColumn: "AssetGroupId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetType_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "AssetTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetUnit_AssetUnitId",
                table: "Asset",
                column: "AssetUnitId",
                principalTable: "AssetUnit",
                principalColumn: "AssetUnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetWarranty_AssetWarrantyId",
                table: "Asset",
                column: "AssetWarrantyId",
                principalTable: "AssetWarranty",
                principalColumn: "AssetWarrantyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Ownership_OwnershipId",
                table: "Asset",
                column: "OwnershipId",
                principalTable: "Ownership",
                principalColumn: "OwnershipId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetCategory_AssetCategoryId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetDepreciation_AssetDepreciationId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetGroup_AssetGroupId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetType_AssetTypeId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetUnit_AssetUnitId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetWarranty_AssetWarrantyId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset");

            migrationBuilder.DropForeignKey(
                name: "FK_Asset_Ownership_OwnershipId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetCategoryId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetDepreciationId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetGroupId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetUnitId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetWarrantyId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_OwnershipId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetCategoryId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetGroupId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetTypeId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetUnitId",
                table: "Asset");

            migrationBuilder.AddColumn<string>(
                name: "AssetId",
                table: "AssetGroup",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OwnershipId",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssetWarrantyId",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AssetDepreciationId",
                table: "Asset",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryAssetCategoryId",
                table: "Asset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupAssetGroupId",
                table: "Asset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeAssetTypeId",
                table: "Asset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitAssetUnitId",
                table: "Asset",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetDepreciationId",
                table: "Asset",
                column: "AssetDepreciationId",
                unique: true,
                filter: "[AssetDepreciationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetWarrantyId",
                table: "Asset",
                column: "AssetWarrantyId",
                unique: true,
                filter: "[AssetWarrantyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_CategoryAssetCategoryId",
                table: "Asset",
                column: "CategoryAssetCategoryId",
                unique: true,
                filter: "[CategoryAssetCategoryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_GroupAssetGroupId",
                table: "Asset",
                column: "GroupAssetGroupId",
                unique: true,
                filter: "[GroupAssetGroupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_OwnershipId",
                table: "Asset",
                column: "OwnershipId",
                unique: true,
                filter: "[OwnershipId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_TypeAssetTypeId",
                table: "Asset",
                column: "TypeAssetTypeId",
                unique: true,
                filter: "[TypeAssetTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_UnitAssetUnitId",
                table: "Asset",
                column: "UnitAssetUnitId",
                unique: true,
                filter: "[UnitAssetUnitId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetDepreciation_AssetDepreciationId",
                table: "Asset",
                column: "AssetDepreciationId",
                principalTable: "AssetDepreciation",
                principalColumn: "AssetDepreciationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetWarranty_AssetWarrantyId",
                table: "Asset",
                column: "AssetWarrantyId",
                principalTable: "AssetWarranty",
                principalColumn: "AssetWarrantyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetCategory_CategoryAssetCategoryId",
                table: "Asset",
                column: "CategoryAssetCategoryId",
                principalTable: "AssetCategory",
                principalColumn: "AssetCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetGroup_GroupAssetGroupId",
                table: "Asset",
                column: "GroupAssetGroupId",
                principalTable: "AssetGroup",
                principalColumn: "AssetGroupId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Location_LocationId",
                table: "Asset",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_Ownership_OwnershipId",
                table: "Asset",
                column: "OwnershipId",
                principalTable: "Ownership",
                principalColumn: "OwnershipId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetType_TypeAssetTypeId",
                table: "Asset",
                column: "TypeAssetTypeId",
                principalTable: "AssetType",
                principalColumn: "AssetTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetUnit_UnitAssetUnitId",
                table: "Asset",
                column: "UnitAssetUnitId",
                principalTable: "AssetUnit",
                principalColumn: "AssetUnitId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
