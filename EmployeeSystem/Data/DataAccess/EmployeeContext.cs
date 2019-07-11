using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeSystem.Data.DataAccess
{
    public partial class EmployeeMSContext : DbContext
    {
        public EmployeeMSContext()
        {
        }

        public EmployeeMSContext(DbContextOptions<EmployeeMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AuditInfo> AuditInfo { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<IdentityUserClaim<string>> IdentityUserClaim { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CC6SIV7\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AuditInfo>(entity =>
            {
                entity.HasKey(e => e.AuditInfoId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.AuditInfoId).HasColumnName("AuditInfoID");

                entity.Property(e => e.CreatedBy).IsRequired();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsRequired();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmpNum)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmployedOn).HasColumnType("datetime");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.HasOne(d => d.AuditInfo)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.AuditInfoId)
                    .HasConstraintName("FK_AuditInfoEmployee");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_GenderEmployee");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegionEmployee");

                entity.HasOne(d => d.Supervisor)
                    .WithMany(p => p.InverseSupervisor)
                    .HasForeignKey(d => d.SupervisorId)
                    .HasConstraintName("FK_EmployeeEmployee");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TitleEmployee");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.RegionName).IsRequired();
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.TitleId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.TitleId).HasColumnName("TitleID");

                entity.Property(e => e.TitleName)
                    .IsRequired()
                    .HasMaxLength(20);
            });
        }
    }
}
