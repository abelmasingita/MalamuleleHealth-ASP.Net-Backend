using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public PrescriptionController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetPrescriptions")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Prescription>))]
        public async Task<IActionResult> GetPrescriptions()
        {
            var dp = unitofWork.Prescription.GetList().GetAwaiter().GetResult();

            return Ok(dp);
        }


        [HttpGet("prescriptionId")]
        [ProducesResponseType(200, Type = typeof(Prescription))]
        [ProducesResponseType(400, Type = typeof(Prescription))]
        [ProducesResponseType(404, Type = typeof(Prescription))]
        public async Task<IActionResult> GetDepartment(Guid prescriptionId)
        {
            var prescription = unitofWork.Prescription.Get(d => d.PrescriptionId == prescriptionId).GetAwaiter().GetResult();   
            if (prescription == null)
            {
                return NotFound();
            }

            return Ok(prescription);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Prescription))]
        [ProducesResponseType(400, Type = typeof(Prescription))]
        public async Task<IActionResult> AddDepartment([FromBody] Prescription prescription)
        {
            if (prescription == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Prescription.Add(prescription);
            unitofWork.Save();

            return NoContent();
        }


        [HttpDelete("prescriptionId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveDepartment(Guid prescriptionId)
        {
            var prescrption = unitofWork.Prescription.Get(d => d.PrescriptionId == prescriptionId).GetAwaiter().GetResult();
            if (prescrption == null)
            {
                return NotFound();
            }

            unitofWork.Prescription.Remove(prescrption);
            unitofWork.Save();
            return NoContent();
        }
    }
}
