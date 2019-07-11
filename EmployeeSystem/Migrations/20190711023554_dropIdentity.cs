using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeSystem.Migrations
{
    public partial class dropIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "IdentityUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
