using AutoMapper;
using MalamuleleHealth.EFCore.Application;

namespace MalamuleleHealth.Web.Configurations
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Registration, ApplicationUser>()
          .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }

    }
}
