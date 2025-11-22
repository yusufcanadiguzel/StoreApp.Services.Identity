using AutoMapper;
using StoreApp.Services.Identity.Application.DTOs.User;
using StoreApp.Services.Identity.Domain.Entities;

namespace StoreApp.Services.Identity.Application.Mapping.AutoMapper;

public class AmMappingProfile : Profile
{
    public AmMappingProfile()
    {
        // User mappings
        CreateMap<UserForRegistrationDto, User>();
    }
}
