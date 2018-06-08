using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetBrand_Asset_AssetId",
                table: "AssetBrand");

            migrationBuilder.DropIndex(
                name: "IX_AssetBrand_AssetId",
                table: "AssetBrand");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "AssetBrand");

            migrationBuilder.AddColumn<int>(
                name: "AssetBrandId",
                table: "Asset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetBrandId",
                table: "Asset",
                column: "AssetBrandId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_AssetBrand_AssetBrandId",
                table: "Asset",
                column: "AssetBrandId",
                principalTable: "AssetBrand",
                principalColumn: "AssetBrandId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_AssetBrand_AssetBrandId",
                table: "Asset");

            migrationBuilder.DropIndex(
                name: "IX_Asset_AssetBrandId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetBrandId",
                table: "Asset");

            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "AssetBrand",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssetBrand_AssetId",
                table: "AssetBrand",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetBrand_Asset_AssetId",
                table: "AssetBrand",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "AssetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
