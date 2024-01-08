using AutoMapper;
using DataInterface.Configurations.Dto.Ward;
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
    public class WardController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;
        public WardController(IUnitofWork unitofWork,IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        [HttpGet("GetWards")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<WardDto>))]
        [ProducesResponseType(400, Type = typeof(IEnumerable<WardDto>))]
        [ProducesResponseType(404, Type = typeof(IEnumerable<WardDto>))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetWards()
        {
            try
            {
                var wards = unitofWork.Ward.GetList().GetAwaiter().GetResult();
                var mapped = mapper.Map<WardDto>(wards);

                return Ok(mapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }


        [HttpGet("GetWard")]
        [ProducesResponseType(200, Type = typeof(WardDto))]
        [ProducesResponseType(400, Type = typeof(WardDto))]
        [ProducesResponseType(404, Type = typeof(WardDto))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetWard(Guid wardId)
        {

            try
            {
                var ward = unitofWork.Ward.Get(d => d.Id == wardId).GetAwaiter().GetResult();
                if (ward == null)
                {
                    return NotFound();
                }

                var mapped = mapper.Map<WardDto>(ward);

                return Ok(mapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        [HttpPost("AddWard")]
        [ProducesResponseType(200, Type = typeof(WardDto))]
        [ProducesResponseType(204, Type = typeof(WardDto))]
        [ProducesResponseType(400, Type = typeof(WardDto))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddWard([FromBody] AddWardDto ward)
        {

            try
            {
                if (ward == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var mapped = mapper.Map<Ward>(ward);
                unitofWork.Ward.Add(mapped);
                unitofWork.Save();

                return Ok(mapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }


        [HttpPut("UpdateWard")]
        [ProducesResponseType(200, Type = typeof(Ward))]
        [ProducesResponseType(400, Type = typeof(Ward))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateWard(Guid wardId,[FromBody] Ward ward)
        {

            try
            {
                if (ward == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (GetWard(wardId).GetAwaiter().GetResult() != null)
                {
                    unitofWork.Ward.Update(ward);
                    unitofWork.Save();
                }
                else
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }


        [HttpDelete("RemoveWard")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult RemoveWard(Guid wardId)
        {
            var ward = unitofWork.Ward.Get(d => d.Id == wardId).GetAwaiter().GetResult();
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
