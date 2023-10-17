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
    public class MedicalHistoryRepository : GenericRepository<MedicalHistory>, IMedicalHistoryRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MedicalHistoryRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(MedicalHistory medicalHistory)
        {
            var md = dbContext.MedicalHistories.FirstAsync(a => a.Id == medicalHistory.Id).GetAwaiter().GetResult();

            if (md != null)
            {
                md.Treatment = medicalHistory.Treatment;
                md.DiagnosisDate = medicalHistory.DiagnosisDate;
                md.MedicalCondition = medicalHistory.MedicalCondition;
            }
        }
    }
}
