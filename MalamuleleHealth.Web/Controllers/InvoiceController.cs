using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;

        public InvoiceController(IUnitofWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet(Name = "GetInvoices")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Invoice>))]
        public async Task<IActionResult> GetInvoices()
        {
            var ivc = unitofWork.Invoice.GetList().GetAwaiter().GetResult();

            return Ok(ivc);
        }


        [HttpGet("invoiceId")]
        [ProducesResponseType(200, Type = typeof(Invoice))]
        [ProducesResponseType(400, Type = typeof(Invoice))]
        [ProducesResponseType(404, Type = typeof(Invoice))]
        public async Task<IActionResult> GetInvoice(Guid invoiceId)
        {
            var ivc = unitofWork.Invoice.Get(i => i.InvoiceId == invoiceId).GetAwaiter().GetResult();   
            if (ivc == null)
            {
                return NotFound();
            }

            return Ok(ivc);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(Invoice))]
        [ProducesResponseType(400, Type = typeof(Invoice))]
        public async Task<IActionResult> AddInvoice([FromBody] Invoice invoice)
        {
            if (invoice == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            unitofWork.Invoice.Add(invoice);
            unitofWork.Save();

            return NoContent();
        }


        [HttpDelete("invoiceId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveInvoice(Guid invoiceId)
        {
            var ivc = unitofWork.Invoice.Get(d => d.InvoiceId == invoiceId).GetAwaiter().GetResult();
            if (ivc == null)
            {
                return NotFound();
            }

            unitofWork.Invoice.Remove(ivc);
            unitofWork.Save();
            return NoContent();
        }
    }
}
