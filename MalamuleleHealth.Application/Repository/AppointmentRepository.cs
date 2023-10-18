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
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly ApplicationDBContext dbContext;

        public AppointmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Appointment> UpdateAsync(Appointment appointment)
        {
            var appointmentdb = await dbContext.Appointments.FirstAsync(a => a.Id == appointment.Id);

            if (appointmentdb != null)
            {
                appointmentdb.AppointmentDate = appointment.AppointmentDate;
                appointmentdb.AppointmentTime = appointment.AppointmentTime;
                appointmentdb.Status = appointment.Status;
                appointmentdb.Purpose = appointment.Purpose;
                appointmentdb.Type = appointment.Type;
                appointment.DoctorId = appointment.DoctorId;
            }
            return appointmentdb;
        }
    }
}
