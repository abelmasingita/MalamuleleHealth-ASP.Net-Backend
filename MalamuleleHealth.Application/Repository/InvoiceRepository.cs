using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        private readonly ApplicationDBContext dbContext;

        public InvoiceRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Invoice invoice)
        {
            var inv = dbContext.Invoices.FirstAsync(i => i.Id == invoice.Id).GetAwaiter().GetResult();

            if (inv != null)
            {
                inv.Status = invoice.Status;
                inv.DueDate = invoice.DueDate;
                inv.TotalAmount = invoice.TotalAmount;
            }
        }
    }
}
