using Microsoft.AspNetCore.Identity;
using StoreApp.Services.Identity.Application.DTOs.User;

namespace StoreApp.Services.Identity.Application.Interfaces;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto);
}
