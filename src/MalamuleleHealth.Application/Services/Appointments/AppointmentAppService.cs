using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalamuleleHealth.Domain;
using MalamuleleHealth.Services.Appointments.Dto;
using Abp.Domain.Repositories;

namespace MalamuleleHealth.Services.Appointments
{
    public class AppointmentAppService : AsyncCrudAppService<Appointment, AppointmentDto, long, PagedAndSortedResultRequestDto>,
    IAppointmentAppService
    {
        public AppointmentAppService(IRepository<Appointment, long> repository) : base(repository)
        {
        }
    }
}
