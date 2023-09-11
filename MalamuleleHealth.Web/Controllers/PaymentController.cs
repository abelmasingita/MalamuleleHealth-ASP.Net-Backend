using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public PaymentController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetPayments")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Payment>))]
        public async Task<IActionResult> GetPayments()
        {
            var payments = unitofWork.Payment.GetList().GetAwaiter().GetResult();

            return Ok(payments);
        }


        [HttpGet("paymentId")]
        [ProducesResponseType(200, Type = typeof(Payment))]
        [ProducesResponseType(400, Type = typeof(Payment))]
        [ProducesResponseType(404, Type = typeof(Payment))]
        public async Task<IActionResult> GetPayment(Guid paymentId)
        {
            var payment = unitofWork.Payment.Get(d => d.PaymentId == paymentId).GetAwaiter().GetResult();   
            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Payment))]
        [ProducesResponseType(400, Type = typeof(Payment))]
        public async Task<IActionResult> AddPayment([FromBody] Payment payment)
        {
            if (payment == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Payment.Add(payment);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut("paymentId")]
        [ProducesResponseType(200, Type = typeof(Payment))]
        [ProducesResponseType(400, Type = typeof(Payment))]
        public async Task<IActionResult> UpdatePayment(Guid paymentId,[FromBody] Payment payment)
        {
            if (payment == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetPayment(paymentId).GetAwaiter().GetResult() != null)
            {
                unitofWork.Payment.Update(payment);
                unitofWork.Save();
            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }



        [HttpDelete("paymentId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemovePayment(Guid paymentId)
        {
            var payment = unitofWork.Payment.Get(d => d.PaymentId == paymentId).GetAwaiter().GetResult();
            if (payment == null)
            {
                return NotFound();
            }

            unitofWork.Payment.Remove(payment);
            unitofWork.Save();
            return NoContent();
        }
    }
}
