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

namespace MalamuleleHealth.Services.Departments
{
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, long, PagedAndSortedResultRequestDto>,
    IDepartmentAppService
    {
        public DepartmentAppService(IRepository<Department, long> repository) : base(repository)
        {
        }
    }
}
