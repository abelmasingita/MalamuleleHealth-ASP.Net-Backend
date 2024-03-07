using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository
{
    public class UnitOfWork : IUnitofWork
    {

        public ApplicationDBContext _dbSet { get; }
        public IDepartmentRepository Department { get; protected set; }

        public IAppointmentRepository Appointment { get; protected set; }

        public IBedRepository Bed { get; protected set; }

        public IInvoiceRepository Invoice { get; protected set; }

        public IMedicalHistoryRepository MedicalHistory { get; protected set; }

        public IMedicalTestRepository MedicalTest { get; protected set; }

        public IMessageRepository Message { get; protected set; }

        public IPaymentRepository Payment { get; protected set; }

        public IPrescriptionRepository Prescription { get; protected set; }

        public ITestResultRepository TestResult { get; protected set; }

        public IWardRepository Ward { get; protected set; }
        public ISpecialityRepository Speciality { get; protected set; }

        public UnitOfWork(ApplicationDBContext dbSet)
        {
            _dbSet = dbSet;
            Appointment = new AppointmentRepository(_dbSet);
            Bed = new BedRepository(_dbSet);
            Department = new DepartmentRepository(_dbSet);
            Invoice = new InvoiceRepository(_dbSet);
            MedicalHistory = new MedicalHistoryRepository(_dbSet);
            MedicalTest = new MedicalTestRepository(_dbSet);
            Message = new MessageRepository(_dbSet);
            Payment = new PaymentRepository(_dbSet);
            Prescription = new PrescriptionRepository(_dbSet);
            TestResult = new TestResultRepository(_dbSet);
            Ward = new WardRepository(_dbSet);
            Speciality = new SpecialityRepository(_dbSet);
        }

        public void Save()
        {
            _dbSet.SaveChanges();
        }
    }
}
