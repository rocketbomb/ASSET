using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASSET.Data.Migrations
{
    public partial class Update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId1",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "Institue");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentId1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "Major");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Faculty");

            migrationBuilder.RenameColumn(
                name: "DepartmentId1",
                table: "Employee",
                newName: "MajorEmployeeMajorId");

            migrationBuilder.RenameColumn(
                name: "UniversityId",
                table: "University",
                newName: "EmployeeUniversityId");

            migrationBuilder.RenameColumn(
                name: "MajorId",
                table: "Major",
                newName: "EmployeeMajorId");

            migrationBuilder.RenameColumn(
                name: "FacultyId",
                table: "Faculty",
                newName: "EmployeeFacultyId");

            migrationBuilder.AddColumn<int>(
                name: "FacultyEmployeeFacultyId",
                table: "University",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MajorEmployeeMajorId",
                table: "Faculty",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MajorEmployeeMajorId",
                table: "Employee",
                column: "MajorEmployeeMajorId",
                unique: true,
                filter: "[MajorEmployeeMajorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_University_FacultyEmployeeFacultyId",
                table: "University",
                column: "FacultyEmployeeFacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_MajorEmployeeMajorId",
                table: "Faculty",
                column: "MajorEmployeeMajorId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Employee_MajorEmployeeMajorId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_University_FacultyEmployeeFacultyId",
                table: "University");

            migrationBuilder.DropIndex(
                name: "IX_Faculty_MajorEmployeeMajorId",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "FacultyEmployeeFacultyId",
                table: "University");

            migrationBuilder.DropColumn(
                name: "MajorEmployeeMajorId",
                table: "Faculty");

            migrationBuilder.RenameColumn(
                name: "MajorEmployeeMajorId",
                table: "Employee",
                newName: "DepartmentId1");

            migrationBuilder.RenameColumn(
                name: "EmployeeUniversityId",
                table: "University",
                newName: "UniversityId");

            migrationBuilder.RenameColumn(
                name: "EmployeeMajorId",
                table: "Major",
                newName: "MajorId");

            migrationBuilder.RenameColumn(
                name: "EmployeeFacultyId",
                table: "Faculty",
                newName: "FacultyId");

            migrationBuilder.AddColumn<int>(
                name: "FacultyId",
                table: "Major",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Faculty",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Institue",
                columns: table => new
                {
                    InstitueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institue", x => x.InstitueId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId1",
                table: "Employee",
                column: "DepartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId1",
                table: "Employee",
                column: "DepartmentId1",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
