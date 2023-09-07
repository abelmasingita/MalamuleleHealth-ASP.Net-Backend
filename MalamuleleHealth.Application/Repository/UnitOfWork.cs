using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalamuleleHealth.Application.Repository
{
    public class UnitOfWork : IUnitofWork
    {

        public ApplicationDBContext _dbSet { get; }
        public IDepartmentRepository Department { get; protected set; }

        public UnitOfWork(ApplicationDBContext dbSet)
        {
            _dbSet = dbSet;
            Department = new DepartmentRepository(_dbSet);
        }

        public void Save()
        {
            _dbSet.SaveChanges();
        }
    }
}
