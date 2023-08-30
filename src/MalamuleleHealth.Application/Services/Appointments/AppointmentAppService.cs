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
using Abp.Authorization;
using MalamuleleHealth.Authorization;

namespace MalamuleleHealth.Services.Appointments
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class AppointmentAppService : AsyncCrudAppService<Appointment, AppointmentDto, Guid, PagedAndSortedResultRequestDto>,
    IAppointmentAppService
    {
        public AppointmentAppService(IRepository<Appointment, Guid> repository) : base(repository)
        {
        }
    }
}
