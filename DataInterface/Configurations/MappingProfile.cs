using AutoMapper;
using DataInterface.Configurations.Dto.ApplicationUser;
using DataInterface.Configurations.Dto.Appointment;
using DataInterface.Configurations.Dto.Invoice;
using DataInterface.Configurations.Dto.User;
using DataInterface.Domain;


namespace DataInterface.Configurations
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
