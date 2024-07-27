using Eshop.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Eshop.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }

  

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .ToTable(name:"Users", schema: "security");

        builder.Entity<IdentityRole>()
            .ToTable(name: "Roles", schema: "security");

        builder.Entity<IdentityUserRole<string>>()
            .ToTable(name: "UserRoles", schema: "security");

        builder.Entity<IdentityUserLogin<string>>()
               .ToTable(name: "UserLogins", schema: "security");

        builder.Entity<IdentityUserClaim<string>>()
            .ToTable(name: "UserClaims", schema: "security");

        builder.Entity<IdentityRoleClaim<string>>()
            .ToTable(name: "RoleClaims", schema: "security");

        builder.Entity<IdentityUserToken<string>>()
            .ToTable(name: "UserTokens", schema: "security");


    }
}
