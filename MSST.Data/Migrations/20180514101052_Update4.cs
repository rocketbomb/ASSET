using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Major_MajorEmployeeMajorId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_Major_MajorEmployeeMajorId",
                table: "Faculty");

            migrationBuilder.DropForeignKey(
                name: "FK_University_Faculty_FacultyEmployeeFacultyId",
                table: "University");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_University",
                table: "University");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Major",
                table: "Major");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty");

            migrationBuilder.RenameTable(
                name: "University",
                newName: "EmployeeUniversity");

            migrationBuilder.RenameTable(
                name: "Major",
                newName: "EmployeeMajor");

            migrationBuilder.RenameTable(
                name: "Faculty",
                newName: "EmployeeFaculty");

            migrationBuilder.RenameIndex(
                name: "IX_University_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity",
                newName: "IX_EmployeeUniversity_FacultyEmployeeFacultyId");

            migrationBuilder.RenameIndex(
                name: "IX_Faculty_MajorEmployeeMajorId",
                table: "EmployeeFaculty",
                newName: "IX_EmployeeFaculty_MajorEmployeeMajorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeUniversity",
                table: "EmployeeUniversity",
                column: "EmployeeUniversityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeMajor",
                table: "EmployeeMajor",
                column: "EmployeeMajorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeFaculty",
                table: "EmployeeFaculty",
                column: "EmployeeFacultyId");

            migrationBuilder.CreateTable(
                name: "EmployeeDepartment",
                columns: table => new
                {
                    EmployeeDepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DivisionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDepartment", x => x.EmployeeDepartmentId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeMajor_MajorEmployeeMajorId",
                table: "Employee",
                column: "MajorEmployeeMajorId",
                principalTable: "EmployeeMajor",
                principalColumn: "EmployeeMajorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeFaculty_EmployeeMajor_MajorEmployeeMajorId",
                table: "EmployeeFaculty",
                column: "MajorEmployeeMajorId",
                principalTable: "EmployeeMajor",
                principalColumn: "EmployeeMajorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeUniversity_EmployeeFaculty_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity",
                column: "FacultyEmployeeFacultyId",
                principalTable: "EmployeeFaculty",
                principalColumn: "EmployeeFacultyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeMajor_MajorEmployeeMajorId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeFaculty_EmployeeMajor_MajorEmployeeMajorId",
                table: "EmployeeFaculty");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeUniversity_EmployeeFaculty_FacultyEmployeeFacultyId",
                table: "EmployeeUniversity");

            migrationBuilder.DropTable(
                name: "EmployeeDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeUniversity",
                table: "EmployeeUniversity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeMajor",
                table: "EmployeeMajor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeFaculty",
                table: "EmployeeFaculty");

            migrationBuilder.RenameTable(
                name: "EmployeeUniversity",
                newName: "University");

            migrationBuilder.RenameTable(
                name: "EmployeeMajor",
                newName: "Major");

            migrationBuilder.RenameTable(
                name: "EmployeeFaculty",
                newName: "Faculty");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeUniversity_FacultyEmployeeFacultyId",
                table: "University",
                newName: "IX_University_FacultyEmployeeFacultyId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeFaculty_MajorEmployeeMajorId",
                table: "Faculty",
                newName: "IX_Faculty_MajorEmployeeMajorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_University",
                table: "University",
                column: "EmployeeUniversityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Major",
                table: "Major",
                column: "EmployeeMajorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculty",
                table: "Faculty",
                column: "EmployeeFacultyId");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    DivisionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Major_MajorEmployeeMajorId",
                table: "Employee",
                column: "MajorEmployeeMajorId",
                principalTable: "Major",
                principalColumn: "EmployeeMajorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_Major_MajorEmployeeMajorId",
                table: "Faculty",
                column: "MajorEmployeeMajorId",
                principalTable: "Major",
                principalColumn: "EmployeeMajorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_University_Faculty_FacultyEmployeeFacultyId",
                table: "University",
                column: "FacultyEmployeeFacultyId",
                principalTable: "Faculty",
                principalColumn: "EmployeeFacultyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
