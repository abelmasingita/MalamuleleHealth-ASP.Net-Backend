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
    public class TestResultRepository : GenericRepository<TestResult>, ITestResultRepository
    {
        private readonly ApplicationDBContext dbContext;

        public TestResultRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(TestResult testResult)
        {
            var tr = dbContext.TestResults.FirstAsync(a => a.TestResultId == testResult.TestResultId).GetAwaiter().GetResult();

            if (tr != null)
            {
                tr.ResultDetails = testResult.ResultDetails;
                tr.TestDate = testResult.TestDate;
            }
        }
    }
}
