using DataInterface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository.IRepository
{
    public interface IMedicalTestRepository : IGenericRepository<MedicalTest>
    {
        void Update(MedicalTest medicalTest);
    }
}
