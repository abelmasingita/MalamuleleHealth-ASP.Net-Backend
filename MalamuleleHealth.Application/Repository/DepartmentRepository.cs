using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDBContext dbContext;

        public DepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<Department> UpdateAsync(Department department)
        {
            var dp = await dbContext.Departments.FirstAsync(d => d.Id == department.Id);

            if (dp != null)
            {
                dp.Name = department.Name;
                dp.Description = department.Description;
            }

            return (dp);
        }
    }
}
