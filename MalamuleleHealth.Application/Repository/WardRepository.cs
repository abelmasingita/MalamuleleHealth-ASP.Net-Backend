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
    public class WardRepository : GenericRepository<Ward>, IWardRepository
    {
        private readonly ApplicationDBContext dbContext;

        public WardRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Ward ward)
        {
            var w = dbContext.Wards.FirstAsync(a => a.Id == ward.Id).GetAwaiter().GetResult();

            if (w != null)
            {
                w.Name = ward.Name;
            }
        }
    }
}
