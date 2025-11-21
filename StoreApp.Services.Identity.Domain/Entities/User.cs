using Microsoft.AspNetCore.Identity;

namespace StoreApp.Services.Identity.Domain.Entities;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}