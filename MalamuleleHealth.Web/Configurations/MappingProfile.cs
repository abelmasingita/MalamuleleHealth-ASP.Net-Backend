using AutoMapper;
using MalamuleleHealth.EFCore.Application;
using MalamuleleHealth.Web.Configurations.Dto;
using MalamuleleHealth.Web.Configurations.Dto.User;

namespace MalamuleleHealth.Web.Configurations
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Registration, ApplicationUser>()
          .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));

            CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();
            CreateMap<ApplicationUser, UpdateApplicationUserDto>().ReverseMap();
        }

    }
}
