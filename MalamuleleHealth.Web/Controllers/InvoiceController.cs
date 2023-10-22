using AutoMapper;
using DataInterface.Configurations.Dto.Invoice;
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
    public class InvoiceController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;

        public InvoiceController(IUnitofWork unitofWork,IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetInvoices")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<InvoiceDto>))]
        public async Task<IActionResult> GetInvoices()
        {
            var ivc = unitofWork.Invoice.GetList().GetAwaiter().GetResult();

            return Ok(ivc);
        }


        [HttpGet("invoiceId")]
        [ProducesResponseType(200, Type = typeof(InvoiceDto))]
        [ProducesResponseType(400, Type = typeof(InvoiceDto))]
        [ProducesResponseType(404, Type = typeof(InvoiceDto))]
        public async Task<IActionResult> GetInvoice(Guid invoiceId)
        {
            var ivc = unitofWork.Invoice.Get(i => i.Id == invoiceId).GetAwaiter().GetResult();   
            if (ivc == null)
            {
                return NotFound();
            }

            return Ok(ivc);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(InvoiceDto))]
        [ProducesResponseType(400, Type = typeof(InvoiceDto))]
        public async Task<IActionResult> AddInvoice([FromBody] InvoiceDto invoice)
        {
            if (invoice == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var invc = mapper.Map<Invoice>(invoice);
            unitofWork.Invoice.Add(invc);
            unitofWork.Save();

            return NoContent();
        }


        [HttpPut("invoiceId")]
        [ProducesResponseType(200, Type = typeof(Invoice))]
        [ProducesResponseType(400, Type = typeof(Invoice))]
        public async Task<IActionResult> UpdateInvoice(Guid invoiceId , [FromBody] Invoice invoice)
        {
            if (invoice == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (GetInvoice(invoiceId).GetAwaiter().GetResult() != null)
            {
                unitofWork.Invoice.Update(invoice);
                unitofWork.Save();

            }
            else
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("invoiceId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveInvoice(Guid invoiceId)
        {
            var ivc = unitofWork.Invoice.Get(d => d.Id == invoiceId).GetAwaiter().GetResult();
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
