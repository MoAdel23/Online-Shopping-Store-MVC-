
global using Eshop.Entities.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Eshop.DataAccess.Data;

namespace Eshop.Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
        //    options =>
        //{
        //    options.SignIn.RequireConfirmedAccount = true;
        //    options.SignIn.RequireConfirmedEmail = true;
        //}
         ) // Confirm Email
           // configures Identity to use Entity Framework Core as the data store and specifies ApplicationDbContext as the context class
         .AddEntityFrameworkStores<ApplicationDbContext>()
         .AddDefaultUI()
         .AddDefaultTokenProviders();




        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Add Runtime Compilation to Razor Page
        builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication(); // Ensure Authentication is added before Authorization
        app.UseAuthorization();

        app.MapRazorPages(); // Add this line to map Razor Pages

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id:int?}");

        app.Run();
    }
}
