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
    public class BedController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public BedController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [Authorize]
        [HttpGet(Name = "GetBeds")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Bed>))]
        public async Task<IActionResult> GetBeds()
        {
            var bed = unitofWork.Bed.GetList().GetAwaiter().GetResult();

            return Ok(bed);
        }

        [Authorize]
        [HttpGet("bedId")]
        [ProducesResponseType(200, Type = typeof(Bed))]
        [ProducesResponseType(400, Type = typeof(Bed))]
        [ProducesResponseType(404, Type = typeof(Bed))]
        public async Task<IActionResult> GetBed(Guid bedId)
        {
            var bed = unitofWork.Bed.Get(d => d.BedId == bedId).GetAwaiter().GetResult();   
            if (bed == null)
            {
                return NotFound();
            }

            return Ok(bed);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Bed))]
        [ProducesResponseType(400, Type = typeof(Bed))]
        public async Task<IActionResult> AddBed([FromBody] Bed bed)
        {
            if (bed == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Bed.Add(bed);
            unitofWork.Save();

            return NoContent();
        }

        [HttpPut("bedId")]
        [ProducesResponseType(200, Type = typeof(Bed))]
        [ProducesResponseType(400, Type = typeof(Bed))]
        public async Task<IActionResult> UpdateBed(Guid bedId ,[FromBody] Bed bed)
        {
            if (bed == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetBed(bedId).GetAwaiter().GetResult() != null)
            {
                unitofWork.Bed.Update(bed);
                unitofWork.Save();

            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("bedId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveBed(Guid bedId)
        {
            var bed = unitofWork.Bed.Get(b => b.BedId == bedId).GetAwaiter().GetResult();
            if (bed == null)
            {
                return NotFound();
            }

            unitofWork.Bed.Remove(bed);
            unitofWork.Save();
            return NoContent();
        }
    }
}
