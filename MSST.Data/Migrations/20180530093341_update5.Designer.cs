﻿// <auto-generated />
using ASSET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ASSET.Data.Migrations
{
    [DbContext(typeof(ASSETContext))]
    [Migration("20180530093341_update5")]
    partial class update5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASSET.Models.Master.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetDepreciationId");

                    b.Property<int?>("AssetWarrantyId");

                    b.Property<string>("Barcode");

                    b.Property<string>("Brand");

                    b.Property<int?>("CategoryAssetCategoryId");

                    b.Property<string>("Code");

                    b.Property<string>("Color");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int?>("EmployeeFacultyId");

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("EmployeeMajorId");

                    b.Property<int?>("EmployeeUniversityId");

                    b.Property<int?>("GroupAssetGroupId");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<int?>("LocationId");

                    b.Property<string>("Model");

                    b.Property<string>("NameEng");

                    b.Property<string>("NameThai");

                    b.Property<string>("OldCode");

                    b.Property<int?>("OwnershipId");

                    b.Property<string>("SerialNo");

                    b.Property<string>("Size");

                    b.Property<int?>("TypeAssetTypeId");

                    b.Property<int?>("UnitAssetUnitId");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("AssetId");

                    b.HasIndex("AssetDepreciationId")
                        .IsUnique()
                        .HasFilter("[AssetDepreciationId] IS NOT NULL");

                    b.HasIndex("AssetWarrantyId")
                        .IsUnique()
                        .HasFilter("[AssetWarrantyId] IS NOT NULL");

                    b.HasIndex("CategoryAssetCategoryId")
                        .IsUnique()
                        .HasFilter("[CategoryAssetCategoryId] IS NOT NULL");

                    b.HasIndex("EmployeeFacultyId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeMajorId");

                    b.HasIndex("EmployeeUniversityId");

                    b.HasIndex("GroupAssetGroupId")
                        .IsUnique()
                        .HasFilter("[GroupAssetGroupId] IS NOT NULL");

                    b.HasIndex("LocationId");

                    b.HasIndex("OwnershipId")
                        .IsUnique()
                        .HasFilter("[OwnershipId] IS NOT NULL");

                    b.HasIndex("TypeAssetTypeId")
                        .IsUnique()
                        .HasFilter("[TypeAssetTypeId] IS NOT NULL");

                    b.HasIndex("UnitAssetUnitId")
                        .IsUnique()
                        .HasFilter("[UnitAssetUnitId] IS NOT NULL");

                    b.ToTable("Asset");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetCategory", b =>
                {
                    b.Property<int>("AssetCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("AssetCategoryId");

                    b.ToTable("AssetCategory");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetDepreciation", b =>
                {
                    b.Property<int>("AssetDepreciationId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AssetAge");

                    b.Property<double>("CalculatePrice");

                    b.Property<double>("Cost");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<double>("DayOffCalculate");

                    b.Property<double>("DepreciateOpen");

                    b.Property<double>("DepreciatePerDay");

                    b.Property<double>("DepreciateRatio");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<double>("RemainPrice");

                    b.Property<double>("Remark");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<double>("UsefulLife");

                    b.HasKey("AssetDepreciationId");

                    b.ToTable("AssetDepreciation");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetGroup", b =>
                {
                    b.Property<int>("AssetGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AssetId");

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("AssetGroupId");

                    b.ToTable("AssetGroup");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetType", b =>
                {
                    b.Property<int>("AssetTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("AssetTypeId");

                    b.ToTable("AssetType");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetUnit", b =>
                {
                    b.Property<int>("AssetUnitId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("AssetUnitId");

                    b.ToTable("AssetUnit");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetWarranty", b =>
                {
                    b.Property<int>("AssetWarrantyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ContractNumber");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("InvoiceNumber");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("PolicyNumber");

                    b.Property<double>("Premium");

                    b.Property<string>("Remark");

                    b.Property<int>("SupplierId");

                    b.Property<string>("Telphone");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("VoucherNumber");

                    b.Property<int?>("WarrantyCompanyAssetWarrantyCompanyId");

                    b.Property<string>("WarrantyDuration");

                    b.Property<DateTime>("WarrantyEnd");

                    b.Property<DateTime>("WarrantyStart");

                    b.HasKey("AssetWarrantyId");

                    b.HasIndex("WarrantyCompanyAssetWarrantyCompanyId")
                        .IsUnique()
                        .HasFilter("[WarrantyCompanyAssetWarrantyCompanyId] IS NOT NULL");

                    b.ToTable("AssetWarranty");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetWarrantyCompany", b =>
                {
                    b.Property<int>("AssetWarrantyCompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Email");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("AssetWarrantyCompanyId");

                    b.ToTable("AssetWarrantyCompany");
                });

            modelBuilder.Entity("ASSET.Models.Master.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Email");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<int?>("MajorEmployeeMajorId");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("EmployeeId");

                    b.HasIndex("MajorEmployeeMajorId")
                        .IsUnique()
                        .HasFilter("[MajorEmployeeMajorId] IS NOT NULL");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeFaculty", b =>
                {
                    b.Property<int>("EmployeeFacultyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<int?>("MajorEmployeeMajorId");

                    b.Property<string>("Name");

                    b.Property<int>("UniversityId");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("EmployeeFacultyId");

                    b.HasIndex("MajorEmployeeMajorId");

                    b.HasIndex("UniversityId");

                    b.ToTable("EmployeeFaculty");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeMajor", b =>
                {
                    b.Property<int>("EmployeeMajorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("EmployeeMajorId");

                    b.ToTable("EmployeeMajor");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeUniversity", b =>
                {
                    b.Property<int>("EmployeeUniversityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("NameEng");

                    b.Property<string>("NameThai");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("EmployeeUniversityId");

                    b.ToTable("EmployeeUniversity");
                });

            modelBuilder.Entity("ASSET.Models.Master.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode");

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<int?>("LocationGroupId");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("LocationId");

                    b.HasIndex("LocationGroupId")
                        .IsUnique()
                        .HasFilter("[LocationGroupId] IS NOT NULL");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("ASSET.Models.Master.LocationGroup", b =>
                {
                    b.Property<int>("LocationGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Barcode");

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("LocationGroupId");

                    b.ToTable("LocationGroup");
                });

            modelBuilder.Entity("ASSET.Models.Master.Ownership", b =>
                {
                    b.Property<int>("OwnershipId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int?>("EmployeeFacultyId");

                    b.Property<int?>("EmployeeId");

                    b.Property<int?>("EmployeeMajorId");

                    b.Property<int?>("EmployeeUniversityId");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("OwnershipId");

                    b.HasIndex("EmployeeFacultyId")
                        .IsUnique()
                        .HasFilter("[EmployeeFacultyId] IS NOT NULL");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[EmployeeId] IS NOT NULL");

                    b.HasIndex("EmployeeMajorId")
                        .IsUnique()
                        .HasFilter("[EmployeeMajorId] IS NOT NULL");

                    b.HasIndex("EmployeeUniversityId")
                        .IsUnique()
                        .HasFilter("[EmployeeUniversityId] IS NOT NULL");

                    b.ToTable("Ownership");
                });

            modelBuilder.Entity("ASSET.Models.Master.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Email");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<int?>("SupplierGroupId");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("SupplierId");

                    b.HasIndex("SupplierGroupId")
                        .IsUnique()
                        .HasFilter("[SupplierGroupId] IS NOT NULL");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("ASSET.Models.Master.SupplierGroup", b =>
                {
                    b.Property<int>("SupplierGroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("SupplierGroupId");

                    b.ToTable("SupplierGroup");
                });

            modelBuilder.Entity("ASSET.Models.Master.Asset", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetDepreciation", "AssetDepreciation")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "AssetDepreciationId");

                    b.HasOne("ASSET.Models.Master.AssetWarranty", "AssetWarranty")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "AssetWarrantyId");

                    b.HasOne("ASSET.Models.Master.AssetCategory", "Category")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "CategoryAssetCategoryId");

                    b.HasOne("ASSET.Models.Master.EmployeeFaculty")
                        .WithMany("Asset")
                        .HasForeignKey("EmployeeFacultyId");

                    b.HasOne("ASSET.Models.Master.Employee")
                        .WithMany("Asset")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("ASSET.Models.Master.EmployeeMajor")
                        .WithMany("Asset")
                        .HasForeignKey("EmployeeMajorId");

                    b.HasOne("ASSET.Models.Master.EmployeeUniversity")
                        .WithMany("Asset")
                        .HasForeignKey("EmployeeUniversityId");

                    b.HasOne("ASSET.Models.Master.AssetGroup", "Group")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "GroupAssetGroupId");

                    b.HasOne("ASSET.Models.Master.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("ASSET.Models.Master.Ownership", "Ownership")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "OwnershipId");

                    b.HasOne("ASSET.Models.Master.AssetType", "Type")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "TypeAssetTypeId");

                    b.HasOne("ASSET.Models.Master.AssetUnit", "Unit")
                        .WithOne("Asset")
                        .HasForeignKey("ASSET.Models.Master.Asset", "UnitAssetUnitId");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetWarranty", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetWarrantyCompany", "WarrantyCompany")
                        .WithOne("AssetWarranty")
                        .HasForeignKey("ASSET.Models.Master.AssetWarranty", "WarrantyCompanyAssetWarrantyCompanyId");
                });

            modelBuilder.Entity("ASSET.Models.Master.Employee", b =>
                {
                    b.HasOne("ASSET.Models.Master.EmployeeMajor", "Major")
                        .WithOne("Employee")
                        .HasForeignKey("ASSET.Models.Master.Employee", "MajorEmployeeMajorId");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeFaculty", b =>
                {
                    b.HasOne("ASSET.Models.Master.EmployeeMajor", "Major")
                        .WithMany()
                        .HasForeignKey("MajorEmployeeMajorId");

                    b.HasOne("ASSET.Models.Master.EmployeeUniversity", "University")
                        .WithMany("EmployeeFaculty")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASSET.Models.Master.Location", b =>
                {
                    b.HasOne("ASSET.Models.Master.LocationGroup", "LocationGroup")
                        .WithOne("Location")
                        .HasForeignKey("ASSET.Models.Master.Location", "LocationGroupId");
                });

            modelBuilder.Entity("ASSET.Models.Master.Ownership", b =>
                {
                    b.HasOne("ASSET.Models.Master.EmployeeFaculty", "EmployeeFaculty")
                        .WithOne("Ownership")
                        .HasForeignKey("ASSET.Models.Master.Ownership", "EmployeeFacultyId");

                    b.HasOne("ASSET.Models.Master.Employee", "Employee")
                        .WithOne("Ownership")
                        .HasForeignKey("ASSET.Models.Master.Ownership", "EmployeeId");

                    b.HasOne("ASSET.Models.Master.EmployeeMajor", "EmployeeMajor")
                        .WithOne("Ownership")
                        .HasForeignKey("ASSET.Models.Master.Ownership", "EmployeeMajorId");

                    b.HasOne("ASSET.Models.Master.EmployeeUniversity", "EmployeeUniversity")
                        .WithOne("Ownership")
                        .HasForeignKey("ASSET.Models.Master.Ownership", "EmployeeUniversityId");
                });

            modelBuilder.Entity("ASSET.Models.Master.Supplier", b =>
                {
                    b.HasOne("ASSET.Models.Master.SupplierGroup", "SupplierGroup")
                        .WithOne("Supplier")
                        .HasForeignKey("ASSET.Models.Master.Supplier", "SupplierGroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
