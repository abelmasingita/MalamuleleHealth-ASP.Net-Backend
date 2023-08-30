using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalamuleleHealth.Services.Appointments.Dto;

namespace MalamuleleHealth.Services.Appointments
{
    public interface IAppointmentAppService : IAsyncCrudAppService<AppointmentDto, Guid, PagedAndSortedResultRequestDto>
    {

    }
}
