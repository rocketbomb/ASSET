using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeUniversity_EmployeeFaculty_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeUniversity_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity");

            migrationBuilder.DropColumn(
                name: "FacultyEmployeeFacultyId",
                table: "EmployeeUniversity");

            migrationBuilder.AddColumn<int>(
                name: "UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                column: "UniversityEmployeeUniversityId",
                unique: true,
                filter: "[UniversityEmployeeUniversityId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFaculty_EmployeeUniversity_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                column: "UniversityEmployeeUniversityId",
                principalTable: "EmployeeUniversity",
                principalColumn: "EmployeeUniversityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FacultyEmployeeFacultyId",
                table: "EmployeeUniversity",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeUniversity_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity",
                column: "FacultyEmployeeFacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeUniversity_EmployeeFaculty_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity",
                column: "FacultyEmployeeFacultyId",
                principalTable: "EmployeeFaculty",
                principalColumn: "EmployeeFacultyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
