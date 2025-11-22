namespace StoreApp.Services.Identity.Application.DTOs.User;

public record UserForRegistrationDto
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Username { get; init; }
    public string? Password { get; init; }
    public string? Email { get; init; }
    public string? PhoneNumber { get; init; }

    public ICollection<string> Roles { get; init; }
}
