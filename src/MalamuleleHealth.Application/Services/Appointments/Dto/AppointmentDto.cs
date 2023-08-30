using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using MalamuleleHealth.Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalamuleleHealth.Services.Appointments.Dto
{
    [AutoMap(typeof(Appointment))]
    public class AppointmentDto : AuditedEntityDto<Guid>
    {

        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }

        public int? PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual UserRole Patient { get; set; }

        public int? DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual UserRole Doctor { get; set; }
    }
}
