using AutoMapper;
using DataInterface.Configurations.Dto.Appointment;
using DataInterface.Configurations.Dto.Department;
using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

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

        [HttpGet("GetAppointments")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AppointmentDto>))]
        [ProducesResponseType(400, Type = typeof(IEnumerable<AppointmentDto>))]
        [ProducesResponseType(500, Type = typeof(IEnumerable<AppointmentDto>))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetAppointments()
        {
            try
            {
                var ap = await unitofWork.Appointment.GetList();
                var apt = mapper.Map<List<AppointmentDto>>(ap);

                return Ok(apt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        [HttpGet("GetAppointment")]
        [ProducesResponseType(200, Type = typeof(AppointmentDto))]
        [ProducesResponseType(400, Type = typeof(AppointmentDto))]
        [ProducesResponseType(404, Type = typeof(AppointmentDto))]
        [Authorize]
        public async Task<IActionResult> GetAppointment(Guid appointmentId)
        {
            try
            {
                var ap = await unitofWork.Appointment.Get(a => a.Id == appointmentId);
                if (ap == null)
                {
                    return NotFound();
                }
                var apt = mapper.Map<AppointmentDto>(ap);
                return Ok(apt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        [HttpPost("AddAppointment")]
        [ProducesResponseType(200, Type = typeof(AddAppointmentDto))]
        [ProducesResponseType(400, Type = typeof(AddAppointmentDto))]
        public async Task<IActionResult> AddAppointment([FromBody] AddAppointmentDto appointment)
        {
            try
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
                var mapped = mapper.Map<AppointmentDto>(appointment);

                return Ok(mapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }


        [HttpPut("UpdateAppointment")]
        [ProducesResponseType(200, Type = typeof(AppointmentDto))]
        [ProducesResponseType(400, Type = typeof(AppointmentDto))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician, Patient")]
        public async Task<IActionResult> UpdateAppointment(Guid appointmentId, [FromBody] AppointmentDto appointment)
        {

            try
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
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }


        [HttpDelete("DeleteAppointment")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RemoveAppointment(Guid appointmentId)
        {

            try
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
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
