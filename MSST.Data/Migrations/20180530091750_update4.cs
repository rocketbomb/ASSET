using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                column: "UniversityEmployeeUniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFaculty_UniversityEmployeeUniversityId",
                table: "EmployeeFaculty",
                column: "UniversityEmployeeUniversityId",
                unique: true,
                filter: "[UniversityEmployeeUniversityId] IS NOT NULL");
        }
    }
}
