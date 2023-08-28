using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MalamuleleHealth.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Services.Departments.Dto
{
    [AutoMap(typeof(Department))]
    public class DepartmentDto : AuditedEntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
