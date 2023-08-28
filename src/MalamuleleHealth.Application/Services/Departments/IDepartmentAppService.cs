using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MalamuleleHealth.Services.Departments.Dto;

namespace MalamuleleHealth.Services.Departments
{
    public interface IDepartmentAppService : IAsyncCrudAppService<DepartmentDto, long, PagedAndSortedResultRequestDto>
    {

    }
}
