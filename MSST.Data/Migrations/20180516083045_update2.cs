using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetDepreciationId",
                table: "AssetMaster",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssetDepreciation",
                columns: table => new
                {
                    AssetDepreciationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssetAge = table.Column<double>(nullable: false),
                    AssetDetailId = table.Column<int>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AssetDepreciation_AssetDetail_AssetDetailId",
                        column: x => x.AssetDetailId,
                        principalTable: "AssetDetail",
                        principalColumn: "AssetDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetMaster_AssetDepreciationId",
                table: "AssetMaster",
                column: "AssetDepreciationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetDepreciation_AssetDetailId",
                table: "AssetDepreciation",
                column: "AssetDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetMaster_AssetDepreciation_AssetDepreciationId",
                table: "AssetMaster",
                column: "AssetDepreciationId",
                principalTable: "AssetDepreciation",
                principalColumn: "AssetDepreciationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetMaster_AssetDepreciation_AssetDepreciationId",
                table: "AssetMaster");

            migrationBuilder.DropTable(
                name: "AssetDepreciation");

            migrationBuilder.DropIndex(
                name: "IX_AssetMaster_AssetDepreciationId",
                table: "AssetMaster");

            migrationBuilder.DropColumn(
                name: "AssetDepreciationId",
                table: "AssetMaster");
        }
    }
}
