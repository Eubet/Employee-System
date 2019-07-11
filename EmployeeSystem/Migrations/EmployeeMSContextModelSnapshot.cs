﻿// <auto-generated />
using System;
using EmployeeSystem.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeSystem.Migrations
{
    [DbContext(typeof(EmployeeMSContext))]
    partial class EmployeeMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<bool?>("IsActive");

                    b.Property<string>("LastName")
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AuditInfo", b =>
                {
                    b.Property<int>("AuditInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AuditInfoID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired();

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("UpdatedBy")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime");

                    b.HasKey("AuditInfoId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("AuditInfo");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int?>("AuditInfoId");

                    b.Property<DateTime?>("Dob")
                        .HasColumnName("DOB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("EmpNum")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime?>("EmployedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int?>("GenderId")
                        .HasColumnName("GenderID");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20);

                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<int?>("SupervisorId")
                        .HasColumnName("SupervisorID");

                    b.Property<int>("TitleId")
                        .HasColumnName("TitleID");

                    b.HasKey("EmployeeId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("AuditInfoId");

                    b.HasIndex("GenderId");

                    b.HasIndex("RegionId");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GenderID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("GenderId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RegionID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName")
                        .IsRequired();

                    b.HasKey("RegionId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Region");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TitleID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("TitleId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Title");
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetRoleClaims", b =>
                {
                    b.HasOne("EmployeeSystem.Data.DataAccess.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserClaims", b =>
                {
                    b.HasOne("EmployeeSystem.Data.DataAccess.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserLogins", b =>
                {
                    b.HasOne("EmployeeSystem.Data.DataAccess.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserRoles", b =>
                {
                    b.HasOne("EmployeeSystem.Data.DataAccess.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeeSystem.Data.DataAccess.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.AspNetUserTokens", b =>
                {
                    b.HasOne("EmployeeSystem.Data.DataAccess.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeeSystem.Data.DataAccess.Employee", b =>
                {
                    b.HasOne("EmployeeSystem.Data.DataAccess.AuditInfo", "AuditInfo")
                        .WithMany("Employee")
                        .HasForeignKey("AuditInfoId")
                        .HasConstraintName("FK_AuditInfoEmployee");

                    b.HasOne("EmployeeSystem.Data.DataAccess.Gender", "Gender")
                        .WithMany("Employee")
                        .HasForeignKey("GenderId")
                        .HasConstraintName("FK_GenderEmployee");

                    b.HasOne("EmployeeSystem.Data.DataAccess.Region", "Region")
                        .WithMany("Employee")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_RegionEmployee");

                    b.HasOne("EmployeeSystem.Data.DataAccess.Employee", "Supervisor")
                        .WithMany("InverseSupervisor")
                        .HasForeignKey("SupervisorId")
                        .HasConstraintName("FK_EmployeeEmployee");

                    b.HasOne("EmployeeSystem.Data.DataAccess.Title", "Title")
                        .WithMany("Employee")
                        .HasForeignKey("TitleId")
                        .HasConstraintName("FK_TitleEmployee");
                });
#pragma warning restore 612, 618
        }
    }
}
