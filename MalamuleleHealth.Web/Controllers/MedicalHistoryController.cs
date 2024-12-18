﻿using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicalHistoryController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public MedicalHistoryController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetMedicalHistories")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MedicalHistory>))]
        public async Task<IActionResult> GetMedicalHistories()
        {
            var md = unitofWork.MedicalHistory.GetList().GetAwaiter().GetResult();

            return Ok(md);
        }


        [HttpGet("medicalHistoryId")]
        [ProducesResponseType(200, Type = typeof(MedicalHistory))]
        [ProducesResponseType(400, Type = typeof(MedicalHistory))]
        [ProducesResponseType(404, Type = typeof(MedicalHistory))]
        public async Task<IActionResult> GetMedicalHistory(Guid medicalHistoryId)
        {
            var md = unitofWork.MedicalHistory.Get(md => md.Id == medicalHistoryId).GetAwaiter().GetResult();   
            if (md == null)
            {
                return NotFound();
            }

            return Ok(md);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(MedicalHistory))]
        [ProducesResponseType(400, Type = typeof(MedicalHistory))]
        public async Task<IActionResult> AddMedicalHistory([FromBody] MedicalHistory md)
        {
            if (md == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.MedicalHistory.Add(md);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut("medicalHistoryId")]
        [ProducesResponseType(200, Type = typeof(MedicalHistory))]
        [ProducesResponseType(400, Type = typeof(MedicalHistory))]
        public async Task<IActionResult> UpdateMedicalHistory(Guid medicalHistoryId , [FromBody] MedicalHistory md)
        {
            if (md == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetMedicalHistory(medicalHistoryId).GetAwaiter().GetResult() != null)
            {
                unitofWork.MedicalHistory.Update(md);
                unitofWork.Save();

            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }



        [HttpDelete("medicalHistoryId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveMedicalHistory(Guid medicalHistoryId)
        {
            var md = unitofWork.MedicalHistory.Get(d => d.Id == medicalHistoryId).GetAwaiter().GetResult();
            if (md == null)
            {
                return NotFound();
            }

            unitofWork.MedicalHistory.Remove(md);
            unitofWork.Save();
            return NoContent();
        }
    }
}
