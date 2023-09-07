﻿using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public AppointmentController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetAppointments")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Appointment>))]
        public async Task<IActionResult> GetAppointments()
        {
            var ap = unitofWork.Appointment.GetList().GetAwaiter().GetResult();

            return Ok(ap);
        }


        [HttpGet("appointmentId")]
        [ProducesResponseType(200, Type = typeof(Appointment))]
        [ProducesResponseType(400, Type = typeof(Appointment))]
        [ProducesResponseType(404, Type = typeof(Appointment))]
        public async Task<IActionResult> GetAppointment(Guid appointmentId)
        {
            var ap = unitofWork.Appointment.Get(a => a.AppointmentId == appointmentId).GetAwaiter().GetResult();   
            if (ap == null)
            {
                return NotFound();
            }

            return Ok(ap);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Appointment))]
        [ProducesResponseType(400, Type = typeof(Appointment))]
        public async Task<IActionResult> AddAppointment([FromBody] Appointment appointment)
        {
            if (appointment == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Appointment.Add(appointment);
            unitofWork.Save();

            return NoContent();
        }


        [HttpDelete("appointmentId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveAppointment(Guid appointmentId)
        {
            var ap = unitofWork.Appointment.Get(a => a.AppointmentId == appointmentId).GetAwaiter().GetResult();
            if (ap == null)
            {
                return NotFound();
            }

            unitofWork.Appointment.Remove(ap);
            unitofWork.Save();
            return NoContent();
        }
    }
}
