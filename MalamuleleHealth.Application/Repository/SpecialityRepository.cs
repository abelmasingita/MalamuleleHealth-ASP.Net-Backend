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
    public class SpecialityRepository : GenericRepository<Specialty>, ISpecialityRepository
    {
        private readonly ApplicationDBContext dbContext;

        public SpecialityRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Specialty specialty)
        {
            var sp = dbContext.Specialties.FirstAsync(a => a.Id == specialty.Id).GetAwaiter().GetResult();

            if (sp != null)
            {
                sp.Name = specialty.Name;
            }
        }
    }
}
