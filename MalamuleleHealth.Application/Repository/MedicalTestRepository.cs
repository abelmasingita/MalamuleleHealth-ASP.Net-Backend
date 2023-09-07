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
    public class MedicalTestRepository : GenericRepository<MedicalTest>, IMedicalTestRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MedicalTestRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(MedicalTest medicalTest)
        {
            throw new NotImplementedException();
        }
    }
}
