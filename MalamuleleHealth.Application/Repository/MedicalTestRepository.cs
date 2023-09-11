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
    public class MedicalTestRepository : GenericRepository<MedicalTest>, IMedicalTestRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MedicalTestRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(MedicalTest medicalTest)
        {
            var mt = dbContext.MedicalTests.FirstAsync(a => a.MedicalTestId == medicalTest.MedicalTestId).GetAwaiter().GetResult();

            if (mt != null)
            {
                mt.Cost = medicalTest.Cost;
                mt.TestName = medicalTest.TestName;
            }
        }
    }
}
