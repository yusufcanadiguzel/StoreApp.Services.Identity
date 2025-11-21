using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StoreApp.Services.Identity.Infrastructure.Persistence.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "a1b2c3d4-e5f6-7890-abcd-ef1234567890" },
            new IdentityRole { Id = "2", Name = "Editor", NormalizedName = "EDITOR", ConcurrencyStamp = "b1c2d3e4-f5a6-7890-abcd-ef1234567891" },
            new IdentityRole { Id = "3", Name = "User", NormalizedName = "USER", ConcurrencyStamp = "c1d2e3f4-a5b6-7890-abcd-ef1234567892" }
            );
    }
}