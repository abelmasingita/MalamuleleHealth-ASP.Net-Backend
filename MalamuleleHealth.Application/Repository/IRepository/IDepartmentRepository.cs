using DataInterface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository.IRepository
{
    public interface IDepartmentRepository : IGenericRepository<Department>
    {
        Task<Department> UpdateAsync(Department department);
    }
}
