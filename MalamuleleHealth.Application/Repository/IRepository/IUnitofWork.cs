using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository.IRepository
{
    public interface IUnitofWork
    {
        IDepartmentRepository Department { get; }
        IAppointmentRepository Appointment { get; }
        IBedRepository Bed { get; }
        IInvoiceRepository Invoice { get; }
        IMedicalHistoryRepository MedicalHistory { get; }
        IMedicalTestRepository MedicalTest { get; }
        IMessageRepository Message { get; }
        IPaymentRepository Payment { get; }
        IPrescriptionRepository Prescription { get; }
        ITestResultRepository TestResult { get; }
        IWardRepository Ward { get; }
        ISpecialityRepository Speciality { get; }
        void Save();
    }
}
