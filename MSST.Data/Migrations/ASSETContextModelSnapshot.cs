﻿// <auto-generated />
using ASSET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace ASSET.Data.Migrations
{
    [DbContext(typeof(ASSETContext))]
    partial class ASSETContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASSET.Common.Base", b =>
                {
                    b.Property<int>("BaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetUnitBaseId");

                    b.Property<int?>("AssetWarrantyCompanyBaseId");

                    b.Property<string>("CreateBy");

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("EmployeeBaseId");

                    b.Property<int?>("EmployeeFacultyBaseId");

                    b.Property<int>("IsActive");

                    b.Property<int>("IsDelete");

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("BaseId");

                    b.HasIndex("AssetUnitBaseId");

                    b.HasIndex("AssetWarrantyCompanyBaseId");

                    b.HasIndex("EmployeeBaseId");

                    b.HasIndex("EmployeeFacultyBaseId");

                    b.ToTable("Base");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Base");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetCategory", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<int>("AssetCategoryId");

                    b.Property<int?>("AssetDetailBaseId");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasIndex("AssetDetailBaseId")
                        .IsUnique()
                        .HasFilter("[AssetDetailBaseId] IS NOT NULL");

                    b.ToTable("AssetCategory");

                    b.HasDiscriminator().HasValue("AssetCategory");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetDetail", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<int>("AssetDetailId");

                    b.Property<string>("Barcode");

                    b.Property<string>("Brand");

                    b.Property<string>("Code")
                        .HasColumnName("AssetDetail_Code");

                    b.Property<string>("Color");

                    b.Property<int?>("GroupBaseId");

                    b.Property<string>("Model");

                    b.Property<string>("NameEng");

                    b.Property<string>("NameThai");

                    b.Property<string>("OldCode");

                    b.Property<string>("SerialNo");

                    b.Property<string>("Size");

                    b.Property<int?>("TypeBaseId");

                    b.Property<int?>("UnitBaseId");

                    b.HasIndex("GroupBaseId")
                        .IsUnique()
                        .HasFilter("[GroupBaseId] IS NOT NULL");

                    b.HasIndex("TypeBaseId")
                        .IsUnique()
                        .HasFilter("[TypeBaseId] IS NOT NULL");

                    b.HasIndex("UnitBaseId")
                        .IsUnique()
                        .HasFilter("[UnitBaseId] IS NOT NULL");

                    b.ToTable("AssetDetail");

                    b.HasDiscriminator().HasValue("AssetDetail");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetGroup", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<int>("AssetGroupId");

                    b.Property<string>("AssetId");

                    b.Property<string>("Code")
                        .HasColumnName("AssetGroup_Code");

                    b.Property<string>("Name")
                        .HasColumnName("AssetGroup_Name");

                    b.ToTable("AssetGroup");

                    b.HasDiscriminator().HasValue("AssetGroup");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetMaster", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<int?>("AssetDetailBaseId")
                        .HasColumnName("AssetMaster_AssetDetailBaseId");

                    b.Property<int>("AssetMasterId");

                    b.Property<int?>("AssetWarrantyBaseId");

                    b.HasIndex("AssetDetailBaseId");

                    b.HasIndex("AssetWarrantyBaseId");

                    b.ToTable("AssetMaster");

                    b.HasDiscriminator().HasValue("AssetMaster");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetType", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<int>("AssetTypeId");

                    b.Property<string>("Code")
                        .HasColumnName("AssetType_Code");

                    b.Property<string>("Name")
                        .HasColumnName("AssetType_Name");

                    b.ToTable("AssetType");

                    b.HasDiscriminator().HasValue("AssetType");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetUnit", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<int>("AssetUnitId");

                    b.Property<string>("Code")
                        .HasColumnName("AssetUnit_Code");

                    b.Property<string>("Name")
                        .HasColumnName("AssetUnit_Name");

                    b.ToTable("AssetUnit");

                    b.HasDiscriminator().HasValue("AssetUnit");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetWarranty", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Address");

                    b.Property<int>("AssetWarrantyId");

                    b.Property<string>("ContractNumber");

                    b.Property<string>("InvoiceNumber");

                    b.Property<string>("PolicyNumber");

                    b.Property<double>("Premium");

                    b.Property<string>("Remark");

                    b.Property<int>("SupplierId");

                    b.Property<string>("Telphone");

                    b.Property<string>("VoucherNumber");

                    b.Property<int?>("WarrantyCompanyBaseId");

                    b.Property<string>("WarrantyDuration");

                    b.Property<DateTime>("WarrantyEnd");

                    b.Property<DateTime>("WarrantyStart");

                    b.HasIndex("WarrantyCompanyBaseId")
                        .IsUnique()
                        .HasFilter("[WarrantyCompanyBaseId] IS NOT NULL");

                    b.ToTable("AssetWarranty");

                    b.HasDiscriminator().HasValue("AssetWarranty");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetWarrantyCompany", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Address")
                        .HasColumnName("AssetWarrantyCompany_Address");

                    b.Property<int>("AssetWarrantyCompanyId");

                    b.Property<string>("Code")
                        .HasColumnName("AssetWarrantyCompany_Code");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .HasColumnName("AssetWarrantyCompany_Name");

                    b.ToTable("AssetWarrantyCompany");

                    b.HasDiscriminator().HasValue("AssetWarrantyCompany");
                });

            modelBuilder.Entity("ASSET.Models.Master.Employee", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Address")
                        .HasColumnName("Employee_Address");

                    b.Property<string>("Code")
                        .HasColumnName("Employee_Code");

                    b.Property<string>("ContactNumber")
                        .HasColumnName("Employee_ContactNumber");

                    b.Property<string>("ContactPerson")
                        .HasColumnName("Employee_ContactPerson");

                    b.Property<string>("Email")
                        .HasColumnName("Employee_Email");

                    b.Property<int>("EmployeeId");

                    b.Property<int?>("MajorBaseId");

                    b.Property<string>("Name")
                        .HasColumnName("Employee_Name");

                    b.HasIndex("MajorBaseId")
                        .IsUnique()
                        .HasFilter("[MajorBaseId] IS NOT NULL");

                    b.ToTable("Employee");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeFaculty", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Code")
                        .HasColumnName("EmployeeFaculty_Code");

                    b.Property<int>("EmployeeFacultyId");

                    b.Property<int?>("MajorBaseId")
                        .HasColumnName("EmployeeFaculty_MajorBaseId");

                    b.Property<string>("Name")
                        .HasColumnName("EmployeeFaculty_Name");

                    b.HasIndex("MajorBaseId");

                    b.ToTable("EmployeeFaculty");

                    b.HasDiscriminator().HasValue("EmployeeFaculty");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeMajor", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Code")
                        .HasColumnName("EmployeeMajor_Code");

                    b.Property<int>("EmployeeMajorId");

                    b.Property<string>("Name")
                        .HasColumnName("EmployeeMajor_Name");

                    b.ToTable("EmployeeMajor");

                    b.HasDiscriminator().HasValue("EmployeeMajor");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeUniversity", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Code")
                        .HasColumnName("EmployeeUniversity_Code");

                    b.Property<int>("EmployeeUniversityId");

                    b.Property<int?>("FacultyBaseId");

                    b.Property<string>("NameEng")
                        .HasColumnName("EmployeeUniversity_NameEng");

                    b.Property<string>("NameThai")
                        .HasColumnName("EmployeeUniversity_NameThai");

                    b.HasIndex("FacultyBaseId");

                    b.ToTable("EmployeeUniversity");

                    b.HasDiscriminator().HasValue("EmployeeUniversity");
                });

            modelBuilder.Entity("ASSET.Models.Master.Supplier", b =>
                {
                    b.HasBaseType("ASSET.Common.Base");

                    b.Property<string>("Address")
                        .HasColumnName("Supplier_Address");

                    b.Property<string>("Code")
                        .HasColumnName("Supplier_Code");

                    b.Property<string>("ContactNumber")
                        .HasColumnName("Supplier_ContactNumber");

                    b.Property<string>("ContactPerson")
                        .HasColumnName("Supplier_ContactPerson");

                    b.Property<string>("Email")
                        .HasColumnName("Supplier_Email");

                    b.Property<string>("Name")
                        .HasColumnName("Supplier_Name");

                    b.Property<int>("SupplierId")
                        .HasColumnName("SupplierId1");

                    b.ToTable("Supplier");

                    b.HasDiscriminator().HasValue("Supplier");
                });

            modelBuilder.Entity("ASSET.Common.Base", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetUnit")
                        .WithMany("Common")
                        .HasForeignKey("AssetUnitBaseId");

                    b.HasOne("ASSET.Models.Master.AssetWarrantyCompany")
                        .WithMany("Common")
                        .HasForeignKey("AssetWarrantyCompanyBaseId");

                    b.HasOne("ASSET.Models.Master.Employee")
                        .WithMany("Common")
                        .HasForeignKey("EmployeeBaseId");

                    b.HasOne("ASSET.Models.Master.EmployeeFaculty")
                        .WithMany("Common")
                        .HasForeignKey("EmployeeFacultyBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetCategory", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetDetail", "AssetDetail")
                        .WithOne("Category")
                        .HasForeignKey("ASSET.Models.Master.AssetCategory", "AssetDetailBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetDetail", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetGroup", "Group")
                        .WithOne("AssetDetail")
                        .HasForeignKey("ASSET.Models.Master.AssetDetail", "GroupBaseId");

                    b.HasOne("ASSET.Models.Master.AssetType", "Type")
                        .WithOne("AssetDetail")
                        .HasForeignKey("ASSET.Models.Master.AssetDetail", "TypeBaseId");

                    b.HasOne("ASSET.Models.Master.AssetUnit", "Unit")
                        .WithOne("AssetDetail")
                        .HasForeignKey("ASSET.Models.Master.AssetDetail", "UnitBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetMaster", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetDetail", "AssetDetail")
                        .WithMany()
                        .HasForeignKey("AssetDetailBaseId");

                    b.HasOne("ASSET.Models.Master.AssetWarranty", "AssetWarranty")
                        .WithMany()
                        .HasForeignKey("AssetWarrantyBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.AssetWarranty", b =>
                {
                    b.HasOne("ASSET.Models.Master.AssetWarrantyCompany", "WarrantyCompany")
                        .WithOne("AssetWarranty")
                        .HasForeignKey("ASSET.Models.Master.AssetWarranty", "WarrantyCompanyBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.Employee", b =>
                {
                    b.HasOne("ASSET.Models.Master.EmployeeMajor", "Major")
                        .WithOne("Employee")
                        .HasForeignKey("ASSET.Models.Master.Employee", "MajorBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeFaculty", b =>
                {
                    b.HasOne("ASSET.Models.Master.EmployeeMajor", "Major")
                        .WithMany()
                        .HasForeignKey("MajorBaseId");
                });

            modelBuilder.Entity("ASSET.Models.Master.EmployeeUniversity", b =>
                {
                    b.HasOne("ASSET.Models.Master.EmployeeFaculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyBaseId");
                });
#pragma warning restore 612, 618
        }
    }
}
