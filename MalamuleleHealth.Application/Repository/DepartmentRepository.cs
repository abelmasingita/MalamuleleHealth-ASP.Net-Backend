using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore;
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

        public void Update(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
