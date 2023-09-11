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
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        private readonly ApplicationDBContext dbContext;

        public MessageRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Update(Message message)
        {
            var m = dbContext.Messages.FirstAsync(a => a.MessageId == message.MessageId).GetAwaiter().GetResult();

            if (m != null)
            {
                m.Purpose = message.Purpose;
                m.Status = message.Status;
                m.AppointmentTime = message.AppointmentTime;
                m.AppointmentDate = message.AppointmentDate;
            }
        }
    }
}
