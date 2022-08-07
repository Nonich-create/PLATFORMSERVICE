using AutoMapper;
using PLATFORMSERVICE.Dtos;
using PLATFORMSERVICE.Models;

namespace PLATFORMSERVICE.Profiles
{
    public class PlatformsProfile: Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
