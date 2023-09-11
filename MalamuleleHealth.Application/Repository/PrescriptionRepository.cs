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
    public class PrescriptionRepository : GenericRepository<Prescription>, IPrescriptionRepository
    {
        private readonly ApplicationDBContext dbContext;

        public PrescriptionRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Prescription prescription)
        {
            var p = dbContext.Prescriptions.FirstAsync(a => a.PrescriptionId == prescription.PrescriptionId).GetAwaiter().GetResult();

            if (p != null)
            {
                p.Instructions = prescription.Instructions;
                p.Medication = prescription.Medication;
                p.PrescriptionDate = prescription.PrescriptionDate;
            }
        }
    }
}
