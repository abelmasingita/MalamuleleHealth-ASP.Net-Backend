using AutoMapper;
using DataInterface.Configurations.Dto.Appointment;
using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public AppointmentController(IUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetAppointments")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AppointmentDto>))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetAppointments()
        {
            var ap = await unitofWork.Appointment.GetList();

            return Ok(ap);
        }

        [HttpGet("appointmentId")]
        [ProducesResponseType(200, Type = typeof(AppointmentDto))]
        [ProducesResponseType(400, Type = typeof(AppointmentDto))]
        [ProducesResponseType(404, Type = typeof(AppointmentDto))]
        [Authorize]
        public async Task<IActionResult> GetAppointment(Guid appointmentId)
        {
            var ap =await unitofWork.Appointment.Get(a => a.Id == appointmentId);   
            if (ap == null)
            {
                return NotFound();
            }

            return Ok( ap);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(AddAppointmentDto))]
        [ProducesResponseType(400, Type = typeof(AddAppointmentDto))]
        public async Task<IActionResult> AddAppointment([FromBody] AddAppointmentDto appointment)
        {
            if (appointment == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
  
            var apt = mapper.Map<Appointment>(appointment);

            unitofWork.Appointment.Add(apt);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut("appointmentId")]
        [ProducesResponseType(200, Type = typeof(AppointmentDto))]
        [ProducesResponseType(400, Type = typeof(AppointmentDto))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician, Patient")]
        public async Task<IActionResult> UpdateAppointment(Guid appointmentId, [FromBody] AppointmentDto appointment)
        {
            if (appointment == null)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetAppointment(appointmentId).GetAwaiter().GetResult() != null)
            {
                var apt = mapper.Map<Appointment>(appointment);
                var updated = await unitofWork.Appointment.UpdateAsync(apt);
                unitofWork.Save();

                return Ok(updated);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpDelete("appointmentId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RemoveAppointment(Guid appointmentId)
        {
            var ap = unitofWork.Appointment.Get(a => a.Id == appointmentId).GetAwaiter().GetResult();
            if (ap == null)
            {
                return NotFound();
            }

            unitofWork.Appointment.Remove(ap);
            unitofWork.Save();

            var response = new { Message = "Appointment Removed" };
            return Ok(response);
        }
    }
}
