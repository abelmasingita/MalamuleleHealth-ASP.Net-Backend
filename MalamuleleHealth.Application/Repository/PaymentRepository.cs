﻿using DataInterface.Domain;
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
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        private readonly ApplicationDBContext dbContext;

        public PaymentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Payment payment)
        {
            var p = dbContext.Payments.FirstAsync(a => a.Id == payment.Id).GetAwaiter().GetResult();

            if (p != null)
            {
                p.Amount = payment.Amount;
                p.PaymentDate = payment.PaymentDate;
            }
        }
    }
}
