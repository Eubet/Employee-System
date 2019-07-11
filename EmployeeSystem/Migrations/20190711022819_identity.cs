using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeSystem.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");
                //columns: table => new
                //{
                //    Id = table.Column<string>(nullable: false),
                //    UserName = table.Column<string>(nullable: true),
                //    NormalizedUserName = table.Column<string>(nullable: true),
                //    FirstName = table.Column<string>(nullable: false),
                //    LastName = table.Column<string>(nullable: false),
                //    IsActive = table.Column<bool>(nullable: false),
                //    Email = table.Column<string>(nullable: true),
                //    NormalizedEmail = table.Column<string>(nullable: true),
                //    EmailConfirmed = table.Column<bool>(nullable: false),
                //    PasswordHash = table.Column<string>(nullable: true),
                //    SecurityStamp = table.Column<string>(nullable: true),
                //    ConcurrencyStamp = table.Column<string>(nullable: true),
                //    PhoneNumber = table.Column<string>(nullable: true),
                //    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                //    TwoFactorEnabled = table.Column<bool>(nullable: false),
                //    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                //    LockoutEnabled = table.Column<bool>(nullable: false),
                //    AccessFailedCount = table.Column<int>(nullable: false)
                //},
                //constraints: table =>
                //{
                //    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                //});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");
        }
    }
}
