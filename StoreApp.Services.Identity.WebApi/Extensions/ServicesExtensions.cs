using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoreApp.Services.Identity.Domain.Entities;
using StoreApp.Services.Identity.Infrastructure.Persistence;

namespace StoreApp.Services.Identity.WebApi.Extensions;

public static class ServicesExtensions
{
    public static void ConfigureDatabaseConnection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdentityDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
        ));
    }

    public static void ConfigureIdentity(this IServiceCollection services)
    {
        var builder = services.AddIdentity<User, IdentityRole>(options =>
        {             
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredLength = 6;

            options.User.RequireUniqueEmail = true;
        })
            .AddEntityFrameworkStores<IdentityDbContext>()
            .AddDefaultTokenProviders();
    }
}