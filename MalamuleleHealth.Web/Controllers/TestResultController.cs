using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestResultController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public TestResultController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetTestResults")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<TestResult>))]
        public async Task<IActionResult> GetTestResults()
        {
            var dp = unitofWork.Department.GetList().GetAwaiter().GetResult();

            return Ok(dp);
        }


        [HttpGet("testResultId")]
        [ProducesResponseType(200, Type = typeof(TestResult))]
        [ProducesResponseType(400, Type = typeof(TestResult))]
        [ProducesResponseType(404, Type = typeof(TestResult))]
        public async Task<IActionResult> GetTestResult(Guid testResultId)
        {
            var tr = unitofWork.TestResult.Get(d => d.TestResultId == testResultId).GetAwaiter().GetResult();   
            if (tr == null)
            {
                return NotFound();
            }

            return Ok(tr);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(TestResult))]
        [ProducesResponseType(400, Type = typeof(TestResult))]
        public async Task<IActionResult> AddTestResult([FromBody] TestResult testResult)
        {
            if (testResult == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.TestResult.Add(testResult);
            unitofWork.Save();

            return NoContent();
        }

        [HttpPut("testResultId")]
        [ProducesResponseType(200, Type = typeof(TestResult))]
        [ProducesResponseType(400, Type = typeof(TestResult))]
        public async Task<IActionResult> UpdateTestResult(Guid testResultId,[FromBody] TestResult testResult)
        {
            if (testResult == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetTestResult(testResultId).GetAwaiter().GetResult() != null)
            {
                unitofWork.TestResult.Update(testResult);
                unitofWork.Save();
            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("testResultId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveTestResult(Guid testResultId)
        {
            var testResult = unitofWork.TestResult.Get(d => d.TestResultId == testResultId).GetAwaiter().GetResult();
            if (testResult == null)
            {
                return NotFound();
            }

            unitofWork.TestResult.Remove(testResult);
            unitofWork.Save();
            return NoContent();
        }
    }
}
