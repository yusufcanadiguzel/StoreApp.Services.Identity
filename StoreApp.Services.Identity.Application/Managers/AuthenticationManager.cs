using Microsoft.AspNetCore.Identity;
using StoreApp.Services.Identity.Application.DTOs.User;
using StoreApp.Services.Identity.Application.Interfaces;

namespace StoreApp.Services.Identity.Application.Managers;

public class AuthenticationManager : IAuthenticationService
{
    public Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto)
    {
        throw new NotImplementedException();
    }
}
