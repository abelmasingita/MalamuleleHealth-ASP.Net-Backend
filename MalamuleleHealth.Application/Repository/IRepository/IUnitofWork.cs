using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository.IRepository
{
    public interface IUnitofWork
    {
        IDepartmentRepository Department { get; }

        void Save();
    }
}
