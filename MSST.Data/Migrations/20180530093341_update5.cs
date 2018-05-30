using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFaculty_EmployeeUniversity_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "UniversityEmployeeUniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "EmployeeFaculty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFaculty_UniversityId",
                table: "EmployeeFaculty",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFaculty_EmployeeUniversity_UniversityId",
                table: "EmployeeFaculty",
                column: "UniversityId",
                principalTable: "EmployeeUniversity",
                principalColumn: "EmployeeUniversityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFaculty_EmployeeUniversity_UniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeFaculty_UniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.AddColumn<int>(
                name: "UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                column: "UniversityEmployeeUniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFaculty_EmployeeUniversity_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                column: "UniversityEmployeeUniversityId",
                principalTable: "EmployeeUniversity",
                principalColumn: "EmployeeUniversityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
