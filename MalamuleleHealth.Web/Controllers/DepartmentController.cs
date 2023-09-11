using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public DepartmentController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetDepartments")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Department>))]
        public async Task<IActionResult> GetDepartments()
        {
            var dp = unitofWork.Department.GetList().GetAwaiter().GetResult();

            return Ok(dp);
        }


        [HttpGet("departmentId")]
        [ProducesResponseType(200, Type = typeof(Department))]
        [ProducesResponseType(400, Type = typeof(Department))]
        [ProducesResponseType(404, Type = typeof(Department))]
        public async Task<IActionResult> GetDepartment(Guid departmentId)
        {
            var dp = unitofWork.Department.Get(d => d.DepartmentId == departmentId).GetAwaiter().GetResult();   
            if (dp == null)
            {
                return NotFound();
            }

            return Ok(dp);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Department))]
        [ProducesResponseType(400, Type = typeof(Department))]
        public async Task<IActionResult> AddDepartment([FromBody] Department createDepartment)
        {
            if (createDepartment == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Department.Add(createDepartment);
            unitofWork.Save();

            return NoContent();
        }



        [HttpPut("departmentId")]
        [ProducesResponseType(200, Type = typeof(Department))]
        [ProducesResponseType(400, Type = typeof(Department))]
        public async Task<IActionResult> UpdateDepartment(Guid departmentId, [FromBody] Department department)
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
                unitofWork.Department.Update(department);
                unitofWork.Save();
            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("departmentId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveDepartment(Guid departmentId)
        {
            var dp = unitofWork.Department.Get(d => d.DepartmentId == departmentId).GetAwaiter().GetResult();
            if (dp == null)
            {
                return NotFound();
            }

            unitofWork.Department.Remove(dp);
            unitofWork.Save();
            return NoContent();
        }
    }
}
