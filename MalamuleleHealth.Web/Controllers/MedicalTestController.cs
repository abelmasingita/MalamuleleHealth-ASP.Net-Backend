using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicalTestController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public MedicalTestController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetmedicalTests")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MedicalTest>))]
        public async Task<IActionResult> GetMedicalTests()
        {
            var dp = unitofWork.MedicalTest.GetList().GetAwaiter().GetResult();

            return Ok(dp);
        }


        [HttpGet("medicalTestId")]
        [ProducesResponseType(200, Type = typeof(MedicalTest))]
        [ProducesResponseType(400, Type = typeof(MedicalTest))]
        [ProducesResponseType(404, Type = typeof(MedicalTest))]
        public async Task<IActionResult> GetMedicalTest(Guid medicalTestId)
        {
            var mt = unitofWork.MedicalTest.Get(d => d.Id == medicalTestId).GetAwaiter().GetResult();   
            if (mt == null)
            {
                return NotFound();
            }

            return Ok(mt);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(MedicalTest))]
        [ProducesResponseType(400, Type = typeof(MedicalTest))]
        public async Task<IActionResult> AddMedicalTest([FromBody] MedicalTest medicalTest)
        {
            if (medicalTest == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.MedicalTest.Add(medicalTest);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut("medicalTestId")]
        [ProducesResponseType(200, Type = typeof(MedicalTest))]
        [ProducesResponseType(400, Type = typeof(MedicalTest))]
        public async Task<IActionResult> UpdateMedicalTest(Guid medicalTestId, [FromBody] MedicalTest medicalTest)
        {
            if (medicalTest == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetMedicalTest(medicalTestId).GetAwaiter().GetResult() != null)
            {
                unitofWork.MedicalTest.Update(medicalTest);
                unitofWork.Save();
            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("medcialTestId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveMedicalTest(Guid medcialTestId)
        {
            var mt = unitofWork.MedicalTest.Get(d => d.Id == medcialTestId).GetAwaiter().GetResult();
            if (mt == null)
            {
                return NotFound();
            }

            unitofWork.MedicalTest.Remove(mt);
            unitofWork.Save();
            return NoContent();
        }
    }
}
