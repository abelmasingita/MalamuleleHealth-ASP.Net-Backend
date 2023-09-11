using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public WardController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetWards")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Ward>))]
        public async Task<IActionResult> GetWards()
        {
            var wards = unitofWork.Ward.GetList().GetAwaiter().GetResult();

            return Ok(wards);
        }


        [HttpGet("wardId")]
        [ProducesResponseType(200, Type = typeof(Ward))]
        [ProducesResponseType(400, Type = typeof(Ward))]
        [ProducesResponseType(404, Type = typeof(Ward))]
        public async Task<IActionResult> GetWard(Guid wardId)
        {
            var ward = unitofWork.Ward.Get(d => d.WardId == wardId).GetAwaiter().GetResult();   
            if (ward == null)
            {
                return NotFound();
            }

            return Ok(ward);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Ward))]
        [ProducesResponseType(400, Type = typeof(Ward))]
        public async Task<IActionResult> AddWard([FromBody] Ward ward)
        {
            if (ward == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Ward.Add(ward);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut]
        [ProducesResponseType(200, Type = typeof(Ward))]
        [ProducesResponseType(400, Type = typeof(Ward))]
        public async Task<IActionResult> UpdateWard([FromBody] Ward ward)
        {
            if (ward == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Ward.Update(ward);
            unitofWork.Save();

            return NoContent();
        }


        [HttpDelete("wardId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveWard(Guid wardId)
        {
            var ward = unitofWork.Ward.Get(d => d.WardId == wardId).GetAwaiter().GetResult();
            if (ward == null)
            {
                return NotFound();
            }

            unitofWork.Ward.Remove(ward);
            unitofWork.Save();
            return NoContent();
        }
    }
}
