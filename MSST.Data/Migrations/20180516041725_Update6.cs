using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Supplier",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "Supplier",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Supplier",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "EmployeeUniversity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "EmployeeUniversity",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "EmployeeUniversity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "EmployeeUniversity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "EmployeeUniversity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "EmployeeMajor",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "EmployeeMajor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "EmployeeMajor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "EmployeeMajor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "EmployeeMajor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "EmployeeFaculty",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "EmployeeFaculty",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "EmployeeFaculty",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "EmployeeFaculty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "EmployeeFaculty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetWarrantyCompany",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetWarrantyCompany",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetWarrantyCompany",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetWarrantyCompany",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetWarrantyCompany",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetWarranty",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetWarranty",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetWarranty",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetWarranty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetWarranty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetUnit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetUnit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetUnit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetUnit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetUnit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetType",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetMaster",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetMaster",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetMaster",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetMaster",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetMaster",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetGroup",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetGroup",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetGroup",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetGroup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetGroup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "AssetCategory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "AssetCategory",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "AssetCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isDelete",
                table: "AssetCategory",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "EmployeeUniversity");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "EmployeeUniversity");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "EmployeeUniversity");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "EmployeeUniversity");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "EmployeeUniversity");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "EmployeeMajor");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "EmployeeMajor");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "EmployeeMajor");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "EmployeeMajor");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "EmployeeMajor");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetWarrantyCompany");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetWarrantyCompany");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetWarrantyCompany");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetWarrantyCompany");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetWarrantyCompany");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetWarranty");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetWarranty");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetWarranty");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetWarranty");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetWarranty");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetUnit");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetUnit");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetUnit");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetUnit");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetUnit");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetType");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetType");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetType");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetType");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetType");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetMaster");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetMaster");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetMaster");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetMaster");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetMaster");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetGroup");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetGroup");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetGroup");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetGroup");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetGroup");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetDetail");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetDetail");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetDetail");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetDetail");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetDetail");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "AssetCategory");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetCategory");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "AssetCategory");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AssetCategory");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "AssetCategory");
        }
    }
}
