using AutoMapper;
using DataInterface.Domain;
using MalamuleleHealth.EFCore.Application;
using MalamuleleHealth.Web.Configurations.Dto;
using MalamuleleHealth.Web.Configurations.Dto.Appointment;
using MalamuleleHealth.Web.Configurations.Dto.Invoice;
using MalamuleleHealth.Web.Configurations.Dto.User;

namespace MalamuleleHealth.Web.Configurations
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            //User
            CreateMap<Registration, User>()
          .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
            CreateMap<User, ApplicationUserDto>().ReverseMap();
            CreateMap<User, UpdateApplicationUserDto>().ReverseMap();

            //Appointment
            CreateMap<AddAppointmentDto, Appointment>().ReverseMap();
            CreateMap<AppointmentDto, Appointment>().ReverseMap();

            //Invoice
            CreateMap<InvoiceDto, Invoice>().ReverseMap();

        }

    }
}
