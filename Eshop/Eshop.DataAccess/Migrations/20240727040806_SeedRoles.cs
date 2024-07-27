using Eshop.Entities;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eshop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: ["Id", "Name", "NormalizedName", "ConcurrencyStamp"],
                values: [Guid.NewGuid().ToString(), Roles.Basic, Roles.Basic.ToUpper(), Guid.NewGuid().ToString()],
                 schema: "security"
                );

            migrationBuilder.InsertData(
                table: "Roles",
                columns: ["Id", "Name", "NormalizedName", "ConcurrencyStamp"],
                values: [Guid.NewGuid().ToString(), Roles.Admin, Roles.Admin.ToUpper(), Guid.NewGuid().ToString()],
                 schema: "security"
                ); 
            
            migrationBuilder.InsertData(
                table: "Roles",
                columns: ["Id", "Name", "NormalizedName", "ConcurrencyStamp"],
                values: [Guid.NewGuid().ToString(), Roles.Super, Roles.Super.ToUpper(), Guid.NewGuid().ToString()],
                 schema: "security"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delegate FROM [security].[Roles]");
        }
    }
}
