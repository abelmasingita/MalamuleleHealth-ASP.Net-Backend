using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalamuleleHealth.Domain;
using MalamuleleHealth.Services.Departments.Dto;
using Abp.Domain.Repositories;
using Abp.Authorization;
using MalamuleleHealth.Authorization;

namespace MalamuleleHealth.Services.Departments
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, Guid, PagedAndSortedResultRequestDto>,
    IPrescriptionAppService
    {
        public DepartmentAppService(IRepository<Department, Guid> repository) : base(repository)
        {
        }
    }
}
