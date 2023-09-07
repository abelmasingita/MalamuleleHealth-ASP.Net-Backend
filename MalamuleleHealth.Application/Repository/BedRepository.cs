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
    public class BedRepository : GenericRepository<Bed>, IBedRepository
    {
        private readonly ApplicationDBContext dbContext;

        public BedRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Bed bed)
        {
            throw new NotImplementedException();
        }
    }
}
