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
    public class MedicalHistoryRepository : GenericRepository<MedicalHistory>, IMedicalHistoryRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MedicalHistoryRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(MedicalHistory medicalHistory)
        {
            throw new NotImplementedException();
        }
    }
}
