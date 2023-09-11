using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public MessageController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetMessages")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Message>))]
        public async Task<IActionResult> GetMessages()
        {
            var mg = unitofWork.Message.GetList().GetAwaiter().GetResult();

            return Ok(mg);
        }


        [HttpGet("messageId")]
        [ProducesResponseType(200, Type = typeof(Message))]
        [ProducesResponseType(400, Type = typeof(Message))]
        [ProducesResponseType(404, Type = typeof(Message))]
        public async Task<IActionResult> GetMessage(Guid messageId)
        {
            var mg = unitofWork.Message.Get(d => d.MessageId == messageId).GetAwaiter().GetResult();   
            if (mg == null)
            {
                return NotFound();
            }

            return Ok(mg);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Message))]
        [ProducesResponseType(400, Type = typeof(Message))]
        public async Task<IActionResult> AddMessage([FromBody] Message message)
        {
            if (message == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Message.Add(message);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut]
        [ProducesResponseType(200, Type = typeof(Message))]
        [ProducesResponseType(400, Type = typeof(Message))]
        public async Task<IActionResult> UpdateMessage([FromBody] Message message)
        {
            if (message == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Message.Update(message);
            unitofWork.Save();

            return NoContent();
        }


        [HttpDelete("messageId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveDepartment(Guid messageId)
        {
            var mg = unitofWork.Message.Get(d => d.MessageId == messageId).GetAwaiter().GetResult();
            if (mg == null)
            {
                return NotFound();
            }

            unitofWork.Message.Remove(mg);
            unitofWork.Save();
            return NoContent();
        }
    }
}
