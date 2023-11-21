using AutoMapper;
using DataInterface.Configurations.Dto.Department;
using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public DepartmentController(IUnitofWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetDepartments")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DepartmentDto>))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician, Patient")]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                var dp = await unitofWork.Department.GetList();
                var dep = mapper.Map<List<DepartmentDto>>(dp);

                return Ok(dep);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }


        [HttpGet("departmentId")]
        [ProducesResponseType(200, Type = typeof(DepartmentDto))]
        [ProducesResponseType(400, Type = typeof(DepartmentDto))]
        [ProducesResponseType(404, Type = typeof(DepartmentDto))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician, Patient")]
        public async Task<IActionResult> GetDepartment(Guid departmentId)
        {
            try
            {
                var dp = await unitofWork.Department.Get(d => d.Id == departmentId);

                var dep = mapper.Map<DepartmentDto>(dp);

                if (dep == null)
                {
                    return NotFound();
                }

                return Ok(dep);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(AddDepartmentDto))]
        [ProducesResponseType(400, Type = typeof(AddDepartmentDto))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddDepartment([FromBody] AddDepartmentDto createDepartment)
        {

            try
            {
                if (createDepartment == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var dp = mapper.Map<Department>(createDepartment);

                unitofWork.Department.Add(dp);
                unitofWork.Save();

                var mapped = mapper.Map<DepartmentDto>(dp);
                return Ok(mapped);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }



        [HttpPut("departmentId")]
        [ProducesResponseType(200, Type = typeof(DepartmentDto))]
        [ProducesResponseType(400, Type = typeof(DepartmentDto))]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateDepartment(Guid departmentId, [FromBody] DepartmentDto department)
        {

            try
            {
                if (department == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (GetDepartment(departmentId).GetAwaiter().GetResult() != null)
                {
                    var dp = mapper.Map<Department>(department);
                    var updated = await unitofWork.Department.UpdateAsync(dp);
                    unitofWork.Save();

                    return Ok(updated);
                }
                else
                {
                    return NotFound("Department Not Found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }


        [HttpDelete("departmentId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RemoveDepartment(Guid departmentId)
        {
            try
            {
                var dp = unitofWork.Department.Get(d => d.Id == departmentId).GetAwaiter().GetResult();
                if (dp == null)
                {
                    return NotFound();
                }

                unitofWork.Department.Remove(dp);
                unitofWork.Save();


                var response = new { Message = "Department Removed" };
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }
    }
}
